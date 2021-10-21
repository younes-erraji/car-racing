using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
    public partial class Car_Racing : Form
    {
        public Car_Racing()
        {
            InitializeComponent();
            label_GameOver.Visible = false;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            Enemy(gameSpeed);
            GameOver();
            CoinsDh(gameSpeed);
            DhCollection();
        }
        void Enemy(int speed)
        {
            Random r = new Random();
            int x;
            if (pictureBox_CarE1.Top >= 500)
            {
                x = r.Next(20, 280);
                pictureBox_CarE1.Location = new Point(x, 0);
            }
            else
                pictureBox_CarE1.Top += speed;
            if (pictureBox_CarE3.Top >= 500)
            {
                x = r.Next(20, 300);
                pictureBox_CarE3.Location = new Point(x, 0);
            }
            else
                pictureBox_CarE3.Top += speed;
            if (pictureBox_CarE2.Top >= 500)
            {
                x = r.Next(200, 320);
                pictureBox_CarE2.Location = new Point(x, 0);
            }
            else
                pictureBox_CarE2.Top += speed;
        }
        void GameOver()
        {
            if ((pictureBox_Car.Bounds.IntersectsWith(pictureBox_CarE1.Bounds)) ||
                (pictureBox_Car.Bounds.IntersectsWith(pictureBox_CarE2.Bounds)) ||
                (pictureBox_Car.Bounds.IntersectsWith(pictureBox_CarE3.Bounds)))
            {
                timerGame.Enabled = false;
                label_GameOver.Visible = true;
            }
        }
        void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
                pictureBox1.Top = 0;
            else
                pictureBox1.Top += speed;
            if (pictureBox4.Top >= 500)
                pictureBox4.Top = 0;
            else
                pictureBox4.Top += speed;
            if (pictureBox3.Top >= 500)
                pictureBox3.Top = 0;
            else
                pictureBox3.Top += speed;
            if (pictureBox2.Top >= 500)
                pictureBox2.Top = 0;
            else
                pictureBox2.Top += speed;
        }
        int gameSpeed = 0;
        int CollectedDh = 0;
        private void Car_Racing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Left > 20)
                    pictureBox_Car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_Car.Right < 366)
                    pictureBox_Car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                    gameSpeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                    gameSpeed--;
            }
        }
        void CoinsDh(int speed)
        {
            Random r = new Random();
            int x;
            if (DH1.Top >= 500)
            {
                x = r.Next(20, 320);
                DH1.Location = new Point(x, 0);
            }
            else
                DH1.Top += speed;
            if (DH2.Top >= 500)
            {
                x = r.Next(20, 320);
                DH2.Location = new Point(x, 0);
            }
            else
                DH2.Top += speed;
            if (DH3.Top >= 500)
            {
                x = r.Next(20, 320);
                DH3.Location = new Point(x, 0);
            }
            else
                DH3.Top += speed;
            if (DH4.Top >= 500)
            {
                x = r.Next(20, 320);
                DH4.Location = new Point(x, 0);
            }
            else
                DH4.Top += speed;
            if (DH5.Top >= 500)
            {
                x = r.Next(20, 280);
                DH5.Location = new Point(x, 0);
            }
            else
                DH5.Top += speed;
        }
        void DhCollection()
        {
            if (pictureBox_Car.Bounds.IntersectsWith(DH1.Bounds))
            {
                CollectedDh++;
                label_Derhams.Text = "Dirham : " + CollectedDh;
                DH1.Visible = false;
            }
            if (pictureBox_Car.Bounds.IntersectsWith(DH2.Bounds))
            {
                CollectedDh++;
                label_Derhams.Text = "Dirham : " + CollectedDh;
                DH2.Visible = false;
            }
            if (pictureBox_Car.Bounds.IntersectsWith(DH3.Bounds))
            {
                CollectedDh++;
                label_Derhams.Text = "Dirham : " + CollectedDh;
                DH3.Visible = false;
            }
            if (pictureBox_Car.Bounds.IntersectsWith(DH4.Bounds))
            {
                CollectedDh++;
                label_Derhams.Text = "Dirham : " + CollectedDh;
                DH4.Visible = false;
            }
            if (pictureBox_Car.Bounds.IntersectsWith(DH5.Bounds))
            {
                CollectedDh++;
                label_Derhams.Text = "Dirham : " + CollectedDh;
                DH5.Visible = false;
            }
        }
    }
}
