namespace KasaYazılım
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBoxMusicMode = new System.Windows.Forms.CheckBox();
            this.buttonSendMusic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.casePanelPowerOff = new System.Windows.Forms.Button();
            this.stopAnimationCasePanel = new System.Windows.Forms.Button();
            this.buttonmod2 = new System.Windows.Forms.Button();
            this.labelm2 = new System.Windows.Forms.Label();
            this.labely2 = new System.Windows.Forms.Label();
            this.labelk2 = new System.Windows.Forms.Label();
            this.casePanelBlueBrightness = new System.Windows.Forms.HScrollBar();
            this.casePanelGreenBrightness = new System.Windows.Forms.HScrollBar();
            this.casePanelRedBrightness = new System.Windows.Forms.HScrollBar();
            this.comboBoxmod2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.casePanelPowerOn = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frontPanelPowerOff = new System.Windows.Forms.Button();
            this.stopAnimationFrontPanel = new System.Windows.Forms.Button();
            this.buttonmod1 = new System.Windows.Forms.Button();
            this.labelm1 = new System.Windows.Forms.Label();
            this.labely1 = new System.Windows.Forms.Label();
            this.labelk1 = new System.Windows.Forms.Label();
            this.comboBoxmod1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.frontPanelBlueBrightness = new System.Windows.Forms.HScrollBar();
            this.frontPanelGreenBrightness = new System.Windows.Forms.HScrollBar();
            this.frontPanelRedBrightness = new System.Windows.Forms.HScrollBar();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frontPanelPowerOn = new System.Windows.Forms.Button();
            this.buttonFans = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bağlantı Noktası";
            // 
            // checkBoxMusicMode
            // 
            this.checkBoxMusicMode.AutoSize = true;
            this.checkBoxMusicMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMusicMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxMusicMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxMusicMode.Location = new System.Drawing.Point(12, 98);
            this.checkBoxMusicMode.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMusicMode.Name = "checkBoxMusicMode";
            this.checkBoxMusicMode.Size = new System.Drawing.Size(131, 24);
            this.checkBoxMusicMode.TabIndex = 39;
            this.checkBoxMusicMode.Text = "Müzik Modu";
            this.checkBoxMusicMode.UseVisualStyleBackColor = false;
            // 
            // buttonSendMusic
            // 
            this.buttonSendMusic.Location = new System.Drawing.Point(8, 128);
            this.buttonSendMusic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendMusic.Name = "buttonSendMusic";
            this.buttonSendMusic.Size = new System.Drawing.Size(100, 28);
            this.buttonSendMusic.TabIndex = 40;
            this.buttonSendMusic.Text = "AÇ/KAPA";
            this.buttonSendMusic.UseVisualStyleBackColor = true;
            this.buttonSendMusic.Click += new System.EventHandler(this.buttonSendMusic_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.casePanelPowerOff);
            this.panel2.Controls.Add(this.stopAnimationCasePanel);
            this.panel2.Controls.Add(this.buttonmod2);
            this.panel2.Controls.Add(this.labelm2);
            this.panel2.Controls.Add(this.labely2);
            this.panel2.Controls.Add(this.labelk2);
            this.panel2.Controls.Add(this.casePanelBlueBrightness);
            this.panel2.Controls.Add(this.casePanelGreenBrightness);
            this.panel2.Controls.Add(this.casePanelRedBrightness);
            this.panel2.Controls.Add(this.comboBoxmod2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.casePanelPowerOn);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(464, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 526);
            this.panel2.TabIndex = 65;
            // 
            // casePanelPowerOff
            // 
            this.casePanelPowerOff.BackColor = System.Drawing.Color.Green;
            this.casePanelPowerOff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.casePanelPowerOff.ForeColor = System.Drawing.Color.White;
            this.casePanelPowerOff.Location = new System.Drawing.Point(199, 324);
            this.casePanelPowerOff.Margin = new System.Windows.Forms.Padding(4);
            this.casePanelPowerOff.Name = "casePanelPowerOff";
            this.casePanelPowerOff.Size = new System.Drawing.Size(191, 28);
            this.casePanelPowerOff.TabIndex = 61;
            this.casePanelPowerOff.Text = "GÜCÜ KES";
            this.casePanelPowerOff.UseVisualStyleBackColor = false;
            this.casePanelPowerOff.Click += new System.EventHandler(this.casePanelPowerOff_Click);
            // 
            // stopAnimationCasePanel
            // 
            this.stopAnimationCasePanel.Location = new System.Drawing.Point(17, 470);
            this.stopAnimationCasePanel.Margin = new System.Windows.Forms.Padding(4);
            this.stopAnimationCasePanel.Name = "stopAnimationCasePanel";
            this.stopAnimationCasePanel.Size = new System.Drawing.Size(331, 28);
            this.stopAnimationCasePanel.TabIndex = 79;
            this.stopAnimationCasePanel.Text = "ANİMASYONU DURDUR";
            this.stopAnimationCasePanel.UseVisualStyleBackColor = true;
            this.stopAnimationCasePanel.Click += new System.EventHandler(this.stop_Click);
            // 
            // buttonmod2
            // 
            this.buttonmod2.BackColor = System.Drawing.Color.Red;
            this.buttonmod2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonmod2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonmod2.Location = new System.Drawing.Point(199, 407);
            this.buttonmod2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonmod2.Name = "buttonmod2";
            this.buttonmod2.Size = new System.Drawing.Size(149, 38);
            this.buttonmod2.TabIndex = 78;
            this.buttonmod2.Text = "Mod Gönder";
            this.buttonmod2.UseVisualStyleBackColor = false;
            this.buttonmod2.Click += new System.EventHandler(this.buttonmod2_Click);
            // 
            // labelm2
            // 
            this.labelm2.AutoSize = true;
            this.labelm2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelm2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelm2.Location = new System.Drawing.Point(257, 226);
            this.labelm2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelm2.Name = "labelm2";
            this.labelm2.Size = new System.Drawing.Size(40, 24);
            this.labelm2.TabIndex = 77;
            this.labelm2.Text = "255";
            this.labelm2.Visible = false;
            // 
            // labely2
            // 
            this.labely2.AutoSize = true;
            this.labely2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labely2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labely2.Location = new System.Drawing.Point(257, 128);
            this.labely2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labely2.Name = "labely2";
            this.labely2.Size = new System.Drawing.Size(40, 24);
            this.labely2.TabIndex = 76;
            this.labely2.Text = "255";
            this.labely2.Visible = false;
            // 
            // labelk2
            // 
            this.labelk2.AutoSize = true;
            this.labelk2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelk2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelk2.Location = new System.Drawing.Point(257, 36);
            this.labelk2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelk2.Name = "labelk2";
            this.labelk2.Size = new System.Drawing.Size(40, 24);
            this.labelk2.TabIndex = 75;
            this.labelk2.Text = "255";
            this.labelk2.Visible = false;
            // 
            // casePanelBlueBrightness
            // 
            this.casePanelBlueBrightness.LargeChange = 1;
            this.casePanelBlueBrightness.Location = new System.Drawing.Point(149, 265);
            this.casePanelBlueBrightness.Maximum = 255;
            this.casePanelBlueBrightness.Name = "casePanelBlueBrightness";
            this.casePanelBlueBrightness.Size = new System.Drawing.Size(240, 17);
            this.casePanelBlueBrightness.TabIndex = 74;
            this.casePanelBlueBrightness.Value = 255;
            this.casePanelBlueBrightness.Visible = false;
            this.casePanelBlueBrightness.ValueChanged += new System.EventHandler(this.casePanelBlueBrightness_ValueChanged);
            // 
            // casePanelGreenBrightness
            // 
            this.casePanelGreenBrightness.LargeChange = 1;
            this.casePanelGreenBrightness.Location = new System.Drawing.Point(149, 167);
            this.casePanelGreenBrightness.Maximum = 255;
            this.casePanelGreenBrightness.Name = "casePanelGreenBrightness";
            this.casePanelGreenBrightness.Size = new System.Drawing.Size(240, 17);
            this.casePanelGreenBrightness.TabIndex = 73;
            this.casePanelGreenBrightness.Value = 255;
            this.casePanelGreenBrightness.Visible = false;
            this.casePanelGreenBrightness.ValueChanged += new System.EventHandler(this.casePanelGreenBrightness_ValueChanged);
            // 
            // casePanelRedBrightness
            // 
            this.casePanelRedBrightness.LargeChange = 1;
            this.casePanelRedBrightness.Location = new System.Drawing.Point(149, 76);
            this.casePanelRedBrightness.Maximum = 255;
            this.casePanelRedBrightness.Name = "casePanelRedBrightness";
            this.casePanelRedBrightness.Size = new System.Drawing.Size(240, 17);
            this.casePanelRedBrightness.TabIndex = 72;
            this.casePanelRedBrightness.Value = 255;
            this.casePanelRedBrightness.Visible = false;
            this.casePanelRedBrightness.ValueChanged += new System.EventHandler(this.casePanelRedBrightness_ValueChanged);
            // 
            // comboBoxmod2
            // 
            this.comboBoxmod2.FormattingEnabled = true;
            this.comboBoxmod2.Items.AddRange(new object[] {
            "-",
            "Yok Olma -Yavaş",
            "Yok Olma -Orta",
            "Yok Olma -Hızlı",
            "Disko - Yavaş",
            "Disko - Orta",
            "Disko - Hızlı",
            "Polis Sireni"});
            this.comboBoxmod2.Location = new System.Drawing.Point(17, 416);
            this.comboBoxmod2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxmod2.Name = "comboBoxmod2";
            this.comboBoxmod2.Size = new System.Drawing.Size(172, 24);
            this.comboBoxmod2.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "MODLAR";
            // 
            // casePanelPowerOn
            // 
            this.casePanelPowerOn.BackColor = System.Drawing.Color.Red;
            this.casePanelPowerOn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.casePanelPowerOn.ForeColor = System.Drawing.Color.White;
            this.casePanelPowerOn.Location = new System.Drawing.Point(4, 324);
            this.casePanelPowerOn.Margin = new System.Windows.Forms.Padding(4);
            this.casePanelPowerOn.Name = "casePanelPowerOn";
            this.casePanelPowerOn.Size = new System.Drawing.Size(191, 28);
            this.casePanelPowerOn.TabIndex = 69;
            this.casePanelPowerOn.Text = "GÜÇ VER";
            this.casePanelPowerOn.UseVisualStyleBackColor = false;
            this.casePanelPowerOn.Click += new System.EventHandler(this.casePanelPower_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.ForeColor = System.Drawing.Color.Red;
            this.checkBox4.Location = new System.Drawing.Point(19, 75);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(103, 27);
            this.checkBox4.TabIndex = 68;
            this.checkBox4.Text = "KIRMIZI";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5.ForeColor = System.Drawing.Color.Lime;
            this.checkBox5.Location = new System.Drawing.Point(17, 169);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(79, 27);
            this.checkBox5.TabIndex = 67;
            this.checkBox5.Text = "YEŞİL";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox6.ForeColor = System.Drawing.Color.Cyan;
            this.checkBox6.Location = new System.Drawing.Point(17, 267);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(79, 27);
            this.checkBox6.TabIndex = 66;
            this.checkBox6.Text = "MAVİ";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(63, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "KASA İÇİ LEDLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.frontPanelPowerOff);
            this.panel1.Controls.Add(this.stopAnimationFrontPanel);
            this.panel1.Controls.Add(this.buttonmod1);
            this.panel1.Controls.Add(this.labelm1);
            this.panel1.Controls.Add(this.labely1);
            this.panel1.Controls.Add(this.labelk1);
            this.panel1.Controls.Add(this.comboBoxmod1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.frontPanelBlueBrightness);
            this.panel1.Controls.Add(this.frontPanelGreenBrightness);
            this.panel1.Controls.Add(this.frontPanelRedBrightness);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.frontPanelPowerOn);
            this.panel1.Location = new System.Drawing.Point(31, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 526);
            this.panel1.TabIndex = 43;
            // 
            // frontPanelPowerOff
            // 
            this.frontPanelPowerOff.BackColor = System.Drawing.Color.Green;
            this.frontPanelPowerOff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frontPanelPowerOff.ForeColor = System.Drawing.Color.White;
            this.frontPanelPowerOff.Location = new System.Drawing.Point(199, 324);
            this.frontPanelPowerOff.Margin = new System.Windows.Forms.Padding(4);
            this.frontPanelPowerOff.Name = "frontPanelPowerOff";
            this.frontPanelPowerOff.Size = new System.Drawing.Size(191, 28);
            this.frontPanelPowerOff.TabIndex = 60;
            this.frontPanelPowerOff.Text = "GÜCÜ KES";
            this.frontPanelPowerOff.UseVisualStyleBackColor = false;
            this.frontPanelPowerOff.Click += new System.EventHandler(this.frontPanelPowerOff_Click);
            // 
            // stopAnimationFrontPanel
            // 
            this.stopAnimationFrontPanel.Location = new System.Drawing.Point(9, 468);
            this.stopAnimationFrontPanel.Margin = new System.Windows.Forms.Padding(4);
            this.stopAnimationFrontPanel.Name = "stopAnimationFrontPanel";
            this.stopAnimationFrontPanel.Size = new System.Drawing.Size(331, 28);
            this.stopAnimationFrontPanel.TabIndex = 59;
            this.stopAnimationFrontPanel.Text = "ANİMASYONU DURDUR";
            this.stopAnimationFrontPanel.UseVisualStyleBackColor = true;
            this.stopAnimationFrontPanel.Click += new System.EventHandler(this.stopAnimation_Click);
            // 
            // buttonmod1
            // 
            this.buttonmod1.BackColor = System.Drawing.Color.Red;
            this.buttonmod1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonmod1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonmod1.Location = new System.Drawing.Point(191, 410);
            this.buttonmod1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonmod1.Name = "buttonmod1";
            this.buttonmod1.Size = new System.Drawing.Size(149, 36);
            this.buttonmod1.TabIndex = 58;
            this.buttonmod1.Text = "Mod Gönder";
            this.buttonmod1.UseVisualStyleBackColor = false;
            this.buttonmod1.Click += new System.EventHandler(this.buttonmod1_Click);
            // 
            // labelm1
            // 
            this.labelm1.AutoSize = true;
            this.labelm1.BackColor = System.Drawing.Color.Transparent;
            this.labelm1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelm1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelm1.Location = new System.Drawing.Point(261, 226);
            this.labelm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelm1.Name = "labelm1";
            this.labelm1.Size = new System.Drawing.Size(40, 24);
            this.labelm1.TabIndex = 57;
            this.labelm1.Text = "255";
            this.labelm1.Visible = false;
            // 
            // labely1
            // 
            this.labely1.AutoSize = true;
            this.labely1.BackColor = System.Drawing.Color.Transparent;
            this.labely1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labely1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labely1.Location = new System.Drawing.Point(261, 128);
            this.labely1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labely1.Name = "labely1";
            this.labely1.Size = new System.Drawing.Size(40, 24);
            this.labely1.TabIndex = 56;
            this.labely1.Text = "255";
            this.labely1.Visible = false;
            // 
            // labelk1
            // 
            this.labelk1.AutoSize = true;
            this.labelk1.BackColor = System.Drawing.Color.Transparent;
            this.labelk1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelk1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelk1.Location = new System.Drawing.Point(261, 36);
            this.labelk1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelk1.Name = "labelk1";
            this.labelk1.Size = new System.Drawing.Size(40, 24);
            this.labelk1.TabIndex = 55;
            this.labelk1.Text = "255";
            this.labelk1.Visible = false;
            // 
            // comboBoxmod1
            // 
            this.comboBoxmod1.FormattingEnabled = true;
            this.comboBoxmod1.Items.AddRange(new object[] {
            "-",
            "Yok Olma -Yavaş",
            "Yok Olma -Orta",
            "Yok Olma -Hızlı",
            "Disko - Yavaş",
            "Disko - Orta",
            "Disko - Hızlı",
            "Polis Sireni"});
            this.comboBoxmod1.Location = new System.Drawing.Point(9, 416);
            this.comboBoxmod1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxmod1.Name = "comboBoxmod1";
            this.comboBoxmod1.Size = new System.Drawing.Size(172, 24);
            this.comboBoxmod1.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(5, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "MODLAR";
            // 
            // frontPanelBlueBrightness
            // 
            this.frontPanelBlueBrightness.LargeChange = 1;
            this.frontPanelBlueBrightness.Location = new System.Drawing.Point(147, 266);
            this.frontPanelBlueBrightness.Maximum = 255;
            this.frontPanelBlueBrightness.Name = "frontPanelBlueBrightness";
            this.frontPanelBlueBrightness.Size = new System.Drawing.Size(240, 17);
            this.frontPanelBlueBrightness.TabIndex = 52;
            this.frontPanelBlueBrightness.Value = 255;
            this.frontPanelBlueBrightness.Visible = false;
            this.frontPanelBlueBrightness.ValueChanged += new System.EventHandler(this.frontPanelBlueBrightness_ValueChanged);
            // 
            // frontPanelGreenBrightness
            // 
            this.frontPanelGreenBrightness.LargeChange = 1;
            this.frontPanelGreenBrightness.Location = new System.Drawing.Point(147, 169);
            this.frontPanelGreenBrightness.Maximum = 255;
            this.frontPanelGreenBrightness.Name = "frontPanelGreenBrightness";
            this.frontPanelGreenBrightness.Size = new System.Drawing.Size(240, 17);
            this.frontPanelGreenBrightness.TabIndex = 51;
            this.frontPanelGreenBrightness.Value = 255;
            this.frontPanelGreenBrightness.Visible = false;
            this.frontPanelGreenBrightness.ValueChanged += new System.EventHandler(this.frontPanelGreenBrightness_ValueChanged);
            // 
            // frontPanelRedBrightness
            // 
            this.frontPanelRedBrightness.LargeChange = 1;
            this.frontPanelRedBrightness.Location = new System.Drawing.Point(147, 76);
            this.frontPanelRedBrightness.Maximum = 255;
            this.frontPanelRedBrightness.Name = "frontPanelRedBrightness";
            this.frontPanelRedBrightness.Size = new System.Drawing.Size(240, 17);
            this.frontPanelRedBrightness.TabIndex = 50;
            this.frontPanelRedBrightness.Value = 255;
            this.frontPanelRedBrightness.Visible = false;
            this.frontPanelRedBrightness.ValueChanged += new System.EventHandler(this.frontPanelRedBrightness_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.ForeColor = System.Drawing.Color.Cyan;
            this.checkBox3.Location = new System.Drawing.Point(9, 265);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 27);
            this.checkBox3.TabIndex = 46;
            this.checkBox3.Text = "MAVİ";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.ForeColor = System.Drawing.Color.Lime;
            this.checkBox2.Location = new System.Drawing.Point(9, 167);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 27);
            this.checkBox2.TabIndex = 45;
            this.checkBox2.Text = "YEŞİL";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(9, 75);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 27);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "KIRMIZI";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "ÖN PANEL LEDLER";
            // 
            // frontPanelPowerOn
            // 
            this.frontPanelPowerOn.BackColor = System.Drawing.Color.Red;
            this.frontPanelPowerOn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frontPanelPowerOn.ForeColor = System.Drawing.Color.White;
            this.frontPanelPowerOn.Location = new System.Drawing.Point(4, 324);
            this.frontPanelPowerOn.Margin = new System.Windows.Forms.Padding(4);
            this.frontPanelPowerOn.Name = "frontPanelPowerOn";
            this.frontPanelPowerOn.Size = new System.Drawing.Size(191, 28);
            this.frontPanelPowerOn.TabIndex = 42;
            this.frontPanelPowerOn.Text = "GÜÇ VER";
            this.frontPanelPowerOn.UseVisualStyleBackColor = false;
            this.frontPanelPowerOn.Click += new System.EventHandler(this.frontPanelPower_Click);
            // 
            // buttonFans
            // 
            this.buttonFans.Location = new System.Drawing.Point(8, 228);
            this.buttonFans.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFans.Name = "buttonFans";
            this.buttonFans.Size = new System.Drawing.Size(100, 28);
            this.buttonFans.TabIndex = 66;
            this.buttonFans.Text = "AÇ/KAPA";
            this.buttonFans.UseVisualStyleBackColor = true;
            this.buttonFans.Click += new System.EventHandler(this.buttonPowerFans_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(8, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Fanlar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::KasaYazılım.Properties.Resources.arka1;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonFans);
            this.panel3.Controls.Add(this.checkBoxMusicMode);
            this.panel3.Controls.Add(this.buttonSendMusic);
            this.panel3.Location = new System.Drawing.Point(868, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 323);
            this.panel3.TabIndex = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::KasaYazılım.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1053, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBoxMusicMode;
        private System.Windows.Forms.Button buttonSendMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopAnimationFrontPanel;
        private System.Windows.Forms.Button buttonmod1;
        private System.Windows.Forms.Label labelm1;
        private System.Windows.Forms.Label labely1;
        private System.Windows.Forms.Label labelk1;
        private System.Windows.Forms.ComboBox comboBoxmod1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar frontPanelBlueBrightness;
        private System.Windows.Forms.HScrollBar frontPanelGreenBrightness;
        private System.Windows.Forms.HScrollBar frontPanelRedBrightness;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button frontPanelPowerOn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button stopAnimationCasePanel;
        private System.Windows.Forms.Button buttonmod2;
        private System.Windows.Forms.Label labelm2;
        private System.Windows.Forms.Label labely2;
        private System.Windows.Forms.Label labelk2;
        private System.Windows.Forms.HScrollBar casePanelBlueBrightness;
        private System.Windows.Forms.HScrollBar casePanelGreenBrightness;
        private System.Windows.Forms.HScrollBar casePanelRedBrightness;
        private System.Windows.Forms.ComboBox comboBoxmod2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button casePanelPowerOn;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button frontPanelPowerOff;
        private System.Windows.Forms.Button casePanelPowerOff;
        private System.Windows.Forms.Button buttonFans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}

