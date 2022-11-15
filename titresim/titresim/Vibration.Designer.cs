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
            this.baglatiDurumui = new System.Windows.Forms.Label();
            this.baglan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tara = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baglatiDurumui
            // 
            this.baglatiDurumui.AutoSize = true;
            this.baglatiDurumui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baglatiDurumui.Location = new System.Drawing.Point(23, 19);
            this.baglatiDurumui.Name = "baglatiDurumui";
            this.baglatiDurumui.Size = new System.Drawing.Size(129, 20);
            this.baglatiDurumui.TabIndex = 6;
            this.baglatiDurumui.Text = "Bağlantı Durumu";
            // 
            // baglan
            // 
            this.baglan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.baglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baglan.ForeColor = System.Drawing.Color.Navy;
            this.baglan.Image = global::titresim.Properties.Resources.Bluetooth_Logo_Background_PNG_Image;
            this.baglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baglan.Location = new System.Drawing.Point(125, 82);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(85, 50);
            this.baglan.TabIndex = 7;
            this.baglan.Text = "Bağlan";
            this.baglan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baglan.UseVisualStyleBackColor = false;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 29);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Bağlantı seçiniz...";
            // 
            // tara
            // 
            this.tara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tara.ForeColor = System.Drawing.Color.Green;
            this.tara.Image = global::titresim.Properties.Resources.search;
            this.tara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tara.Location = new System.Drawing.Point(24, 82);
            this.tara.Name = "tara";
            this.tara.Size = new System.Drawing.Size(89, 50);
            this.tara.TabIndex = 9;
            this.tara.Text = "Tara";
            this.tara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tara.UseVisualStyleBackColor = false;
            this.tara.Click += new System.EventHandler(this.tara_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.OldLace;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod.Image = global::titresim.Properties.Resources.ic;
            this.mod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mod.Location = new System.Drawing.Point(133, 298);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(76, 96);
            this.mod.TabIndex = 15;
            this.mod.Text = "Mod Editör";
            this.mod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 154);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.Maroon;
            this.stop.Image = global::titresim.Properties.Resources.stop;
            this.stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stop.Location = new System.Drawing.Point(24, 349);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(104, 45);
            this.stop.TabIndex = 22;
            this.stop.Text = "                Durdur";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SkyBlue;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.Navy;
            this.start.Image = global::titresim.Properties.Resources.run;
            this.start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start.Location = new System.Drawing.Point(23, 298);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 45);
            this.start.TabIndex = 21;
            this.start.Text = "                Çalıştır";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // Vibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(237, 413);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.tara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.baglan);
            this.Controls.Add(this.baglatiDurumui);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vibration";
            this.Text = "VibrationApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label baglatiDurumui;
        private Button baglan;
        private ComboBox comboBox1;
        private Button tara;
        private Button mod;
        private ListBox listBox1;
        private Button stop;
        private Button start;
    }
}