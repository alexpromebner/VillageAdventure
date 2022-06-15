
namespace VillageAdventure
{
    partial class AvoidGame
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
            this.pbx_character = new System.Windows.Forms.PictureBox();
            this.tmr_main = new System.Windows.Forms.Timer(this.components);
            this.pbx_left = new System.Windows.Forms.PictureBox();
            this.pbx_right = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_right)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_character
            // 
            this.pbx_character.BackColor = System.Drawing.Color.White;
            this.pbx_character.BackgroundImage = global::VillageAdventure.Properties.Resources.character;
            this.pbx_character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_character.Location = new System.Drawing.Point(180, 479);
            this.pbx_character.Name = "pbx_character";
            this.pbx_character.Size = new System.Drawing.Size(82, 102);
            this.pbx_character.TabIndex = 0;
            this.pbx_character.TabStop = false;
            // 
            // tmr_main
            // 
            this.tmr_main.Enabled = true;
            this.tmr_main.Interval = 1000;
            this.tmr_main.Tick += new System.EventHandler(this.tmr_main_Tick);
            // 
            // pbx_left
            // 
            this.pbx_left.Location = new System.Drawing.Point(-39, 1);
            this.pbx_left.Name = "pbx_left";
            this.pbx_left.Size = new System.Drawing.Size(39, 579);
            this.pbx_left.TabIndex = 1;
            this.pbx_left.TabStop = false;
            // 
            // pbx_right
            // 
            this.pbx_right.Location = new System.Drawing.Point(443, 2);
            this.pbx_right.Name = "pbx_right";
            this.pbx_right.Size = new System.Drawing.Size(39, 579);
            this.pbx_right.TabIndex = 2;
            this.pbx_right.TabStop = false;
            // 
            // AvoidGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 648);
            this.Controls.Add(this.pbx_right);
            this.Controls.Add(this.pbx_left);
            this.Controls.Add(this.pbx_character);
            this.Name = "AvoidGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvoidGame";
            this.Load += new System.EventHandler(this.AvoidGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AvoidGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_character;
        private System.Windows.Forms.Timer tmr_main;
        private System.Windows.Forms.PictureBox pbx_left;
        private System.Windows.Forms.PictureBox pbx_right;
    }
}