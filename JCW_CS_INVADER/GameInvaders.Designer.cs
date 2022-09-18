
namespace JCW_CS_INVADER
{
    partial class GameInvaders
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInvaders));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Player = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyStar = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemySpaceship = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemySaucer = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyBugs = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemySatellite = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerShot = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyShot = new System.Windows.Forms.PictureBox();
            this.pictureBox_TwinklingStar = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerLife1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerLife2 = new System.Windows.Forms.PictureBox();
            this.Label_ScoreTitle = new System.Windows.Forms.Label();
            this.Label_ScorePoint = new System.Windows.Forms.Label();
            this.Label_GameOver = new System.Windows.Forms.Label();
            this.Label_OverInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySpaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySaucer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySatellite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TwinklingStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerLife2)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 33;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureBox_Player
            // 
            this.pictureBox_Player.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Player.Enabled = false;
            this.pictureBox_Player.Image = global::JCW_CS_INVADER.Properties.Resources.player;
            this.pictureBox_Player.Location = new System.Drawing.Point(770, 420);
            this.pictureBox_Player.Name = "pictureBox_Player";
            this.pictureBox_Player.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Player.TabIndex = 0;
            this.pictureBox_Player.TabStop = false;
            this.pictureBox_Player.Visible = false;
            // 
            // pictureBox_EnemyStar
            // 
            this.pictureBox_EnemyStar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyStar.Enabled = false;
            this.pictureBox_EnemyStar.Image = global::JCW_CS_INVADER.Properties.Resources.star1;
            this.pictureBox_EnemyStar.Location = new System.Drawing.Point(630, 200);
            this.pictureBox_EnemyStar.Name = "pictureBox_EnemyStar";
            this.pictureBox_EnemyStar.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemyStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyStar.TabIndex = 1;
            this.pictureBox_EnemyStar.TabStop = false;
            this.pictureBox_EnemyStar.Visible = false;
            // 
            // pictureBox_EnemySpaceship
            // 
            this.pictureBox_EnemySpaceship.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySpaceship.Enabled = false;
            this.pictureBox_EnemySpaceship.Image = global::JCW_CS_INVADER.Properties.Resources.spaceship1;
            this.pictureBox_EnemySpaceship.Location = new System.Drawing.Point(630, 150);
            this.pictureBox_EnemySpaceship.Name = "pictureBox_EnemySpaceship";
            this.pictureBox_EnemySpaceship.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySpaceship.TabIndex = 2;
            this.pictureBox_EnemySpaceship.TabStop = false;
            this.pictureBox_EnemySpaceship.Visible = false;
            // 
            // pictureBox_EnemySaucer
            // 
            this.pictureBox_EnemySaucer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySaucer.Enabled = false;
            this.pictureBox_EnemySaucer.Image = global::JCW_CS_INVADER.Properties.Resources.flyingsaucer1;
            this.pictureBox_EnemySaucer.Location = new System.Drawing.Point(630, 100);
            this.pictureBox_EnemySaucer.Name = "pictureBox_EnemySaucer";
            this.pictureBox_EnemySaucer.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySaucer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySaucer.TabIndex = 3;
            this.pictureBox_EnemySaucer.TabStop = false;
            this.pictureBox_EnemySaucer.Visible = false;
            // 
            // pictureBox_EnemyBugs
            // 
            this.pictureBox_EnemyBugs.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyBugs.Enabled = false;
            this.pictureBox_EnemyBugs.Image = global::JCW_CS_INVADER.Properties.Resources.bug1;
            this.pictureBox_EnemyBugs.Location = new System.Drawing.Point(630, 50);
            this.pictureBox_EnemyBugs.Name = "pictureBox_EnemyBugs";
            this.pictureBox_EnemyBugs.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemyBugs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyBugs.TabIndex = 4;
            this.pictureBox_EnemyBugs.TabStop = false;
            this.pictureBox_EnemyBugs.Visible = false;
            // 
            // pictureBox_EnemySatellite
            // 
            this.pictureBox_EnemySatellite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySatellite.Enabled = false;
            this.pictureBox_EnemySatellite.Image = global::JCW_CS_INVADER.Properties.Resources.satellite1;
            this.pictureBox_EnemySatellite.Location = new System.Drawing.Point(630, 0);
            this.pictureBox_EnemySatellite.Name = "pictureBox_EnemySatellite";
            this.pictureBox_EnemySatellite.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySatellite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySatellite.TabIndex = 5;
            this.pictureBox_EnemySatellite.TabStop = false;
            this.pictureBox_EnemySatellite.Visible = false;
            // 
            // pictureBox_PlayerShot
            // 
            this.pictureBox_PlayerShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PlayerShot.Enabled = false;
            this.pictureBox_PlayerShot.Image = global::JCW_CS_INVADER.Properties.Resources.Shot;
            this.pictureBox_PlayerShot.Location = new System.Drawing.Point(790, 350);
            this.pictureBox_PlayerShot.Name = "pictureBox_PlayerShot";
            this.pictureBox_PlayerShot.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_PlayerShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerShot.TabIndex = 6;
            this.pictureBox_PlayerShot.TabStop = false;
            this.pictureBox_PlayerShot.Visible = false;
            // 
            // pictureBox_EnemyShot
            // 
            this.pictureBox_EnemyShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyShot.Enabled = false;
            this.pictureBox_EnemyShot.Image = global::JCW_CS_INVADER.Properties.Resources.Enemy_Shot;
            this.pictureBox_EnemyShot.Location = new System.Drawing.Point(788, 366);
            this.pictureBox_EnemyShot.Name = "pictureBox_EnemyShot";
            this.pictureBox_EnemyShot.Size = new System.Drawing.Size(15, 20);
            this.pictureBox_EnemyShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyShot.TabIndex = 7;
            this.pictureBox_EnemyShot.TabStop = false;
            this.pictureBox_EnemyShot.Visible = false;
            // 
            // pictureBox_TwinklingStar
            // 
            this.pictureBox_TwinklingStar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_TwinklingStar.Enabled = false;
            this.pictureBox_TwinklingStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TwinklingStar.Image")));
            this.pictureBox_TwinklingStar.Location = new System.Drawing.Point(788, 392);
            this.pictureBox_TwinklingStar.Name = "pictureBox_TwinklingStar";
            this.pictureBox_TwinklingStar.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_TwinklingStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TwinklingStar.TabIndex = 8;
            this.pictureBox_TwinklingStar.TabStop = false;
            this.pictureBox_TwinklingStar.Visible = false;
            // 
            // pictureBox_PlayerLife1
            // 
            this.pictureBox_PlayerLife1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PlayerLife1.Image = global::JCW_CS_INVADER.Properties.Resources.player;
            this.pictureBox_PlayerLife1.Location = new System.Drawing.Point(770, 21);
            this.pictureBox_PlayerLife1.Name = "pictureBox_PlayerLife1";
            this.pictureBox_PlayerLife1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_PlayerLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerLife1.TabIndex = 9;
            this.pictureBox_PlayerLife1.TabStop = false;
            // 
            // pictureBox_PlayerLife2
            // 
            this.pictureBox_PlayerLife2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PlayerLife2.Image = global::JCW_CS_INVADER.Properties.Resources.player;
            this.pictureBox_PlayerLife2.Location = new System.Drawing.Point(770, 63);
            this.pictureBox_PlayerLife2.Name = "pictureBox_PlayerLife2";
            this.pictureBox_PlayerLife2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_PlayerLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerLife2.TabIndex = 10;
            this.pictureBox_PlayerLife2.TabStop = false;
            // 
            // Label_ScoreTitle
            // 
            this.Label_ScoreTitle.AutoSize = true;
            this.Label_ScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.Label_ScoreTitle.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ScoreTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_ScoreTitle.Location = new System.Drawing.Point(12, 30);
            this.Label_ScoreTitle.Name = "Label_ScoreTitle";
            this.Label_ScoreTitle.Size = new System.Drawing.Size(79, 30);
            this.Label_ScoreTitle.TabIndex = 11;
            this.Label_ScoreTitle.Text = "SCORE";
            // 
            // Label_ScorePoint
            // 
            this.Label_ScorePoint.AutoSize = true;
            this.Label_ScorePoint.BackColor = System.Drawing.Color.Transparent;
            this.Label_ScorePoint.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ScorePoint.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_ScorePoint.Location = new System.Drawing.Point(21, 65);
            this.Label_ScorePoint.Name = "Label_ScorePoint";
            this.Label_ScorePoint.Size = new System.Drawing.Size(19, 21);
            this.Label_ScorePoint.TabIndex = 12;
            this.Label_ScorePoint.Text = "0";
            this.Label_ScorePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_GameOver
            // 
            this.Label_GameOver.AutoSize = true;
            this.Label_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.Label_GameOver.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_GameOver.ForeColor = System.Drawing.Color.Yellow;
            this.Label_GameOver.Location = new System.Drawing.Point(104, 102);
            this.Label_GameOver.Name = "Label_GameOver";
            this.Label_GameOver.Size = new System.Drawing.Size(625, 128);
            this.Label_GameOver.TabIndex = 13;
            this.Label_GameOver.Text = "GAME OVER";
            // 
            // Label_OverInfo
            // 
            this.Label_OverInfo.AutoSize = true;
            this.Label_OverInfo.BackColor = System.Drawing.Color.Transparent;
            this.Label_OverInfo.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_OverInfo.ForeColor = System.Drawing.Color.Red;
            this.Label_OverInfo.Location = new System.Drawing.Point(212, 284);
            this.Label_OverInfo.Name = "Label_OverInfo";
            this.Label_OverInfo.Size = new System.Drawing.Size(420, 30);
            this.Label_OverInfo.TabIndex = 14;
            this.Label_OverInfo.Text = "Press S to start a new game or Q to quit";
            // 
            // GameInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCW_CS_INVADER.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_OverInfo);
            this.Controls.Add(this.Label_GameOver);
            this.Controls.Add(this.Label_ScorePoint);
            this.Controls.Add(this.Label_ScoreTitle);
            this.Controls.Add(this.pictureBox_PlayerLife2);
            this.Controls.Add(this.pictureBox_PlayerLife1);
            this.Controls.Add(this.pictureBox_TwinklingStar);
            this.Controls.Add(this.pictureBox_EnemyShot);
            this.Controls.Add(this.pictureBox_PlayerShot);
            this.Controls.Add(this.pictureBox_EnemySatellite);
            this.Controls.Add(this.pictureBox_EnemyBugs);
            this.Controls.Add(this.pictureBox_EnemySaucer);
            this.Controls.Add(this.pictureBox_EnemySpaceship);
            this.Controls.Add(this.pictureBox_EnemyStar);
            this.Controls.Add(this.pictureBox_Player);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameInvaders";
            this.Text = "GameInvaders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySpaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySaucer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySatellite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TwinklingStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerLife2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox_Player;
        private System.Windows.Forms.PictureBox pictureBox_EnemyStar;
        private System.Windows.Forms.PictureBox pictureBox_EnemySpaceship;
        private System.Windows.Forms.PictureBox pictureBox_EnemySaucer;
        private System.Windows.Forms.PictureBox pictureBox_EnemyBugs;
        private System.Windows.Forms.PictureBox pictureBox_EnemySatellite;
        private System.Windows.Forms.PictureBox pictureBox_PlayerShot;
        private System.Windows.Forms.PictureBox pictureBox_EnemyShot;
        private System.Windows.Forms.PictureBox pictureBox_TwinklingStar;
        private System.Windows.Forms.PictureBox pictureBox_PlayerLife1;
        private System.Windows.Forms.PictureBox pictureBox_PlayerLife2;
        private System.Windows.Forms.Label Label_ScoreTitle;
        private System.Windows.Forms.Label Label_ScorePoint;
        private System.Windows.Forms.Label Label_GameOver;
        private System.Windows.Forms.Label Label_OverInfo;
    }
}

