﻿namespace Accord.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label12;
            this.cmbVideoSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processedImgBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.letterIndex = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.marginTrackBar = new System.Windows.Forms.TrackBar();
            this.borderTrackBar = new System.Windows.Forms.TrackBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ticksLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.loadDataset = new System.Windows.Forms.Button();
            this.saveDataset = new System.Windows.Forms.Button();
            this.resolutionsBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.netTypeBox = new System.Windows.Forms.ComboBox();
            this.parallelCheckBox = new System.Windows.Forms.CheckBox();
            this.netStructureBox = new System.Windows.Forms.TextBox();
            this.recreateNetButton = new System.Windows.Forms.Button();
            this.testNetButton = new System.Windows.Forms.Button();
            this.netTrainButton = new System.Windows.Forms.Button();
            this.AccuracyCounter = new System.Windows.Forms.TrackBar();
            this.EpochesCounter = new System.Windows.Forms.NumericUpDown();
            this.nnStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.startBot = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTrackBar)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(30, 238);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 17);
            label6.TabIndex = 9;
            label6.Text = "Точность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(92, 91);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 17);
            label5.TabIndex = 7;
            label5.Text = "Количество эпох";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(103, 58);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(110, 17);
            label8.TabIndex = 2;
            label8.Text = "Структура сети";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(1340, 469);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(52, 17);
            label12.TabIndex = 38;
            label12.Text = "Status:";
            // 
            // cmbVideoSource
            // 
            this.cmbVideoSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbVideoSource.FormattingEnabled = true;
            this.cmbVideoSource.Location = new System.Drawing.Point(17, 737);
            this.cmbVideoSource.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVideoSource.Name = "cmbVideoSource";
            this.cmbVideoSource.Size = new System.Drawing.Size(291, 24);
            this.cmbVideoSource.TabIndex = 1;
            this.cmbVideoSource.SelectionChangeCommitted += new System.EventHandler(this.cmbVideoSource_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 718);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор камеры";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(317, 760);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(167, 37);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.originalImageBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(683, 639);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(8, 15);
            this.originalImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(667, 615);
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            this.originalImageBox.Click += new System.EventHandler(this.originalImageBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.processedImgBox);
            this.panel1.Location = new System.Drawing.Point(692, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 547);
            this.panel1.TabIndex = 12;
            // 
            // processedImgBox
            // 
            this.processedImgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedImgBox.Location = new System.Drawing.Point(0, 0);
            this.processedImgBox.Margin = new System.Windows.Forms.Padding(4);
            this.processedImgBox.Name = "processedImgBox";
            this.processedImgBox.Size = new System.Drawing.Size(588, 543);
            this.processedImgBox.TabIndex = 0;
            this.processedImgBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.letterIndex);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tresholdTrackBar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.marginTrackBar);
            this.panel2.Controls.Add(this.borderTrackBar);
            this.panel2.Location = new System.Drawing.Point(692, 570);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 248);
            this.panel2.TabIndex = 18;
            // 
            // letterIndex
            // 
            this.letterIndex.AllowDrop = true;
            this.letterIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.letterIndex.FormattingEnabled = true;
            this.letterIndex.Items.AddRange(new object[] {
            "α (альфа)",
            "γ (гамма)",
            "φ (фи)",
            "π (пи)",
            "λ (лямбда)",
            "κ (каппа)",
            "ω (омега)"});
            this.letterIndex.Location = new System.Drawing.Point(232, 176);
            this.letterIndex.Margin = new System.Windows.Forms.Padding(4);
            this.letterIndex.Name = "letterIndex";
            this.letterIndex.Size = new System.Drawing.Size(289, 24);
            this.letterIndex.TabIndex = 35;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(232, 112);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 21);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Обработать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Порог";
            // 
            // tresholdTrackBar
            // 
            this.tresholdTrackBar.LargeChange = 1;
            this.tresholdTrackBar.Location = new System.Drawing.Point(9, 164);
            this.tresholdTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.tresholdTrackBar.Maximum = 255;
            this.tresholdTrackBar.Name = "tresholdTrackBar";
            this.tresholdTrackBar.Size = new System.Drawing.Size(187, 56);
            this.tresholdTrackBar.TabIndex = 22;
            this.tresholdTrackBar.TickFrequency = 25;
            this.tresholdTrackBar.Value = 120;
            this.tresholdTrackBar.ValueChanged += new System.EventHandler(this.tresholdTrackBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Зазор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поля";
            // 
            // marginTrackBar
            // 
            this.marginTrackBar.LargeChange = 10;
            this.marginTrackBar.Location = new System.Drawing.Point(216, 38);
            this.marginTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.marginTrackBar.Maximum = 40;
            this.marginTrackBar.Name = "marginTrackBar";
            this.marginTrackBar.Size = new System.Drawing.Size(187, 56);
            this.marginTrackBar.TabIndex = 19;
            this.marginTrackBar.TickFrequency = 4;
            this.marginTrackBar.Value = 10;
            this.marginTrackBar.ValueChanged += new System.EventHandler(this.marginTrackBar_ValueChanged);
            // 
            // borderTrackBar
            // 
            this.borderTrackBar.LargeChange = 60;
            this.borderTrackBar.Location = new System.Drawing.Point(9, 38);
            this.borderTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.borderTrackBar.Maximum = 160;
            this.borderTrackBar.Name = "borderTrackBar";
            this.borderTrackBar.Size = new System.Drawing.Size(187, 56);
            this.borderTrackBar.TabIndex = 18;
            this.borderTrackBar.TickFrequency = 10;
            this.borderTrackBar.Value = 40;
            this.borderTrackBar.Scroll += new System.EventHandler(this.borderTrackBar_Scroll);
            this.borderTrackBar.ValueChanged += new System.EventHandler(this.borderTrackBar_ValueChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(13, 650);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(96, 29);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Статус:";
            // 
            // ticksLabel
            // 
            this.ticksLabel.AutoSize = true;
            this.ticksLabel.Location = new System.Drawing.Point(501, 716);
            this.ticksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticksLabel.Name = "ticksLabel";
            this.ticksLabel.Size = new System.Drawing.Size(175, 17);
            this.ticksLabel.TabIndex = 30;
            this.ticksLabel.Text = "Ticks for frame processing";
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.ProcessButton);
            this.controlPanel.Controls.Add(this.PlayButton);
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(876, 827);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(408, 72);
            this.controlPanel.TabIndex = 33;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(22, 16);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(167, 37);
            this.ProcessButton.TabIndex = 26;
            this.ProcessButton.Text = "Обработать";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(197, 16);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(167, 37);
            this.PlayButton.TabIndex = 25;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // loadDataset
            // 
            this.loadDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadDataset.Location = new System.Drawing.Point(204, 16);
            this.loadDataset.Margin = new System.Windows.Forms.Padding(4);
            this.loadDataset.Name = "loadDataset";
            this.loadDataset.Size = new System.Drawing.Size(167, 37);
            this.loadDataset.TabIndex = 28;
            this.loadDataset.Text = "Загрузить";
            this.loadDataset.UseVisualStyleBackColor = true;
            this.loadDataset.Click += new System.EventHandler(this.loadDataset_Click);
            // 
            // saveDataset
            // 
            this.saveDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDataset.Location = new System.Drawing.Point(29, 16);
            this.saveDataset.Margin = new System.Windows.Forms.Padding(4);
            this.saveDataset.Name = "saveDataset";
            this.saveDataset.Size = new System.Drawing.Size(167, 37);
            this.saveDataset.TabIndex = 27;
            this.saveDataset.Text = "Сохранить";
            this.saveDataset.UseVisualStyleBackColor = true;
            this.saveDataset.Click += new System.EventHandler(this.saveDataset_Click);
            // 
            // resolutionsBox
            // 
            this.resolutionsBox.AllowDrop = true;
            this.resolutionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsBox.FormattingEnabled = true;
            this.resolutionsBox.Location = new System.Drawing.Point(19, 769);
            this.resolutionsBox.Margin = new System.Windows.Forms.Padding(4);
            this.resolutionsBox.Name = "resolutionsBox";
            this.resolutionsBox.Size = new System.Drawing.Size(289, 24);
            this.resolutionsBox.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.loadDataset);
            this.panel3.Controls.Add(this.saveDataset);
            this.panel3.Location = new System.Drawing.Point(481, 828);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 72);
            this.panel3.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.netTypeBox);
            this.groupBox2.Controls.Add(this.parallelCheckBox);
            this.groupBox2.Controls.Add(this.netStructureBox);
            this.groupBox2.Controls.Add(this.recreateNetButton);
            this.groupBox2.Controls.Add(this.testNetButton);
            this.groupBox2.Controls.Add(this.netTrainButton);
            this.groupBox2.Controls.Add(this.AccuracyCounter);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.EpochesCounter);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Location = new System.Drawing.Point(1298, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(392, 368);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры сети";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Сеть";
            // 
            // netTypeBox
            // 
            this.netTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.netTypeBox.FormattingEnabled = true;
            this.netTypeBox.Location = new System.Drawing.Point(221, 23);
            this.netTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.netTypeBox.Name = "netTypeBox";
            this.netTypeBox.Size = new System.Drawing.Size(160, 24);
            this.netTypeBox.TabIndex = 20;
            // 
            // parallelCheckBox
            // 
            this.parallelCheckBox.AutoSize = true;
            this.parallelCheckBox.Checked = true;
            this.parallelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parallelCheckBox.Location = new System.Drawing.Point(45, 299);
            this.parallelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.parallelCheckBox.Name = "parallelCheckBox";
            this.parallelCheckBox.Size = new System.Drawing.Size(179, 21);
            this.parallelCheckBox.TabIndex = 19;
            this.parallelCheckBox.Text = "Параллельный расчёт";
            this.parallelCheckBox.UseVisualStyleBackColor = true;
            // 
            // netStructureBox
            // 
            this.netStructureBox.Location = new System.Drawing.Point(222, 54);
            this.netStructureBox.Margin = new System.Windows.Forms.Padding(4);
            this.netStructureBox.Name = "netStructureBox";
            this.netStructureBox.Size = new System.Drawing.Size(159, 22);
            this.netStructureBox.TabIndex = 18;
            this.netStructureBox.Text = "200;500;20;7";
            // 
            // recreateNetButton
            // 
            this.recreateNetButton.Location = new System.Drawing.Point(103, 198);
            this.recreateNetButton.Margin = new System.Windows.Forms.Padding(4);
            this.recreateNetButton.Name = "recreateNetButton";
            this.recreateNetButton.Size = new System.Drawing.Size(187, 37);
            this.recreateNetButton.TabIndex = 17;
            this.recreateNetButton.Text = "Пересоздать сеть";
            this.recreateNetButton.UseVisualStyleBackColor = true;
            this.recreateNetButton.Click += new System.EventHandler(this.recreateNetButton_Click);
            // 
            // testNetButton
            // 
            this.testNetButton.Location = new System.Drawing.Point(217, 322);
            this.testNetButton.Margin = new System.Windows.Forms.Padding(4);
            this.testNetButton.Name = "testNetButton";
            this.testNetButton.Size = new System.Drawing.Size(133, 37);
            this.testNetButton.TabIndex = 14;
            this.testNetButton.Text = "Тест";
            this.testNetButton.UseVisualStyleBackColor = true;
            this.testNetButton.Click += new System.EventHandler(this.testNetButton_Click);
            // 
            // netTrainButton
            // 
            this.netTrainButton.Location = new System.Drawing.Point(41, 322);
            this.netTrainButton.Margin = new System.Windows.Forms.Padding(4);
            this.netTrainButton.Name = "netTrainButton";
            this.netTrainButton.Size = new System.Drawing.Size(133, 37);
            this.netTrainButton.TabIndex = 11;
            this.netTrainButton.Text = "Обучить";
            this.netTrainButton.UseVisualStyleBackColor = true;
            this.netTrainButton.Click += new System.EventHandler(this.netTrainButton_Click);
            // 
            // AccuracyCounter
            // 
            this.AccuracyCounter.Location = new System.Drawing.Point(34, 258);
            this.AccuracyCounter.Margin = new System.Windows.Forms.Padding(4);
            this.AccuracyCounter.Maximum = 100;
            this.AccuracyCounter.Name = "AccuracyCounter";
            this.AccuracyCounter.Size = new System.Drawing.Size(327, 56);
            this.AccuracyCounter.TabIndex = 10;
            this.AccuracyCounter.TickFrequency = 10;
            this.AccuracyCounter.Value = 80;
            // 
            // EpochesCounter
            // 
            this.EpochesCounter.Location = new System.Drawing.Point(222, 91);
            this.EpochesCounter.Margin = new System.Windows.Forms.Padding(4);
            this.EpochesCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EpochesCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EpochesCounter.Name = "EpochesCounter";
            this.EpochesCounter.Size = new System.Drawing.Size(160, 22);
            this.EpochesCounter.TabIndex = 8;
            this.EpochesCounter.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nnStatus
            // 
            this.nnStatus.AutoSize = true;
            this.nnStatus.Location = new System.Drawing.Point(1397, 469);
            this.nnStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nnStatus.Name = "nnStatus";
            this.nnStatus.Size = new System.Drawing.Size(48, 17);
            this.nnStatus.TabIndex = 39;
            this.nnStatus.Text = "NONE";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1303, 570);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 27);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1309, 500);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 68);
            this.label13.TabIndex = 36;
            this.label13.Text = "0:\r\n1:\r\n2:\r\n3:";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(1300, 609);
            this.elapsedTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(54, 17);
            this.elapsedTimeLabel.TabIndex = 22;
            this.elapsedTimeLabel.Text = "Время:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1303, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Состояние сети";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1470, 648);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "label14";
            // 
            // startBot
            // 
            this.startBot.Location = new System.Drawing.Point(1298, 683);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(147, 41);
            this.startBot.TabIndex = 42;
            this.startBot.Text = "Включить бота";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.startBot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 939);
            this.Controls.Add(this.startBot);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.nnStatus);
            this.Controls.Add(label12);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.resolutionsBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.ticksLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVideoSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Распознавалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processedImgBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderTrackBar)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVideoSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar marginTrackBar;
        private System.Windows.Forms.TrackBar borderTrackBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ticksLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tresholdTrackBar;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox processedImgBox;
        private System.Windows.Forms.ComboBox resolutionsBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox letterIndex;
        private System.Windows.Forms.Button loadDataset;
        private System.Windows.Forms.Button saveDataset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox netTypeBox;
        private System.Windows.Forms.CheckBox parallelCheckBox;
        private System.Windows.Forms.TextBox netStructureBox;
        private System.Windows.Forms.Button recreateNetButton;
        private System.Windows.Forms.Button testNetButton;
        private System.Windows.Forms.Button netTrainButton;
        private System.Windows.Forms.TrackBar AccuracyCounter;
        private System.Windows.Forms.NumericUpDown EpochesCounter;
        private System.Windows.Forms.Label nnStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button startBot;
    }
}

