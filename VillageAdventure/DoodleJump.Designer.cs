
namespace VillageAdventure
{
    partial class frm_doodlejump
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
            this.tmr_gravity = new System.Windows.Forms.Timer(this.components);
            this.tmr_checkbounds = new System.Windows.Forms.Timer(this.components);
            this.tmr_jump = new System.Windows.Forms.Timer(this.components);
            this.lbl_points = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_left = new System.Windows.Forms.PictureBox();
            this.pbx_down = new System.Windows.Forms.PictureBox();
            this.pbx_character = new System.Windows.Forms.PictureBox();
            this.tmr_coin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_gravity
            // 
            this.tmr_gravity.Enabled = true;
            this.tmr_gravity.Interval = 5;
            this.tmr_gravity.Tick += new System.EventHandler(this.tmr_gravity_Tick);
            // 
            // tmr_checkbounds
            // 
            this.tmr_checkbounds.Enabled = true;
            this.tmr_checkbounds.Interval = 1;
            this.tmr_checkbounds.Tick += new System.EventHandler(this.tmr_checkbounds_Tick);
            // 
            // tmr_jump
            // 
            this.tmr_jump.Enabled = true;
            this.tmr_jump.Interval = 50;
            this.tmr_jump.Tick += new System.EventHandler(this.tmr_spawnplatform_Tick);
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_points.Location = new System.Drawing.Point(9, 9);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(75, 18);
            this.lbl_points.TabIndex = 12;
            this.lbl_points.Text = "Points: 0";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox8.Location = new System.Drawing.Point(173, 34);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "base";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox12.Location = new System.Drawing.Point(173, 428);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 15;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "base";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox10.Location = new System.Drawing.Point(267, 88);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "base";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox9.Location = new System.Drawing.Point(66, 88);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "base";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox7.Location = new System.Drawing.Point(235, 325);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "base";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox6.Location = new System.Drawing.Point(25, 214);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "base";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox5.Location = new System.Drawing.Point(115, 277);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "base";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox4.Location = new System.Drawing.Point(139, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "base";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox3.Location = new System.Drawing.Point(267, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "base";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VillageAdventure.Properties.Resources.DoodleJumpPlatformtransparent;
            this.pictureBox1.Location = new System.Drawing.Point(56, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "base";
            // 
            // pbx_left
            // 
            this.pbx_left.Location = new System.Drawing.Point(-11, -1);
            this.pbx_left.Name = "pbx_left";
            this.pbx_left.Size = new System.Drawing.Size(10, 453);
            this.pbx_left.TabIndex = 2;
            this.pbx_left.TabStop = false;
            // 
            // pbx_down
            // 
            this.pbx_down.Location = new System.Drawing.Point(0, 460);
            this.pbx_down.Name = "pbx_down";
            this.pbx_down.Size = new System.Drawing.Size(330, 10);
            this.pbx_down.TabIndex = 1;
            this.pbx_down.TabStop = false;
            this.pbx_down.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbx_character
            // 
            this.pbx_character.BackColor = System.Drawing.Color.Transparent;
            this.pbx_character.Image = global::VillageAdventure.Properties.Resources.character;
            this.pbx_character.Location = new System.Drawing.Point(173, 359);
            this.pbx_character.Name = "pbx_character";
            this.pbx_character.Size = new System.Drawing.Size(50, 72);
            this.pbx_character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_character.TabIndex = 0;
            this.pbx_character.TabStop = false;
            this.pbx_character.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmr_coin
            // 
            this.tmr_coin.Enabled = true;
            this.tmr_coin.Interval = 2000;
            this.tmr_coin.Tick += new System.EventHandler(this.tmr_coin_Tick);
            // 
            // frm_doodlejump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 460);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbx_left);
            this.Controls.Add(this.pbx_down);
            this.Controls.Add(this.pbx_character);
            this.Name = "frm_doodlejump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doodle Jump";
            this.Load += new System.EventHandler(this.frm_doodlejump_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_doodlejump_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_character;
        private System.Windows.Forms.Timer tmr_gravity;
        private System.Windows.Forms.Timer tmr_checkbounds;
        private System.Windows.Forms.PictureBox pbx_down;
        private System.Windows.Forms.PictureBox pbx_left;
        private System.Windows.Forms.Timer tmr_jump;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer tmr_coin;
    }
}