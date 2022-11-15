namespace titresim
{
    partial class ModSelector
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.motor4 = new System.Windows.Forms.CheckBox();
            this.motor3 = new System.Windows.Forms.CheckBox();
            this.motor2 = new System.Windows.Forms.CheckBox();
            this.motor1 = new System.Windows.Forms.CheckBox();
            this.modSil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 154);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod Listesi";
            // 
            // modEkle
            // 
            this.modEkle.BackColor = System.Drawing.Color.Aquamarine;
            this.modEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modEkle.Image = global::titresim.Properties.Resources.add;
            this.modEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modEkle.Location = new System.Drawing.Point(235, 254);
            this.modEkle.Name = "modEkle";
            this.modEkle.Size = new System.Drawing.Size(225, 45);
            this.modEkle.TabIndex = 2;
            this.modEkle.Text = "Yeni Mod Ekle";
            this.modEkle.UseVisualStyleBackColor = false;
            this.modEkle.Click += new System.EventHandler(this.modEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Çalıştır:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Bekle:";
            // 
            // comboBox9
            // 
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(407, 154);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(53, 33);
            this.comboBox9.TabIndex = 27;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(407, 115);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(53, 33);
            this.comboBox8.TabIndex = 25;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(348, 154);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(53, 33);
            this.comboBox5.TabIndex = 28;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(407, 76);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(53, 33);
            this.comboBox7.TabIndex = 23;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(348, 115);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(53, 33);
            this.comboBox4.TabIndex = 26;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(407, 37);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(53, 33);
            this.comboBox6.TabIndex = 21;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(348, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 33);
            this.comboBox3.TabIndex = 24;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(53, 33);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.Maroon;
            this.stop.Image = global::titresim.Properties.Resources.stop;
            this.stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stop.Location = new System.Drawing.Point(356, 203);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(104, 45);
            this.stop.TabIndex = 20;
            this.stop.Text = "                Durdur";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SkyBlue;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.Navy;
            this.start.Image = global::titresim.Properties.Resources.run;
            this.start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start.Location = new System.Drawing.Point(235, 203);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 45);
            this.start.TabIndex = 19;
            this.start.Text = "                Çalıştır";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // motor4
            // 
            this.motor4.AutoSize = true;
            this.motor4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.motor4.Location = new System.Drawing.Point(238, 156);
            this.motor4.Name = "motor4";
            this.motor4.Size = new System.Drawing.Size(101, 29);
            this.motor4.TabIndex = 18;
            this.motor4.Text = "Motor 4";
            this.motor4.UseVisualStyleBackColor = true;
            this.motor4.CheckedChanged += new System.EventHandler(this.motor4_CheckedChanged);
            // 
            // motor3
            // 
            this.motor3.AutoSize = true;
            this.motor3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.motor3.Location = new System.Drawing.Point(238, 117);
            this.motor3.Name = "motor3";
            this.motor3.Size = new System.Drawing.Size(101, 29);
            this.motor3.TabIndex = 17;
            this.motor3.Text = "Motor 3";
            this.motor3.UseVisualStyleBackColor = true;
            this.motor3.CheckedChanged += new System.EventHandler(this.motor3_CheckedChanged);
            // 
            // motor2
            // 
            this.motor2.AutoSize = true;
            this.motor2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.motor2.Location = new System.Drawing.Point(238, 78);
            this.motor2.Name = "motor2";
            this.motor2.Size = new System.Drawing.Size(101, 29);
            this.motor2.TabIndex = 16;
            this.motor2.Text = "Motor 2";
            this.motor2.UseVisualStyleBackColor = true;
            this.motor2.CheckedChanged += new System.EventHandler(this.motor2_CheckedChanged);
            // 
            // motor1
            // 
            this.motor1.AutoSize = true;
            this.motor1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.motor1.Location = new System.Drawing.Point(238, 39);
            this.motor1.Name = "motor1";
            this.motor1.Size = new System.Drawing.Size(98, 29);
            this.motor1.TabIndex = 15;
            this.motor1.Text = "Motor 1";
            this.motor1.UseVisualStyleBackColor = true;
            this.motor1.CheckedChanged += new System.EventHandler(this.motor1_CheckedChanged);
            // 
            // modSil
            // 
            this.modSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.modSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modSil.ForeColor = System.Drawing.Color.Maroon;
            this.modSil.Image = global::titresim.Properties.Resources.del;
            this.modSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modSil.Location = new System.Drawing.Point(12, 203);
            this.modSil.Name = "modSil";
            this.modSil.Size = new System.Drawing.Size(186, 45);
            this.modSil.TabIndex = 31;
            this.modSil.Text = "Modu Sil";
            this.modSil.UseVisualStyleBackColor = false;
            this.modSil.Click += new System.EventHandler(this.modSil_Click);
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.White;
            this.kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydet.Image = global::titresim.Properties.Resources.Save;
            this.kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet.Location = new System.Drawing.Point(12, 254);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(186, 45);
            this.kaydet.TabIndex = 31;
            this.kaydet.Text = "                 Değişiklikleri Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // ModSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 313);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.modSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.motor4);
            this.Controls.Add(this.motor3);
            this.Controls.Add(this.motor2);
            this.Controls.Add(this.motor1);
            this.Controls.Add(this.modEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 352);
            this.Name = "ModSelector";
            this.Text = "ModSelector";
            this.Load += new System.EventHandler(this.ModSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button modEkle;
        private Label label2;
        private Label label3;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private ComboBox comboBox5;
        private ComboBox comboBox7;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Button stop;
        private Button start;
        private CheckBox motor4;
        private CheckBox motor3;
        private CheckBox motor2;
        private CheckBox motor1;
        private Button modSil;
        private Button kaydet;
    }
}