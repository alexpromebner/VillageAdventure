using System;
using System.Drawing;
using System.Windows.Forms;

namespace VillageAdventure
{
    public partial class PingPongGame : Form
    {
        private int time = 0;
        private int platformSpeed = 20;
        //Ball
        private int ballWidth = 20;
        private int ballHeight = 20;
        private int locationX;
        private int locationY = 0;
        private int speedBallX = 8;
        private int speedBallY = 8;
        private int pointsLeft;
        private int pointsRight;
        private int coins = 0;
        PictureBox pbx_coin = new PictureBox();
        //Others
        private int randomPosition;

        public PingPongGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PingPongGame_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locationX = rnd.Next(0, ClientSize.Width);
            //prevent flicker
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            Random rndX = new Random();
            int coinX = rndX.Next(40, ClientSize.Width - 40);
            Random rndY = new Random();
            int coinY = rndY.Next(0, ClientSize.Height-pbx_coin.Height);
            pbx_coin.Image = Properties.Resources.Coin;
            pbx_coin.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_coin.Location = new Point(coinX, coinY);
            pbx_coin.Visible = true;
            Controls.Add(pbx_coin);

        }

        private void tmr_moveBall_Tick(object sender, EventArgs e)
        {
            //TODO --> automatic movement of the right platform
            //moveBall
            locationX += speedBallX;
            if (locationX <= 0)//left side
            {
                speedBallX = -speedBallX;
                pointsRight++;
                lbl_pointsRight.Text = Convert.ToString(pointsRight);
            }
            else if (locationX + ballWidth >= ClientSize.Width)//right side
            {
                speedBallX = -speedBallX;
                pointsLeft++;
                lbl_pointsLeft.Text = Convert.ToString(pointsLeft);
            }

            locationY += speedBallY;
            if (locationY <= 0)
            {
                speedBallY = -speedBallY;
            }
            else if (locationY + ballHeight >= ClientSize.Height)
            {
                speedBallY = -speedBallY;
            }

            Refresh();
            #region Collission Detection

            if (locationX + ballWidth >= pbx_platformRight.Left && locationY >= pbx_platformRight.Top && locationY <= pbx_platformRight.Top + pbx_platformRight.Height)//right platform
            {
                speedBallX = -speedBallX;
            }
            if (locationX <= pbx_platformLeft.Left + pbx_platformLeft.Width && locationY >= pbx_platformLeft.Top && locationY <= pbx_platformLeft.Top + pbx_platformLeft.Height)//left platform
            {
                speedBallX = -speedBallX;
            }
            #endregion
            #region automatic movement right platform
            if (pbx_platformRight.Top >= 0 || pbx_platformRight.Top + pbx_platformRight.Height <= ClientSize.Height)
            {
                pbx_platformRight.Top = locationY-10;
            }
            #endregion

            pbx_ball.Left = locationX;
            pbx_ball.Top = locationY;
            if (pbx_ball.Bounds.IntersectsWith(pbx_coin.Bounds))
            {
                Random rndX = new Random();
                int coinX = rndX.Next(40, ClientSize.Width - 40);
                Random rndY = new Random();
                int coinY = rndY.Next(0, ClientSize.Height-pbx_coin.Height);
                pbx_coin.Location = new Point(coinX,coinY);
                coins++;
                lbl_coinsCounter.Text = coins.ToString();
            }
        }

        private void PingPongGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                PingPongGame ppg = new PingPongGame();
                ppg.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
            #region movement platforms
            if (e.KeyCode == Keys.W)
            {
                if (pbx_platformLeft.Top > 0)
                {
                    pbx_platformLeft.Top -= platformSpeed;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (pbx_platformRight.Top > 0)
                {
                    pbx_platformRight.Top -= platformSpeed;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (pbx_platformLeft.Top + pbx_platformLeft.Height < ClientSize.Height)
                {
                    pbx_platformLeft.Top += platformSpeed;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pbx_platformRight.Top + pbx_platformRight.Height < ClientSize.Height)
                {
                    pbx_platformRight.Top += platformSpeed;
                }
            }
            #endregion
        }

        private void PingPongGame_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void PingPongGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Red, locationX, locationY, ballWidth, ballHeight);
            e.Graphics.DrawEllipse(Pens.Black, locationX, locationY, ballWidth, ballHeight);
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            time++;
            lbl_time.Text = time.ToString();
        }
    }
}
