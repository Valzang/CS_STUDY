
namespace JCW_CS_INVADER
{
    partial class Invader
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySpaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySaucer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySatellite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyShot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Player
            // 
            this.pictureBox_Player.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Player.Image = global::JCW_CS_INVADER.Properties.Resources.player;
            this.pictureBox_Player.Location = new System.Drawing.Point(385, 378);
            this.pictureBox_Player.Name = "pictureBox_Player";
            this.pictureBox_Player.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Player.TabIndex = 0;
            this.pictureBox_Player.TabStop = false;
            // 
            // pictureBox_EnemyStar
            // 
            this.pictureBox_EnemyStar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyStar.Image = global::JCW_CS_INVADER.Properties.Resources.star1;
            this.pictureBox_EnemyStar.Location = new System.Drawing.Point(385, 210);
            this.pictureBox_EnemyStar.Name = "pictureBox_EnemyStar";
            this.pictureBox_EnemyStar.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemyStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyStar.TabIndex = 1;
            this.pictureBox_EnemyStar.TabStop = false;
            // 
            // pictureBox_EnemySpaceship
            // 
            this.pictureBox_EnemySpaceship.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySpaceship.Image = global::JCW_CS_INVADER.Properties.Resources.spaceship1;
            this.pictureBox_EnemySpaceship.Location = new System.Drawing.Point(430, 210);
            this.pictureBox_EnemySpaceship.Name = "pictureBox_EnemySpaceship";
            this.pictureBox_EnemySpaceship.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySpaceship.TabIndex = 2;
            this.pictureBox_EnemySpaceship.TabStop = false;
            // 
            // pictureBox_EnemySaucer
            // 
            this.pictureBox_EnemySaucer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySaucer.Image = global::JCW_CS_INVADER.Properties.Resources.flyingsaucer1;
            this.pictureBox_EnemySaucer.Location = new System.Drawing.Point(476, 210);
            this.pictureBox_EnemySaucer.Name = "pictureBox_EnemySaucer";
            this.pictureBox_EnemySaucer.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySaucer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySaucer.TabIndex = 3;
            this.pictureBox_EnemySaucer.TabStop = false;
            // 
            // pictureBox_EnemyBugs
            // 
            this.pictureBox_EnemyBugs.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyBugs.Image = global::JCW_CS_INVADER.Properties.Resources.bug1;
            this.pictureBox_EnemyBugs.Location = new System.Drawing.Point(530, 210);
            this.pictureBox_EnemyBugs.Name = "pictureBox_EnemyBugs";
            this.pictureBox_EnemyBugs.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemyBugs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyBugs.TabIndex = 4;
            this.pictureBox_EnemyBugs.TabStop = false;
            // 
            // pictureBox_EnemySatellite
            // 
            this.pictureBox_EnemySatellite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemySatellite.Image = global::JCW_CS_INVADER.Properties.Resources.satellite1;
            this.pictureBox_EnemySatellite.Location = new System.Drawing.Point(577, 210);
            this.pictureBox_EnemySatellite.Name = "pictureBox_EnemySatellite";
            this.pictureBox_EnemySatellite.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_EnemySatellite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemySatellite.TabIndex = 5;
            this.pictureBox_EnemySatellite.TabStop = false;
            // 
            // pictureBox_PlayerShot
            // 
            this.pictureBox_PlayerShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PlayerShot.Image = global::JCW_CS_INVADER.Properties.Resources.Shot;
            this.pictureBox_PlayerShot.Location = new System.Drawing.Point(395, 362);
            this.pictureBox_PlayerShot.Name = "pictureBox_PlayerShot";
            this.pictureBox_PlayerShot.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_PlayerShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerShot.TabIndex = 6;
            this.pictureBox_PlayerShot.TabStop = false;
            // 
            // pictureBox_EnemyShot
            // 
            this.pictureBox_EnemyShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_EnemyShot.Image = global::JCW_CS_INVADER.Properties.Resources.Enemy_Shot;
            this.pictureBox_EnemyShot.Location = new System.Drawing.Point(395, 247);
            this.pictureBox_EnemyShot.Name = "pictureBox_EnemyShot";
            this.pictureBox_EnemyShot.Size = new System.Drawing.Size(15, 20);
            this.pictureBox_EnemyShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EnemyShot.TabIndex = 7;
            this.pictureBox_EnemyShot.TabStop = false;
            // 
            // Invader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCW_CS_INVADER.Properties.Resources.space;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Invader";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Invader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySpaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySaucer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemySatellite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyShot)).EndInit();
            this.ResumeLayout(false);

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
    }
}

