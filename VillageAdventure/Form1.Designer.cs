
namespace VillageAdventure
{
    partial class frm_JumpAndRun
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_move = new System.Windows.Forms.Timer(this.components);
            this.lbl_restart = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.tmr_movePlatforms = new System.Windows.Forms.Timer(this.components);
            this.tmr_movePlayerPlatform = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.tmr_removeStart = new System.Windows.Forms.Timer(this.components);
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.lbl_timeToSpawn = new System.Windows.Forms.Label();
            this.tmr_timeToSpawn = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_coinsCounter = new System.Windows.Forms.Label();
            this.pbx_bush = new System.Windows.Forms.PictureBox();
            this.pbx_collisionGameOver = new System.Windows.Forms.PictureBox();
            this.pbx_platformStart = new System.Windows.Forms.PictureBox();
            this.pbx_platform2 = new System.Windows.Forms.PictureBox();
            this.pbx_player = new System.Windows.Forms.PictureBox();
            this.pbx_tree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_tree)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_move
            // 
            this.tmr_move.Enabled = true;
            this.tmr_move.Interval = 20;
            this.tmr_move.Tick += new System.EventHandler(this.tmr_move_Tick);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.Location = new System.Drawing.Point(13, 13);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(80, 18);
            this.lbl_restart.TabIndex = 4;
            this.lbl_restart.Text = "R - Restart";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(13, 31);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(71, 18);
            this.lbl_close.TabIndex = 5;
            this.lbl_close.Text = "C - Close";
            // 
            // tmr_movePlatforms
            // 
            this.tmr_movePlatforms.Enabled = true;
            this.tmr_movePlatforms.Interval = 15;
            this.tmr_movePlatforms.Tick += new System.EventHandler(this.tmr_movePlatforms_Tick);
            // 
            // tmr_movePlayerPlatform
            // 
            this.tmr_movePlayerPlatform.Enabled = true;
            this.tmr_movePlayerPlatform.Interval = 1;
            this.tmr_movePlayerPlatform.Tick += new System.EventHandler(this.tmr_movePlayerPlatform_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1048, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(16, 18);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "0";
            // 
            // tmr_removeStart
            // 
            this.tmr_removeStart.Enabled = true;
            this.tmr_removeStart.Tick += new System.EventHandler(this.tmr_removeStart_Tick);
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 1000;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // lbl_timeToSpawn
            // 
            this.lbl_timeToSpawn.AutoSize = true;
            this.lbl_timeToSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeToSpawn.Location = new System.Drawing.Point(530, 267);
            this.lbl_timeToSpawn.Name = "lbl_timeToSpawn";
            this.lbl_timeToSpawn.Size = new System.Drawing.Size(16, 18);
            this.lbl_timeToSpawn.TabIndex = 13;
            this.lbl_timeToSpawn.Text = "0";
            // 
            // tmr_timeToSpawn
            // 
            this.tmr_timeToSpawn.Enabled = true;
            this.tmr_timeToSpawn.Interval = 10;
            this.tmr_timeToSpawn.Tick += new System.EventHandler(this.tmr_timeToSpawn_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(987, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Coins:";
            // 
            // lbl_coinsCounter
            // 
            this.lbl_coinsCounter.AutoSize = true;
            this.lbl_coinsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coinsCounter.Location = new System.Drawing.Point(1048, 43);
            this.lbl_coinsCounter.Name = "lbl_coinsCounter";
            this.lbl_coinsCounter.Size = new System.Drawing.Size(16, 18);
            this.lbl_coinsCounter.TabIndex = 16;
            this.lbl_coinsCounter.Text = "0";
            // 
            // pbx_bush
            // 
            this.pbx_bush.BackColor = System.Drawing.Color.Transparent;
            this.pbx_bush.Location = new System.Drawing.Point(782, 441);
            this.pbx_bush.Name = "pbx_bush";
            this.pbx_bush.Size = new System.Drawing.Size(132, 96);
            this.pbx_bush.TabIndex = 18;
            this.pbx_bush.TabStop = false;
            // 
            // pbx_collisionGameOver
            // 
            this.pbx_collisionGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pbx_collisionGameOver.Location = new System.Drawing.Point(-10, 0);
            this.pbx_collisionGameOver.Name = "pbx_collisionGameOver";
            this.pbx_collisionGameOver.Size = new System.Drawing.Size(10, 552);
            this.pbx_collisionGameOver.TabIndex = 12;
            this.pbx_collisionGameOver.TabStop = false;
            this.pbx_collisionGameOver.Visible = false;
            // 
            // pbx_platformStart
            // 
            this.pbx_platformStart.BackColor = System.Drawing.Color.Black;
            this.pbx_platformStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_platformStart.Location = new System.Drawing.Point(1, 267);
            this.pbx_platformStart.Name = "pbx_platformStart";
            this.pbx_platformStart.Size = new System.Drawing.Size(161, 19);
            this.pbx_platformStart.TabIndex = 10;
            this.pbx_platformStart.TabStop = false;
            this.pbx_platformStart.Tag = "platform";
            // 
            // pbx_platform2
            // 
            this.pbx_platform2.BackColor = System.Drawing.Color.Black;
            this.pbx_platform2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_platform2.Location = new System.Drawing.Point(1, 537);
            this.pbx_platform2.Name = "pbx_platform2";
            this.pbx_platform2.Size = new System.Drawing.Size(1077, 16);
            this.pbx_platform2.TabIndex = 3;
            this.pbx_platform2.TabStop = false;
            this.pbx_platform2.Tag = "platform";
            // 
            // pbx_player
            // 
            this.pbx_player.BackColor = System.Drawing.Color.Transparent;
            this.pbx_player.Image = global::VillageAdventure.Properties.Resources.PlayerFront;
            this.pbx_player.Location = new System.Drawing.Point(12, 138);
            this.pbx_player.Name = "pbx_player";
            this.pbx_player.Size = new System.Drawing.Size(67, 123);
            this.pbx_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_player.TabIndex = 2;
            this.pbx_player.TabStop = false;
            this.pbx_player.Tag = "player";
            // 
            // pbx_tree
            // 
            this.pbx_tree.BackColor = System.Drawing.Color.Transparent;
            this.pbx_tree.Location = new System.Drawing.Point(920, 395);
            this.pbx_tree.Name = "pbx_tree";
            this.pbx_tree.Size = new System.Drawing.Size(132, 145);
            this.pbx_tree.TabIndex = 17;
            this.pbx_tree.TabStop = false;
            // 
            // frm_JumpAndRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.pbx_bush);
            this.Controls.Add(this.lbl_coinsCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_timeToSpawn);
            this.Controls.Add(this.pbx_collisionGameOver);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pbx_platformStart);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.pbx_platform2);
            this.Controls.Add(this.pbx_player);
            this.Controls.Add(this.pbx_tree);
            this.Name = "frm_JumpAndRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpAndRun";
            this.Load += new System.EventHandler(this.frm_JumpAndRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.PictureBox pbx_player;
        private System.Windows.Forms.PictureBox pbx_platform2;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Timer tmr_movePlatforms;
        private System.Windows.Forms.Timer tmr_movePlayerPlatform;
        private System.Windows.Forms.PictureBox pbx_platformStart;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer tmr_removeStart;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.PictureBox pbx_collisionGameOver;
        private System.Windows.Forms.Label lbl_timeToSpawn;
        private System.Windows.Forms.Timer tmr_timeToSpawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_coinsCounter;
        private System.Windows.Forms.PictureBox pbx_tree;
        private System.Windows.Forms.PictureBox pbx_bush;
    }
}

