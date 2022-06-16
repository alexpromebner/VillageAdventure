using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VillageAdventure
{
    public partial class frm_JumpAndRun : Form
    {
        #region variables
        private bool left = false;
        private bool right = false;
        private bool jump = false;
        private int gravity = 30;
        private int force = 0;
        private int speed = 10;//speed of the player
        private int time = 0;
        private int timeToSpawn = 0;
        private bool playerOnFloor;
        public int platformPositionHeight;
        private int speedPlatform = 7;
        private int coins = 0;
        PictureBox pbx_randomPlatform = new PictureBox();//first platform
        PictureBox pbx_newPlatform = new PictureBox();//second platform
        PictureBox pbx_newPlatform2 = new PictureBox();//third platform
        PictureBox pbx_newPlatform3 = new PictureBox();//fourth platform
        PictureBox pbx_coin1 = new PictureBox();
        PictureBox pbx_coin2 = new PictureBox();
        #endregion
        #region Lists
        List<PictureBox> list = new List<PictureBox>();
        #endregion
        public frm_JumpAndRun()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                frm_JumpAndRun jar = new frm_JumpAndRun();
                jar.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.C)
            {
                //this.Close();//open the startform afterwards
                Application.Exit();
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (jump != true)
                {
                    jump = true;
                    force = gravity;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                //Start Game
            }

        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            left = false;
            right = false;
        }

        private void frm_JumpAndRun_Load(object sender, EventArgs e)
        {
            pbx_player.Location = new Point(1, pbx_platformStart.Top - pbx_player.Height);
            this.DoubleBuffered = true;//makes the movement of the player smoother

            #region random Platforms           
            Random rnd = new Random();
            platformPositionHeight = rnd.Next(150, 400);//create first platform - Picturebox Height = 123 --> random between 150 and 591
            pbx_randomPlatform.BackColor = Color.Black;
            pbx_randomPlatform.Size = new Size(250, 20);
            pbx_randomPlatform.Location = new Point(1000, platformPositionHeight);
            pbx_randomPlatform.Tag = "Platform";
            pbx_randomPlatform.Visible = true;
            Controls.Add(pbx_randomPlatform);//without this the pictureboxes wouldn't spawn
            #endregion

            lbl_timeToSpawn.Visible = false;//Improve

            #region List          
            list.Add(pbx_randomPlatform);
            list.Add(pbx_newPlatform);
            list.Add(pbx_newPlatform2);
            list.Add(pbx_newPlatform3);
            #endregion


        }

        private void tmr_move_Tick(object sender, EventArgs e)
        {
            #region FormDetection
            if (left && pbx_player.Left > 0)//left
            {
                pbx_player.Left -= speed;
            }
            else if (right && pbx_player.Left + pbx_player.Width < ClientSize.Width)//right
            {
                pbx_player.Left += speed;
            }
            if (jump == true)//jump
            {
                pbx_player.Top -= force;
                force -= 2;
                //jump = false;
            }
            if (pbx_player.Top + pbx_player.Height >= ClientSize.Height)
            {
                pbx_player.Top = ClientSize.Height - pbx_player.Height;
            }
            if (pbx_player.Top <= 0)
            {
                pbx_player.Top = 0;
            }
            DoubleBuffered = true;
            #endregion

        }

        private void tmr_movePlatforms_Tick(object sender, EventArgs e)
        {
            #region first Platform
            if (pbx_randomPlatform.Left + pbx_randomPlatform.Width < 0)//Black platform
            {
                pbx_randomPlatform.Left = ClientSize.Width + pbx_randomPlatform.Width;
                Random rnd = new Random();
                pbx_randomPlatform.Top = rnd.Next(200, 400);
            }

            pbx_randomPlatform.Left -= 7;//movement for the first platform
            DoubleBuffered = true;
            #endregion
            #region second Platform
            if (lbl_timeToSpawn.Text == "50")
            {
                Random rndBlue = new Random();
                int platformPositionHeightBlue = rndBlue.Next(200, 400);
                pbx_newPlatform.BackColor = Color.Black;
                pbx_newPlatform.BorderStyle = BorderStyle.None;
                pbx_newPlatform.Size = new Size(150, 20);
                pbx_newPlatform.Tag = "Platform";
                pbx_newPlatform.Location = new Point(1000, platformPositionHeightBlue);
                pbx_newPlatform.Visible = true;
                Controls.Add(pbx_newPlatform);

                //spawn coin
                pbx_coin1.Image = Properties.Resources.Coin;
                pbx_coin1.SizeMode = PictureBoxSizeMode.Zoom;
                pbx_coin1.Location = new Point(pbx_newPlatform.Left + 25, pbx_newPlatform.Top - pbx_coin1.Height);
                pbx_coin1.Visible = true;
                Controls.Add(pbx_coin1);

                //spawn tree
                pbx_tree.Image = Properties.Resources.treedark;
                pbx_tree.SizeMode = PictureBoxSizeMode.Zoom;
                pbx_tree.Location = new Point(ClientSize.Width, ClientSize.Height - pbx_platform2.Height - pbx_tree.Height);
                pbx_tree.Visible = true;
                Controls.Add(pbx_tree);


            }
            else if (pbx_newPlatform.Left + pbx_newPlatform.Width < 0)
            {
                Random rnd = new Random();
                int posY = rnd.Next(200, 400);
                pbx_newPlatform.Top = posY;
                pbx_newPlatform.Left = ClientSize.Width;
                pbx_newPlatform.Left -= speedPlatform;//movement for the second platform
                DoubleBuffered = true;
                pbx_coin1.Top = posY - pbx_coin1.Height;
                pbx_coin1.Left = ClientSize.Width;
                pbx_coin1.Left -= 7;
                pbx_tree.Left = ClientSize.Width;
                pbx_tree.Left -= 7;
            }

            pbx_newPlatform.Left -= 7;//movement for the second platform
            DoubleBuffered = true;

            pbx_coin1.Left -= 7;
            pbx_tree.Left -= 7;
            #endregion
            #region third Platform
            if (lbl_timeToSpawn.Text == "100")
            {
                Random rnd = new Random();
                int platformPositionHeight = rnd.Next(200, 400);
                pbx_newPlatform2.BackColor = Color.Black;
                pbx_newPlatform2.BorderStyle = BorderStyle.FixedSingle;
                pbx_newPlatform2.Size = new Size(150, 20);
                pbx_newPlatform2.Tag = "Platform";
                pbx_newPlatform2.Location = new Point(1000, platformPositionHeight);
                pbx_newPlatform2.Visible = true;
                Controls.Add(pbx_newPlatform2);
            }
            else if (pbx_newPlatform2.Left + pbx_newPlatform2.Width < 0)
            {
                Random rnd = new Random();
                pbx_newPlatform2.Top = rnd.Next(200, 400);
                pbx_newPlatform2.Left = ClientSize.Width;
                pbx_newPlatform2.Left -= speedPlatform;
            }
            pbx_newPlatform2.Left -= speedPlatform;
            DoubleBuffered = true;
            #endregion
            #region fourth Platform
            if (lbl_timeToSpawn.Text == "150")
            {
                Random rnd = new Random();
                int platformPositionHeight = rnd.Next(200, 400);
                pbx_newPlatform3.BackColor = Color.Black;
                pbx_newPlatform3.Size = new Size(200, 20);
                pbx_newPlatform3.Tag = "Platform";
                pbx_newPlatform3.Location = new Point(1000, platformPositionHeight);
                pbx_newPlatform3.Visible = true;
                Controls.Add(pbx_newPlatform3);

                //spawn coin
                pbx_coin2.Image = Properties.Resources.Coin;
                pbx_coin2.SizeMode = PictureBoxSizeMode.Zoom;
                pbx_coin2.Location = new Point(pbx_newPlatform3.Left + 45, pbx_newPlatform3.Top - pbx_coin2.Height);
                pbx_coin2.Visible = true;
                Controls.Add(pbx_coin2);

                //spawn bush
                pbx_bush.Image = Properties.Resources.Busch2;
                pbx_bush.SizeMode = PictureBoxSizeMode.Zoom;
                pbx_bush.Location = new Point(ClientSize.Width, ClientSize.Height - pbx_platform2.Height - pbx_bush.Height);
                pbx_bush.Visible = true;
                Controls.Add(pbx_bush);
            }
            else if (pbx_newPlatform3.Left + pbx_newPlatform3.Width < 0)
            {
                Random rnd = new Random();
                int posY = rnd.Next(200, 400);
                pbx_newPlatform3.Top = posY;
                pbx_newPlatform3.Left = ClientSize.Width;
                pbx_newPlatform3.Left -= speedPlatform;
                pbx_coin2.Top = posY - pbx_coin2.Height;
                pbx_coin2.Left = ClientSize.Width;
                pbx_coin2.Left -= 7;
                pbx_bush.Left = ClientSize.Width;
                pbx_bush.Left -= 7;
            }
            pbx_newPlatform3.Left -= speedPlatform;
            DoubleBuffered = true;

            pbx_coin2.Left -= 7;
            pbx_bush.Left -= 7;
            #endregion

            //despawn start platform
            if (lbl_time.Text == "5")
            {
                pbx_platformStart.Location = new Point(800, 800);
            }

        }

        private void tmr_movePlayerPlatform_Tick(object sender, EventArgs e)
        {
            #region ColissionDetection

            foreach (PictureBox p in list)
            {
                //top
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Top + pbx_player.Height >= p.Top && pbx_player.Left >= p.Left && pbx_player.Left + pbx_player.Width <= p.Left + p.Width)
                {
                    pbx_player.Top = p.Top - pbx_player.Height;
                    pbx_player.Left -= 7;
                    DoubleBuffered = true;
                    jump = false;
                }
                if (pbx_platformStart.Bounds.IntersectsWith(pbx_platformStart.Bounds) && pbx_player.Top + pbx_player.Height >= pbx_platformStart.Top && pbx_player.Left >= pbx_platformStart.Left && pbx_player.Left + pbx_player.Width <= pbx_platformStart.Left + pbx_platformStart.Width)
                {
                    pbx_player.Top = pbx_platformStart.Top - pbx_player.Height;
                    jump = false;
                }
                //left side of the platform
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Left + pbx_player.Width >= p.Left && pbx_player.Left <= p.Left + p.Width)
                {
                    right = false;
                    DoubleBuffered = true;
                }
                //right side of the platform
                if (pbx_player.Bounds.IntersectsWith(p.Bounds) && pbx_player.Left <= p.Left + p.Width)
                {
                    left = false;
                    DoubleBuffered = true;
                }
                if (jump == false)
                {
                    pbx_player.Top += 1;
                }
                if (jump && pbx_player.Bounds.IntersectsWith(p.Bounds) && force >= 0)
                {
                    force = 0;
                }
            }
            #endregion
            #region ColissionDetectionGameOver
            if (pbx_player.Bounds.IntersectsWith(pbx_platform2.Bounds) && pbx_player.Top + pbx_player.Height >= pbx_platform2.Top && pbx_player.Left >= pbx_platform2.Left && pbx_player.Left + pbx_player.Width <= pbx_platform2.Left + pbx_platform2.Width)
            {
                pbx_platform2.Location = new Point(800, 800);
                pbx_player.Top = pbx_platform2.Top - pbx_player.Height;
                GameOver gmeovr = new GameOver();
                gmeovr.Show();
                this.Hide();
            }
            if (pbx_player.Bounds.IntersectsWith(pbx_collisionGameOver.Bounds))
            {
                pbx_platform2.Location = new Point(800, 800);
                GameOver gmeovr = new GameOver();
                gmeovr.Show();
                this.Hide();
                pbx_collisionGameOver.Location = new Point(800, 800);
            }
            if (pbx_player.Bounds.IntersectsWith(pbx_coin1.Bounds))
            {
                pbx_coin1.Location = new Point(800, 800);
                coins++;
                lbl_coinsCounter.Text = coins.ToString();
            }
            if (pbx_player.Bounds.IntersectsWith(pbx_coin2.Bounds))
            {
                pbx_coin2.Location = new Point(800, 800);
                coins++;
                lbl_coinsCounter.Text = coins.ToString();
            }
            #endregion
        }

        private void tmr_removeStart_Tick(object sender, EventArgs e)
        {
            if (lbl_time.Text == "50")
            {
                pbx_platformStart.Location = new Point(800, 800);
            }
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            time++;
            lbl_time.Text = time.ToString();
        }

        private void tmr_timeToSpawn_Tick(object sender, EventArgs e)
        {
            timeToSpawn++;
            lbl_timeToSpawn.Text = timeToSpawn.ToString();
        }

    }
}
