namespace titresim
{
    partial class Vibration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vibration));
            this.motor1 = new System.Windows.Forms.CheckBox();
            this.motor2 = new System.Windows.Forms.CheckBox();
            this.motor3 = new System.Windows.Forms.CheckBox();
            this.motor4 = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.baglatiDurumui = new System.Windows.Forms.Label();
            this.baglan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tara = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motor1
            // 
            this.motor1.AutoSize = true;
            this.motor1.Location = new System.Drawing.Point(29, 129);
            this.motor1.Name = "motor1";
            this.motor1.Size = new System.Drawing.Size(68, 19);
            this.motor1.TabIndex = 0;
            this.motor1.Text = "Motor 1";
            this.motor1.UseVisualStyleBackColor = true;
            this.motor1.CheckedChanged += new System.EventHandler(this.motor1_CheckedChanged);
            // 
            // motor2
            // 
            this.motor2.AutoSize = true;
            this.motor2.Location = new System.Drawing.Point(29, 154);
            this.motor2.Name = "motor2";
            this.motor2.Size = new System.Drawing.Size(68, 19);
            this.motor2.TabIndex = 1;
            this.motor2.Text = "Motor 2";
            this.motor2.UseVisualStyleBackColor = true;
            this.motor2.CheckedChanged += new System.EventHandler(this.motor2_CheckedChanged);
            // 
            // motor3
            // 
            this.motor3.AutoSize = true;
            this.motor3.Location = new System.Drawing.Point(29, 179);
            this.motor3.Name = "motor3";
            this.motor3.Size = new System.Drawing.Size(68, 19);
            this.motor3.TabIndex = 2;
            this.motor3.Text = "Motor 3";
            this.motor3.UseVisualStyleBackColor = true;
            this.motor3.CheckedChanged += new System.EventHandler(this.motor3_CheckedChanged);
            // 
            // motor4
            // 
            this.motor4.AutoSize = true;
            this.motor4.Location = new System.Drawing.Point(29, 204);
            this.motor4.Name = "motor4";
            this.motor4.Size = new System.Drawing.Size(68, 19);
            this.motor4.TabIndex = 3;
            this.motor4.Text = "Motor 4";
            this.motor4.UseVisualStyleBackColor = true;
            this.motor4.CheckedChanged += new System.EventHandler(this.motor4_CheckedChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(22, 239);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(96, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Çalıştır";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(22, 268);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(96, 23);
            this.stop.TabIndex = 5;
            this.stop.Text = "Durdur";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // baglatiDurumui
            // 
            this.baglatiDurumui.AutoSize = true;
            this.baglatiDurumui.Location = new System.Drawing.Point(29, 9);
            this.baglatiDurumui.Name = "baglatiDurumui";
            this.baglatiDurumui.Size = new System.Drawing.Size(97, 15);
            this.baglatiDurumui.TabIndex = 6;
            this.baglatiDurumui.Text = "Bağlantı Durumu";
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(124, 67);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(85, 23);
            this.baglan.TabIndex = 7;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Bağlantı seçiniz...";
            // 
            // tara
            // 
            this.tara.Location = new System.Drawing.Point(29, 67);
            this.tara.Name = "tara";
            this.tara.Size = new System.Drawing.Size(89, 23);
            this.tara.TabIndex = 9;
            this.tara.Text = "Tara";
            this.tara.UseVisualStyleBackColor = true;
            this.tara.Click += new System.EventHandler(this.tara_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(53, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(97, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(97, 177);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(53, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(97, 202);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(53, 23);
            this.comboBox5.TabIndex = 13;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(156, 127);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(53, 23);
            this.comboBox6.TabIndex = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(156, 152);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(53, 23);
            this.comboBox7.TabIndex = 11;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(156, 177);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(53, 23);
            this.comboBox8.TabIndex = 12;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(156, 202);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(53, 23);
            this.comboBox9.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bekle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Çalıştır:";
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.OldLace;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod.Image = global::titresim.Properties.Resources.ic;
            this.mod.Location = new System.Drawing.Point(124, 239);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(85, 52);
            this.mod.TabIndex = 15;
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // Vibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(237, 305);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.baglan);
            this.Controls.Add(this.baglatiDurumui);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.motor4);
            this.Controls.Add(this.motor3);
            this.Controls.Add(this.motor2);
            this.Controls.Add(this.motor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vibration";
            this.Text = "VibrationApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox motor1;
        private CheckBox motor2;
        private CheckBox motor3;
        private CheckBox motor4;
        private Button start;
        private Button stop;
        private Label baglatiDurumui;
        private Button baglan;
        private ComboBox comboBox1;
        private Button tara;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private Label label1;
        private Label label2;
        private Button mod;
    }
}