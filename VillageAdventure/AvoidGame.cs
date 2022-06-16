using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageAdventure
{
    public partial class AvoidGame : Form
    {

        public int enemy;
        public int xRnd;
        public static PictureBox enemypic = new PictureBox();
        public Random rnd = new Random();

        public AvoidGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void lbl_info_Click(object sender, EventArgs e)
        {
            
        }

        private void AvoidGame_Load(object sender, EventArgs e)
        {
           
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            enemy = rnd.Next(1, 3);
            CheckBounds();

            if (enemy == 2)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (x.Tag == "enemy")
                        {
                            x.Top += 2;
                            if (x.Bounds.IntersectsWith(pbx_character.Bounds))
                            {
                                tmr_main.Stop();
                                tmr_spawnenemy.Stop();
                                x.Dispose();
                                DialogResult message = MessageBox.Show("Do you want to play again?", "You were too slow to hit a platform!", MessageBoxButtons.YesNo);

                                if (message == DialogResult.Yes)
                                {
                                    AvoidGame dj = new AvoidGame();
                                    this.Hide();
                                    dj.ShowDialog();
                                    this.Close();
                                }
                                else if(message == DialogResult.No)
                                {
                                    this.Close();
                                }
                            }
                        }

                    }
                }
                //MessageBox.Show(enemy.ToString());
            }
            if (enemy == 1)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if (x.Tag == "coin")
                        {
                            x.Top += 2;
                            if (x.Bounds.IntersectsWith(pbx_character.Bounds))
                            {
                                x.Dispose();
                                SQLInteraction.Update("Login", "coins");                                
                            }
                        }

                    }
                }
            }

            DoubleBuffered = true;
        }

        private void AvoidGame_KeyDown(object sender, KeyEventArgs e)
        {
            CharacterMovement locations = new CharacterMovement();
            locations.x = pbx_character.Location.X;
            locations.y = pbx_character.Location.Y;



            if (e.KeyCode == Keys.D)
            {
                locations.MoveRight();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            else if (e.KeyCode == Keys.A)
            {
                locations.MoveLeft();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            else if(e.KeyCode == Keys.R)
            {
                AvoidGame dj = new AvoidGame();
                this.Hide();
                dj.ShowDialog();
                this.Close();
            }
            else if (e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
        public void CheckBounds()
        {
            if (pbx_character.Bounds.IntersectsWith(pbx_right.Bounds))
            {
                pbx_character.Location = new Point(350, pbx_character.Location.Y);
            }
            if (pbx_character.Bounds.IntersectsWith(pbx_left.Bounds))
            {
                pbx_character.Location = new Point(-5, pbx_character.Location.Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tmr_spawnenemy_Tick(object sender, EventArgs e)
        {
            coin();
            opponent();
            
        }

        public PictureBox opponent()
        {
            
            PictureBox opp = new PictureBox();
            opp.Width = 20;
            opp.Height = 20;
            opp.BackColor = Color.Red;
            opp.Tag = "enemy";
            this.Controls.Add(opp);
            opp.Location = new Point(rnd.Next(0, ClientSize.Width), rnd.Next(0, 250));

            return opp;
        }
        public PictureBox coin()
        {
            
            PictureBox co = new PictureBox();
            co.Width = 20;
            co.Height = 20;
            co.Image = VillageAdventure.Properties.Resources.Coin;
            co.Tag = "coin";
            co.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(co);
            co.Location = new Point(rnd.Next(0, ClientSize.Width), rnd.Next(0, 250));

            return co;
        }

        private void lbl_coins_Click(object sender, EventArgs e)
        {
            
        }
    }
}
