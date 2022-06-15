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
            if(pbx_character.Name == "pbx_character")
            {
                tmr_main.Interval = 1;
                CheckBounds();
            }
            tmr_main.Interval = 1000;

            Random rnd = new Random();
            enemy = rnd.Next(1, 3);
            PictureBox enemypic = new PictureBox();


            CharacterMovement movement = new CharacterMovement();
            movement.x = enemypic.Location.X;
            movement.y = enemypic.Location.Y;

            if (enemy == 2)
            {
                enemypic.Width = 100;
                enemypic.Height = 100;
                enemypic.BackColor = Color.Red;
                enemypic.Location = new Point(rnd.Next(0, 458), rnd.Next(0, 250));
                Controls.Add(enemypic);

                //MessageBox.Show(enemy.ToString());
            }
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
    }
}
