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
    public partial class frm_doodlejump : Form
    {
        #region Variablen
        int gravity = 1;       
        int pbx_y = 5;
        int force = -1;
        int points;
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        PictureBox pbx_test = new PictureBox();
        #endregion

        public frm_doodlejump()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_doodlejump_KeyDown(object sender, KeyEventArgs e)
        {
            CharacterMovement locations = new CharacterMovement();
            locations.x = pbx_character.Location.X;
            locations.y = pbx_character.Location.Y;

            

            if (e.KeyCode == Keys.D)
            {
                locations.MoveRight();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            else if(e.KeyCode == Keys.A)
            {
                locations.MoveLeft();
                pbx_character.Location = new Point(locations.x, locations.y);
            }
            DoubleBuffered = true;
            
        }

        public void CheckBounds()
        {
            if (pbx_character.Width + pbx_character.Left > this.ClientRectangle.Width)
            {
                pbx_character.Location = new Point(1, pbx_character.Location.Y);
            }
            if (pbx_character.Bounds.IntersectsWith(pbx_left.Bounds))
            {
                pbx_character.Location = new Point(288, pbx_character.Location.Y);
            }
        }

        private void frm_doodlejump_Load(object sender, EventArgs e)
        {

        }
        private void tmr_falldown_Tick(object sender, EventArgs e)
        {
            
        }

        private void tmr_checkbounds_Tick(object sender, EventArgs e)
        {
            CheckBounds();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void Autojump()
        {
            foreach(Control x in Controls)
            {
                if (x is PictureBox && x.Tag == "base")
                {
                    if(pbx_character.Bounds.IntersectsWith(x.Bounds) && pbx_character.Top > 100)
                    {
                        pbx_character.Top = x.Top - pbx_character.Height;
                        pbx_character.Top -= 100;
                    }
                    if(pbx_character.Bounds.IntersectsWith(x.Bounds) == pbx_character.Top > 200)
                    {
                        x.Top += 10;
                    }
                }
                if (x.Top > 500)
                {
                    points += 1;
                    lbl_points.Text = "Points: " + points;
                    x.Top = 0;
                }
            }    
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
            co.Location = new Point(rand.Next(0, ClientSize.Width), rand.Next(0, 250));

            return co;
        }

        private void tmr_spawnplatform_Tick(object sender, EventArgs e)
        {
            Autojump();
            pbx_character.Top += 10;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if (x.Tag == "coin")
                    {
                        
                        if (x.Bounds.IntersectsWith(pbx_character.Bounds))
                        {
                            x.Dispose();
                            SQLInteraction.Update("Login", "coins");
                        }
                    }

                }
            }
        }

        private void pbx_platform_Click(object sender, EventArgs e)
        {

        }       

        private void tmr_gravity_Tick(object sender, EventArgs e)
        {
            if (pbx_character.Bounds.IntersectsWith(pbx_test.Bounds) && pbx_test.Top + pbx_test.Height >= pbx_test.Top)
            {
                gravity = -1;
            } 

            if(pbx_character.Bounds.IntersectsWith(pbx_down.Bounds))
            {
                pbx_down.Location = new Point(800, 800);
                DialogResult message = MessageBox.Show("Do you want to play again?", "You were too slow to hit a platform!", MessageBoxButtons.YesNo);
                tmr_jump.Stop();
                pbx_character.Location = new Point(1800,1800);

                tmr_jump.Stop();

                if(message == DialogResult.Yes)
                {
                    frm_doodlejump dj = new frm_doodlejump();
                    this.Hide();
                    dj.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void tmr_coin_Tick(object sender, EventArgs e)
        {
            coin();
        }
    }

    
}
