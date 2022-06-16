
namespace VillageAdventure
{
    partial class PingPongGame
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
            this.tmr_moveBall = new System.Windows.Forms.Timer(this.components);
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.lbl_pointsLeft = new System.Windows.Forms.Label();
            this.lbl_pointsRight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_coinsCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_ball = new System.Windows.Forms.PictureBox();
            this.pbx_platformRight = new System.Windows.Forms.PictureBox();
            this.pbx_platformLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_moveBall
            // 
            this.tmr_moveBall.Enabled = true;
            this.tmr_moveBall.Interval = 10;
            this.tmr_moveBall.Tick += new System.EventHandler(this.tmr_moveBall_Tick);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(9, 33);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(71, 18);
            this.lbl_close.TabIndex = 7;
            this.lbl_close.Text = "C - Close";
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.Location = new System.Drawing.Point(9, 15);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(80, 18);
            this.lbl_restart.TabIndex = 6;
            this.lbl_restart.Text = "R - Restart";
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 1000;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // lbl_pointsLeft
            // 
            this.lbl_pointsLeft.AutoSize = true;
            this.lbl_pointsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pointsLeft.Location = new System.Drawing.Point(443, 15);
            this.lbl_pointsLeft.Name = "lbl_pointsLeft";
            this.lbl_pointsLeft.Size = new System.Drawing.Size(16, 18);
            this.lbl_pointsLeft.TabIndex = 8;
            this.lbl_pointsLeft.Text = "0";
            // 
            // lbl_pointsRight
            // 
            this.lbl_pointsRight.AutoSize = true;
            this.lbl_pointsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pointsRight.Location = new System.Drawing.Point(558, 15);
            this.lbl_pointsRight.Name = "lbl_pointsRight";
            this.lbl_pointsRight.Size = new System.Drawing.Size(16, 18);
            this.lbl_pointsRight.TabIndex = 9;
            this.lbl_pointsRight.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(992, 15);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(16, 18);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "0";
            // 
            // lbl_coinsCounter
            // 
            this.lbl_coinsCounter.AutoSize = true;
            this.lbl_coinsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coinsCounter.Location = new System.Drawing.Point(992, 48);
            this.lbl_coinsCounter.Name = "lbl_coinsCounter";
            this.lbl_coinsCounter.Size = new System.Drawing.Size(16, 18);
            this.lbl_coinsCounter.TabIndex = 18;
            this.lbl_coinsCounter.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(925, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Coins:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(931, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Time:";
            // 
            // pbx_ball
            // 
            this.pbx_ball.BackColor = System.Drawing.Color.Transparent;
            this.pbx_ball.Location = new System.Drawing.Point(637, 371);
            this.pbx_ball.Name = "pbx_ball";
            this.pbx_ball.Size = new System.Drawing.Size(13, 13);
            this.pbx_ball.TabIndex = 20;
            this.pbx_ball.TabStop = false;
            // 
            // pbx_platformRight
            // 
            this.pbx_platformRight.BackColor = System.Drawing.Color.Transparent;
            this.pbx_platformRight.Image = global::VillageAdventure.Properties.Resources.platform;
            this.pbx_platformRight.Location = new System.Drawing.Point(995, 248);
            this.pbx_platformRight.Name = "pbx_platformRight";
            this.pbx_platformRight.Size = new System.Drawing.Size(28, 174);
            this.pbx_platformRight.TabIndex = 1;
            this.pbx_platformRight.TabStop = false;
            // 
            // pbx_platformLeft
            // 
            this.pbx_platformLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbx_platformLeft.Image = global::VillageAdventure.Properties.Resources.platform;
            this.pbx_platformLeft.Location = new System.Drawing.Point(12, 134);
            this.pbx_platformLeft.Name = "pbx_platformLeft";
            this.pbx_platformLeft.Size = new System.Drawing.Size(28, 174);
            this.pbx_platformLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_platformLeft.TabIndex = 0;
            this.pbx_platformLeft.TabStop = false;
            // 
            // PingPongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 615);
            this.Controls.Add(this.pbx_ball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_coinsCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_pointsRight);
            this.Controls.Add(this.lbl_pointsLeft);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.pbx_platformRight);
            this.Controls.Add(this.pbx_platformLeft);
            this.Name = "PingPongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPongGame";
            this.Load += new System.EventHandler(this.PingPongGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PingPongGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_platformLeft;
        private System.Windows.Forms.PictureBox pbx_platformRight;
        private System.Windows.Forms.Timer tmr_moveBall;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Label lbl_pointsLeft;
        private System.Windows.Forms.Label lbl_pointsRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_coinsCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_ball;
    }
}