using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Accord.WindowsForms;
using System.IO;
using System.Text.RegularExpressions;

namespace NeuralNetwork1
{
    class TLGBotik
    {
        public Telegram.Bot.TelegramBotClient botik = null;

        private BaseNetwork perseptron = null;
        private MagicEye magicEye = null;

        private string[] classLabels;

        public delegate string TalkToAIML(string phrase, Telegram.Bot.Types.User tlgUsr);

        private TalkToAIML talk;

        public TLGBotik(BaseNetwork net, Settings settings, string[] labels, TalkToAIML talkTo)
        {
            magicEye = new MagicEye();
            magicEye.settings = settings;
            magicEye.settings.processImg = true;
            magicEye.settings.border = 160;
            classLabels = labels;
            perseptron = net;
            var key = System.IO.File.ReadAllText("..\\..\\botKey.txt");
            botik = new TelegramBotClient(key);
            talk = new TalkToAIML(talkTo);
            botik.OnMessage += OnMessage;
        }
        async Task OnMessage(Message msg, UpdateType type)
        {
            if (msg.Text == "/start")
            {
                var result = talk("СТАРТ", msg.From);
                await botik.SendMessage(msg.Chat, result);
            }
            else if (msg.Type == MessageType.Photo)
            {
                var fileId = msg.Photo.Last().FileId;
                var fileInfo = await botik.GetFile(fileId);
                var filePath = fileInfo.FilePath;
                
                var stream = new MemoryStream();
                await botik.DownloadFile(filePath, stream);
                var img = System.Drawing.Image.FromStream(stream);
                magicEye.ProcessImage(new System.Drawing.Bitmap(img));
                var sample = new Sample(magicEye.sensors, 7);
                perseptron.Predict(sample);

                var result = talk($"{(new Regex(@"(?<=\().+(?=\))")).Match(classLabels[sample.recognizedClass]).Groups[0].Value}", msg.From);
                await botik.SendMessage(msg.Chat, result);
            }
            else if (msg.Type == MessageType.Text)
            {
                var result = talk(msg.Text, msg.From);
                await botik.SendMessage(msg.Chat, result);
            }
            else
            {
                var result = talk("СТРАННОЕ", msg.From);
                await botik.SendMessage(msg.Chat, result);
            }
        }

    }
}
