namespace Dictofon
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.arrow_up = new System.Windows.Forms.Button();
            this.arrow_down = new System.Windows.Forms.Button();
            this.Pause_song = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Now_play = new System.Windows.Forms.Label();
            this.Now_record = new System.Windows.Forms.Label();
            this.nowplaysong = new System.Windows.Forms.TextBox();
            this.nowplay_time = new System.Windows.Forms.TextBox();
            this.now_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DELETE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.mode = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.charge_icon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.charging = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lightn = new System.Windows.Forms.PictureBox();
            this.nowrecordsong = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightn)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightCyan;
            this.Start.CausesValidation = false;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(349, 253);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 49);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.Control;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(271, 246);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(63, 65);
            this.Stop.TabIndex = 1;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // arrow_up
            // 
            this.arrow_up.BackColor = System.Drawing.SystemColors.Control;
            this.arrow_up.FlatAppearance.BorderSize = 0;
            this.arrow_up.Image = ((System.Drawing.Image)(resources.GetObject("arrow_up.Image")));
            this.arrow_up.Location = new System.Drawing.Point(39, 213);
            this.arrow_up.Name = "arrow_up";
            this.arrow_up.Size = new System.Drawing.Size(70, 66);
            this.arrow_up.TabIndex = 2;
            this.arrow_up.UseVisualStyleBackColor = false;
            this.arrow_up.Click += new System.EventHandler(this.arrow_up_Click);
            // 
            // arrow_down
            // 
            this.arrow_down.BackColor = System.Drawing.SystemColors.Control;
            this.arrow_down.FlatAppearance.BorderSize = 0;
            this.arrow_down.Image = ((System.Drawing.Image)(resources.GetObject("arrow_down.Image")));
            this.arrow_down.Location = new System.Drawing.Point(39, 285);
            this.arrow_down.Name = "arrow_down";
            this.arrow_down.Size = new System.Drawing.Size(70, 62);
            this.arrow_down.TabIndex = 3;
            this.arrow_down.UseVisualStyleBackColor = false;
            this.arrow_down.Click += new System.EventHandler(this.arrow_down_Click);
            // 
            // Pause_song
            // 
            this.Pause_song.BackColor = System.Drawing.SystemColors.Control;
            this.Pause_song.FlatAppearance.BorderSize = 0;
            this.Pause_song.Image = ((System.Drawing.Image)(resources.GetObject("Pause_song.Image")));
            this.Pause_song.Location = new System.Drawing.Point(202, 246);
            this.Pause_song.Name = "Pause_song";
            this.Pause_song.Size = new System.Drawing.Size(63, 66);
            this.Pause_song.TabIndex = 5;
            this.Pause_song.UseVisualStyleBackColor = false;
            this.Pause_song.Click += new System.EventHandler(this.Pause_song_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Audio Files on SD-card";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(28, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 108);
            this.listBox1.TabIndex = 8;
            // 
            // Now_play
            // 
            this.Now_play.AutoSize = true;
            this.Now_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Now_play.Location = new System.Drawing.Point(199, 87);
            this.Now_play.Name = "Now_play";
            this.Now_play.Size = new System.Drawing.Size(87, 18);
            this.Now_play.TabIndex = 9;
            this.Now_play.Text = "Now play :";
            // 
            // Now_record
            // 
            this.Now_record.AutoSize = true;
            this.Now_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Now_record.Location = new System.Drawing.Point(308, 87);
            this.Now_record.Name = "Now_record";
            this.Now_record.Size = new System.Drawing.Size(106, 18);
            this.Now_record.TabIndex = 10;
            this.Now_record.Text = "Now record :";
            // 
            // nowplaysong
            // 
            this.nowplaysong.BackColor = System.Drawing.SystemColors.Control;
            this.nowplaysong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowplaysong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nowplaysong.Location = new System.Drawing.Point(202, 108);
            this.nowplaysong.Name = "nowplaysong";
            this.nowplaysong.ReadOnly = true;
            this.nowplaysong.Size = new System.Drawing.Size(96, 15);
            this.nowplaysong.TabIndex = 11;
            // 
            // nowplay_time
            // 
            this.nowplay_time.BackColor = System.Drawing.SystemColors.Control;
            this.nowplay_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowplay_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nowplay_time.Location = new System.Drawing.Point(448, 108);
            this.nowplay_time.Name = "nowplay_time";
            this.nowplay_time.ReadOnly = true;
            this.nowplay_time.Size = new System.Drawing.Size(47, 15);
            this.nowplay_time.TabIndex = 12;
            // 
            // now_time
            // 
            this.now_time.BackColor = System.Drawing.SystemColors.Control;
            this.now_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.now_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.now_time.Location = new System.Drawing.Point(28, 30);
            this.now_time.Name = "now_time";
            this.now_time.Size = new System.Drawing.Size(200, 15);
            this.now_time.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.Control;
            this.DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Location = new System.Drawing.Point(450, 251);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(52, 56);
            this.DELETE.TabIndex = 16;
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(463, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "75%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Interval = 30000;
            // 
            // mode
            // 
            this.mode.Image = ((System.Drawing.Image)(resources.GetObject("mode.Image")));
            this.mode.Location = new System.Drawing.Point(12, 60);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(503, 147);
            this.mode.TabIndex = 18;
            this.mode.TabStop = false;
            this.mode.Visible = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Control;
            this.Play.CausesValidation = false;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(128, 246);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(68, 66);
            this.Play.TabIndex = 4;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // charge_icon
            // 
            this.charge_icon.Image = ((System.Drawing.Image)(resources.GetObject("charge_icon.Image")));
            this.charge_icon.Location = new System.Drawing.Point(450, 19);
            this.charge_icon.Name = "charge_icon";
            this.charge_icon.Size = new System.Drawing.Size(50, 42);
            this.charge_icon.TabIndex = 19;
            this.charge_icon.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(522, 212);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // charging
            // 
            this.charging.Image = ((System.Drawing.Image)(resources.GetObject("charging.Image")));
            this.charging.Location = new System.Drawing.Point(436, 312);
            this.charging.Name = "charging";
            this.charging.Size = new System.Drawing.Size(69, 56);
            this.charging.TabIndex = 21;
            this.charging.TabStop = false;
            this.charging.Visible = false;
            this.charging.Click += new System.EventHandler(this.charging_Click);
            // 
            // lightn
            // 
            this.lightn.Image = ((System.Drawing.Image)(resources.GetObject("lightn.Image")));
            this.lightn.Location = new System.Drawing.Point(424, 34);
            this.lightn.Name = "lightn";
            this.lightn.Size = new System.Drawing.Size(20, 20);
            this.lightn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lightn.TabIndex = 22;
            this.lightn.TabStop = false;
            this.lightn.Visible = false;
            // 
            // nowrecordsong
            // 
            this.nowrecordsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nowrecordsong.Location = new System.Drawing.Point(308, 108);
            this.nowrecordsong.Name = "nowrecordsong";
            this.nowrecordsong.Size = new System.Drawing.Size(103, 22);
            this.nowrecordsong.TabIndex = 11;
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 381);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.nowrecordsong);
            this.Controls.Add(this.lightn);
            this.Controls.Add(this.charging);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.charge_icon);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.now_time);
            this.Controls.Add(this.nowplay_time);
            this.Controls.Add(this.nowplaysong);
            this.Controls.Add(this.Now_record);
            this.Controls.Add(this.Now_play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pause_song);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.arrow_down);
            this.Controls.Add(this.arrow_up);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictaphone";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button arrow_up;
        private System.Windows.Forms.Button arrow_down;
        private System.Windows.Forms.Button Pause_song;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Now_play;
        private System.Windows.Forms.Label Now_record;
        private System.Windows.Forms.TextBox nowplaysong;
        private System.Windows.Forms.TextBox nowplay_time;
        private System.Windows.Forms.TextBox now_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox charge_icon;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox mode;
        public System.Windows.Forms.PictureBox charging;
        public System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.PictureBox lightn;
        private System.Windows.Forms.Label nowrecordsong;
        private System.Windows.Forms.Timer timer5;
    }
}

