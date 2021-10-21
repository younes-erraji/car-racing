namespace Car_Racing
{
    partial class Car_Racing
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
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.label_GameOver = new System.Windows.Forms.Label();
            this.DH2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_CarE2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_CarE3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_CarE1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Car = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DH3 = new System.Windows.Forms.PictureBox();
            this.DH4 = new System.Windows.Forms.PictureBox();
            this.DH5 = new System.Windows.Forms.PictureBox();
            this.DH1 = new System.Windows.Forms.PictureBox();
            this.label_Derhams = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 10;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_GameOver.Location = new System.Drawing.Point(121, 213);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(130, 25);
            this.label_GameOver.TabIndex = 11;
            this.label_GameOver.Text = "Game Over";
            // 
            // DH2
            // 
            this.DH2.Image = global::Car_Racing.Properties.Resources.indexDh;
            this.DH2.Location = new System.Drawing.Point(274, 117);
            this.DH2.Name = "DH2";
            this.DH2.Size = new System.Drawing.Size(25, 25);
            this.DH2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DH2.TabIndex = 12;
            this.DH2.TabStop = false;
            // 
            // pictureBox_CarE2
            // 
            this.pictureBox_CarE2.Image = global::Car_Racing.Properties.Resources.imagesEnemy;
            this.pictureBox_CarE2.Location = new System.Drawing.Point(295, 196);
            this.pictureBox_CarE2.Name = "pictureBox_CarE2";
            this.pictureBox_CarE2.Size = new System.Drawing.Size(49, 70);
            this.pictureBox_CarE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CarE2.TabIndex = 10;
            this.pictureBox_CarE2.TabStop = false;
            // 
            // pictureBox_CarE3
            // 
            this.pictureBox_CarE3.Image = global::Car_Racing.Properties.Resources.imagesEnemy;
            this.pictureBox_CarE3.Location = new System.Drawing.Point(193, 39);
            this.pictureBox_CarE3.Name = "pictureBox_CarE3";
            this.pictureBox_CarE3.Size = new System.Drawing.Size(49, 70);
            this.pictureBox_CarE3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CarE3.TabIndex = 9;
            this.pictureBox_CarE3.TabStop = false;
            // 
            // pictureBox_CarE1
            // 
            this.pictureBox_CarE1.Image = global::Car_Racing.Properties.Resources.imagesEnemy;
            this.pictureBox_CarE1.Location = new System.Drawing.Point(28, 364);
            this.pictureBox_CarE1.Name = "pictureBox_CarE1";
            this.pictureBox_CarE1.Size = new System.Drawing.Size(49, 70);
            this.pictureBox_CarE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CarE1.TabIndex = 8;
            this.pictureBox_CarE1.TabStop = false;
            // 
            // pictureBox_Car
            // 
            this.pictureBox_Car.Image = global::Car_Racing.Properties.Resources.images;
            this.pictureBox_Car.Location = new System.Drawing.Point(101, 319);
            this.pictureBox_Car.Name = "pictureBox_Car";
            this.pictureBox_Car.Size = new System.Drawing.Size(49, 70);
            this.pictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Car.TabIndex = 7;
            this.pictureBox_Car.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(375, -14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 481);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 472);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(177, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 94);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(177, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 94);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(177, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 94);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(177, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DH3
            // 
            this.DH3.Image = global::Car_Racing.Properties.Resources.indexDh;
            this.DH3.Location = new System.Drawing.Point(214, 163);
            this.DH3.Name = "DH3";
            this.DH3.Size = new System.Drawing.Size(25, 25);
            this.DH3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DH3.TabIndex = 13;
            this.DH3.TabStop = false;
            // 
            // DH4
            // 
            this.DH4.Image = global::Car_Racing.Properties.Resources.indexDh;
            this.DH4.Location = new System.Drawing.Point(28, 285);
            this.DH4.Name = "DH4";
            this.DH4.Size = new System.Drawing.Size(25, 25);
            this.DH4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DH4.TabIndex = 14;
            this.DH4.TabStop = false;
            // 
            // DH5
            // 
            this.DH5.Image = global::Car_Racing.Properties.Resources.indexDh;
            this.DH5.Location = new System.Drawing.Point(274, 328);
            this.DH5.Name = "DH5";
            this.DH5.Size = new System.Drawing.Size(25, 25);
            this.DH5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DH5.TabIndex = 15;
            this.DH5.TabStop = false;
            // 
            // DH1
            // 
            this.DH1.Image = global::Car_Racing.Properties.Resources.indexDh;
            this.DH1.Location = new System.Drawing.Point(88, 12);
            this.DH1.Name = "DH1";
            this.DH1.Size = new System.Drawing.Size(25, 25);
            this.DH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DH1.TabIndex = 16;
            this.DH1.TabStop = false;
            // 
            // label_Derhams
            // 
            this.label_Derhams.AutoSize = true;
            this.label_Derhams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Derhams.ForeColor = System.Drawing.Color.Yellow;
            this.label_Derhams.Location = new System.Drawing.Point(8, 438);
            this.label_Derhams.Name = "label_Derhams";
            this.label_Derhams.Size = new System.Drawing.Size(96, 20);
            this.label_Derhams.TabIndex = 17;
            this.label_Derhams.Text = "Dirham :  0";
            // 
            // Car_Racing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label_Derhams);
            this.Controls.Add(this.DH1);
            this.Controls.Add(this.DH5);
            this.Controls.Add(this.DH4);
            this.Controls.Add(this.DH3);
            this.Controls.Add(this.DH2);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.pictureBox_CarE2);
            this.Controls.Add(this.pictureBox_CarE3);
            this.Controls.Add(this.pictureBox_CarE1);
            this.Controls.Add(this.pictureBox_Car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Car_Racing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Car_Racing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DH1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBox_Car;
        private System.Windows.Forms.PictureBox pictureBox_CarE1;
        private System.Windows.Forms.PictureBox pictureBox_CarE3;
        private System.Windows.Forms.PictureBox pictureBox_CarE2;
        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.PictureBox DH2;
        private System.Windows.Forms.PictureBox DH3;
        private System.Windows.Forms.PictureBox DH4;
        private System.Windows.Forms.PictureBox DH5;
        private System.Windows.Forms.PictureBox DH1;
        private System.Windows.Forms.Label label_Derhams;
    }
}

