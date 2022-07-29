
namespace JCW_CS_THEQUEST
{
    partial class Form1
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
            this.groupBox_Move = new System.Windows.Forms.GroupBox();
            this.button_Move_Down = new System.Windows.Forms.Button();
            this.button_Move_Right = new System.Windows.Forms.Button();
            this.button_Move_Left = new System.Windows.Forms.Button();
            this.button_Move_Up = new System.Windows.Forms.Button();
            this.groupBox_Attack = new System.Windows.Forms.GroupBox();
            this.button_Attack_Down = new System.Windows.Forms.Button();
            this.button_Attack_Right = new System.Windows.Forms.Button();
            this.button_Attack_Up = new System.Windows.Forms.Button();
            this.button_Attack_Left = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Character_Point = new System.Windows.Forms.TableLayoutPanel();
            this.label_Ghoul = new System.Windows.Forms.Label();
            this.label_PlayerHitPoints = new System.Windows.Forms.Label();
            this.label_BatHitPoints = new System.Windows.Forms.Label();
            this.label_GhostHitPoints = new System.Windows.Forms.Label();
            this.label_GhoulHitPoints = new System.Windows.Forms.Label();
            this.label_Ghost = new System.Windows.Forms.Label();
            this.label_Bat = new System.Windows.Forms.Label();
            this.label_Player = new System.Windows.Forms.Label();
            this.pictureBox_Shield = new System.Windows.Forms.PictureBox();
            this.pictureBox_Quiver = new System.Windows.Forms.PictureBox();
            this.pictureBox_Wizard = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ghoul = new System.Windows.Forms.PictureBox();
            this.pictureBox_Mace = new System.Windows.Forms.PictureBox();
            this.pictureBox_Potion_Red = new System.Windows.Forms.PictureBox();
            this.pictureBox_Potion_Blu = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ghost = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bomb = new System.Windows.Forms.PictureBox();
            this.pictureBox_Battleaxe = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sword = new System.Windows.Forms.PictureBox();
            this.pictureBox_Player = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bat = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Sword = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Potion_Blu = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Bow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Potion_Red = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Mace = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Battleaxe = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Quiver = new System.Windows.Forms.PictureBox();
            this.pictureBox_Equip_Shield = new System.Windows.Forms.PictureBox();
            this.groupBox_Move.SuspendLayout();
            this.groupBox_Attack.SuspendLayout();
            this.Character_Point.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Quiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Potion_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Potion_Blu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Battleaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Potion_Blu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Potion_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Battleaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Quiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Shield)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Move
            // 
            this.groupBox_Move.Controls.Add(this.button_Move_Down);
            this.groupBox_Move.Controls.Add(this.button_Move_Right);
            this.groupBox_Move.Controls.Add(this.button_Move_Left);
            this.groupBox_Move.Controls.Add(this.button_Move_Up);
            this.groupBox_Move.Location = new System.Drawing.Point(602, 0);
            this.groupBox_Move.Name = "groupBox_Move";
            this.groupBox_Move.Size = new System.Drawing.Size(196, 118);
            this.groupBox_Move.TabIndex = 1;
            this.groupBox_Move.TabStop = false;
            this.groupBox_Move.Text = "Move";
            // 
            // button_Move_Down
            // 
            this.button_Move_Down.Location = new System.Drawing.Point(65, 81);
            this.button_Move_Down.Name = "button_Move_Down";
            this.button_Move_Down.Size = new System.Drawing.Size(75, 23);
            this.button_Move_Down.TabIndex = 3;
            this.button_Move_Down.Text = "Down";
            this.button_Move_Down.UseVisualStyleBackColor = true;
            this.button_Move_Down.Click += new System.EventHandler(this.button_Move_Down_Click);
            // 
            // button_Move_Right
            // 
            this.button_Move_Right.Location = new System.Drawing.Point(117, 52);
            this.button_Move_Right.Name = "button_Move_Right";
            this.button_Move_Right.Size = new System.Drawing.Size(75, 23);
            this.button_Move_Right.TabIndex = 2;
            this.button_Move_Right.Text = "Right";
            this.button_Move_Right.UseVisualStyleBackColor = true;
            this.button_Move_Right.Click += new System.EventHandler(this.button_Move_Right_Click);
            // 
            // button_Move_Left
            // 
            this.button_Move_Left.Location = new System.Drawing.Point(6, 52);
            this.button_Move_Left.Name = "button_Move_Left";
            this.button_Move_Left.Size = new System.Drawing.Size(75, 23);
            this.button_Move_Left.TabIndex = 1;
            this.button_Move_Left.Text = "Left";
            this.button_Move_Left.UseVisualStyleBackColor = true;
            this.button_Move_Left.Click += new System.EventHandler(this.button_Move_Left_Click);
            // 
            // button_Move_Up
            // 
            this.button_Move_Up.Location = new System.Drawing.Point(65, 23);
            this.button_Move_Up.Name = "button_Move_Up";
            this.button_Move_Up.Size = new System.Drawing.Size(75, 23);
            this.button_Move_Up.TabIndex = 0;
            this.button_Move_Up.Text = "Up";
            this.button_Move_Up.UseVisualStyleBackColor = true;
            this.button_Move_Up.Click += new System.EventHandler(this.button_Move_Up_Click);
            // 
            // groupBox_Attack
            // 
            this.groupBox_Attack.Controls.Add(this.button_Attack_Down);
            this.groupBox_Attack.Controls.Add(this.button_Attack_Right);
            this.groupBox_Attack.Controls.Add(this.button_Attack_Up);
            this.groupBox_Attack.Controls.Add(this.button_Attack_Left);
            this.groupBox_Attack.Location = new System.Drawing.Point(602, 124);
            this.groupBox_Attack.Name = "groupBox_Attack";
            this.groupBox_Attack.Size = new System.Drawing.Size(196, 118);
            this.groupBox_Attack.TabIndex = 2;
            this.groupBox_Attack.TabStop = false;
            this.groupBox_Attack.Text = "Attack";
            // 
            // button_Attack_Down
            // 
            this.button_Attack_Down.Location = new System.Drawing.Point(65, 81);
            this.button_Attack_Down.Name = "button_Attack_Down";
            this.button_Attack_Down.Size = new System.Drawing.Size(75, 23);
            this.button_Attack_Down.TabIndex = 7;
            this.button_Attack_Down.Text = "Down";
            this.button_Attack_Down.UseVisualStyleBackColor = true;
            this.button_Attack_Down.Click += new System.EventHandler(this.button_Attack_Down_Click);
            // 
            // button_Attack_Right
            // 
            this.button_Attack_Right.Location = new System.Drawing.Point(117, 52);
            this.button_Attack_Right.Name = "button_Attack_Right";
            this.button_Attack_Right.Size = new System.Drawing.Size(75, 23);
            this.button_Attack_Right.TabIndex = 6;
            this.button_Attack_Right.Text = "Right";
            this.button_Attack_Right.UseVisualStyleBackColor = true;
            this.button_Attack_Right.Click += new System.EventHandler(this.button_Attack_Right_Click);
            // 
            // button_Attack_Up
            // 
            this.button_Attack_Up.Location = new System.Drawing.Point(65, 23);
            this.button_Attack_Up.Name = "button_Attack_Up";
            this.button_Attack_Up.Size = new System.Drawing.Size(75, 23);
            this.button_Attack_Up.TabIndex = 4;
            this.button_Attack_Up.Text = "Up";
            this.button_Attack_Up.UseVisualStyleBackColor = true;
            this.button_Attack_Up.Click += new System.EventHandler(this.button_Attack_Up_Click);
            // 
            // button_Attack_Left
            // 
            this.button_Attack_Left.Location = new System.Drawing.Point(6, 52);
            this.button_Attack_Left.Name = "button_Attack_Left";
            this.button_Attack_Left.Size = new System.Drawing.Size(75, 23);
            this.button_Attack_Left.TabIndex = 5;
            this.button_Attack_Left.Text = "Left";
            this.button_Attack_Left.UseVisualStyleBackColor = true;
            this.button_Attack_Left.Click += new System.EventHandler(this.button_Attack_Left_Click);
            // 
            // Character_Point
            // 
            this.Character_Point.AutoSize = true;
            this.Character_Point.ColumnCount = 2;
            this.Character_Point.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Character_Point.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Character_Point.Controls.Add(this.label_Ghoul, 0, 3);
            this.Character_Point.Controls.Add(this.label_PlayerHitPoints, 1, 0);
            this.Character_Point.Controls.Add(this.label_BatHitPoints, 1, 1);
            this.Character_Point.Controls.Add(this.label_GhostHitPoints, 1, 2);
            this.Character_Point.Controls.Add(this.label_GhoulHitPoints, 1, 3);
            this.Character_Point.Controls.Add(this.label_Ghost, 0, 2);
            this.Character_Point.Controls.Add(this.label_Bat, 0, 1);
            this.Character_Point.Controls.Add(this.label_Player, 0, 0);
            this.Character_Point.Location = new System.Drawing.Point(602, 248);
            this.Character_Point.Name = "Character_Point";
            this.Character_Point.RowCount = 4;
            this.Character_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Character_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Character_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Character_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Character_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Character_Point.Size = new System.Drawing.Size(196, 149);
            this.Character_Point.TabIndex = 3;
            // 
            // label_Ghoul
            // 
            this.label_Ghoul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Ghoul.AutoSize = true;
            this.label_Ghoul.Location = new System.Drawing.Point(30, 124);
            this.label_Ghoul.Name = "label_Ghoul";
            this.label_Ghoul.Size = new System.Drawing.Size(38, 12);
            this.label_Ghoul.TabIndex = 19;
            this.label_Ghoul.Text = "Ghoul";
            // 
            // label_PlayerHitPoints
            // 
            this.label_PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PlayerHitPoints.AutoSize = true;
            this.label_PlayerHitPoints.Location = new System.Drawing.Point(102, 12);
            this.label_PlayerHitPoints.Name = "label_PlayerHitPoints";
            this.label_PlayerHitPoints.Size = new System.Drawing.Size(90, 12);
            this.label_PlayerHitPoints.TabIndex = 20;
            this.label_PlayerHitPoints.Text = "PlayerHitPoints";
            // 
            // label_BatHitPoints
            // 
            this.label_BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_BatHitPoints.AutoSize = true;
            this.label_BatHitPoints.Location = new System.Drawing.Point(111, 49);
            this.label_BatHitPoints.Name = "label_BatHitPoints";
            this.label_BatHitPoints.Size = new System.Drawing.Size(72, 12);
            this.label_BatHitPoints.TabIndex = 21;
            this.label_BatHitPoints.Text = "BatHitPoints";
            // 
            // label_GhostHitPoints
            // 
            this.label_GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GhostHitPoints.AutoSize = true;
            this.label_GhostHitPoints.Location = new System.Drawing.Point(103, 86);
            this.label_GhostHitPoints.Name = "label_GhostHitPoints";
            this.label_GhostHitPoints.Size = new System.Drawing.Size(87, 12);
            this.label_GhostHitPoints.TabIndex = 22;
            this.label_GhostHitPoints.Text = "GhostHitPoints";
            // 
            // label_GhoulHitPoints
            // 
            this.label_GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_GhoulHitPoints.AutoSize = true;
            this.label_GhoulHitPoints.Location = new System.Drawing.Point(103, 124);
            this.label_GhoulHitPoints.Name = "label_GhoulHitPoints";
            this.label_GhoulHitPoints.Size = new System.Drawing.Size(87, 12);
            this.label_GhoulHitPoints.TabIndex = 23;
            this.label_GhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // label_Ghost
            // 
            this.label_Ghost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Ghost.AutoSize = true;
            this.label_Ghost.Location = new System.Drawing.Point(30, 86);
            this.label_Ghost.Name = "label_Ghost";
            this.label_Ghost.Size = new System.Drawing.Size(38, 12);
            this.label_Ghost.TabIndex = 18;
            this.label_Ghost.Text = "Ghost";
            // 
            // label_Bat
            // 
            this.label_Bat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Bat.AutoSize = true;
            this.label_Bat.Location = new System.Drawing.Point(37, 49);
            this.label_Bat.Name = "label_Bat";
            this.label_Bat.Size = new System.Drawing.Size(23, 12);
            this.label_Bat.TabIndex = 1;
            this.label_Bat.Text = "Bat";
            // 
            // label_Player
            // 
            this.label_Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Player.AutoSize = true;
            this.label_Player.Location = new System.Drawing.Point(28, 12);
            this.label_Player.Name = "label_Player";
            this.label_Player.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Player.Size = new System.Drawing.Size(41, 12);
            this.label_Player.TabIndex = 0;
            this.label_Player.Text = "Player";
            // 
            // pictureBox_Shield
            // 
            this.pictureBox_Shield.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Shield.Image = global::JCW_CS_THEQUEST.Properties.Resources.shield;
            this.pictureBox_Shield.Location = new System.Drawing.Point(436, 101);
            this.pictureBox_Shield.Name = "pictureBox_Shield";
            this.pictureBox_Shield.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Shield.TabIndex = 17;
            this.pictureBox_Shield.TabStop = false;
            this.pictureBox_Shield.Visible = false;
            // 
            // pictureBox_Quiver
            // 
            this.pictureBox_Quiver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Quiver.Image = global::JCW_CS_THEQUEST.Properties.Resources.quiver;
            this.pictureBox_Quiver.Location = new System.Drawing.Point(472, 101);
            this.pictureBox_Quiver.Name = "pictureBox_Quiver";
            this.pictureBox_Quiver.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Quiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Quiver.TabIndex = 16;
            this.pictureBox_Quiver.TabStop = false;
            this.pictureBox_Quiver.Visible = false;
            // 
            // pictureBox_Wizard
            // 
            this.pictureBox_Wizard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Wizard.Image = global::JCW_CS_THEQUEST.Properties.Resources.wizard;
            this.pictureBox_Wizard.Location = new System.Drawing.Point(472, 65);
            this.pictureBox_Wizard.Name = "pictureBox_Wizard";
            this.pictureBox_Wizard.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Wizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Wizard.TabIndex = 15;
            this.pictureBox_Wizard.TabStop = false;
            this.pictureBox_Wizard.Visible = false;
            // 
            // pictureBox_Ghoul
            // 
            this.pictureBox_Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Ghoul.Image = global::JCW_CS_THEQUEST.Properties.Resources.ghoul;
            this.pictureBox_Ghoul.Location = new System.Drawing.Point(436, 65);
            this.pictureBox_Ghoul.Name = "pictureBox_Ghoul";
            this.pictureBox_Ghoul.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ghoul.TabIndex = 14;
            this.pictureBox_Ghoul.TabStop = false;
            this.pictureBox_Ghoul.Visible = false;
            // 
            // pictureBox_Mace
            // 
            this.pictureBox_Mace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Mace.Image = global::JCW_CS_THEQUEST.Properties.Resources.mace;
            this.pictureBox_Mace.Location = new System.Drawing.Point(400, 65);
            this.pictureBox_Mace.Name = "pictureBox_Mace";
            this.pictureBox_Mace.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Mace.TabIndex = 13;
            this.pictureBox_Mace.TabStop = false;
            this.pictureBox_Mace.Visible = false;
            // 
            // pictureBox_Potion_Red
            // 
            this.pictureBox_Potion_Red.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Potion_Red.Image = global::JCW_CS_THEQUEST.Properties.Resources.potion_red;
            this.pictureBox_Potion_Red.Location = new System.Drawing.Point(364, 65);
            this.pictureBox_Potion_Red.Name = "pictureBox_Potion_Red";
            this.pictureBox_Potion_Red.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Potion_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Potion_Red.TabIndex = 12;
            this.pictureBox_Potion_Red.TabStop = false;
            this.pictureBox_Potion_Red.Visible = false;
            // 
            // pictureBox_Potion_Blu
            // 
            this.pictureBox_Potion_Blu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Potion_Blu.Image = global::JCW_CS_THEQUEST.Properties.Resources.potion_blue;
            this.pictureBox_Potion_Blu.Location = new System.Drawing.Point(328, 65);
            this.pictureBox_Potion_Blu.Name = "pictureBox_Potion_Blu";
            this.pictureBox_Potion_Blu.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Potion_Blu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Potion_Blu.TabIndex = 11;
            this.pictureBox_Potion_Blu.TabStop = false;
            this.pictureBox_Potion_Blu.Visible = false;
            // 
            // pictureBox_Bow
            // 
            this.pictureBox_Bow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bow.Image = global::JCW_CS_THEQUEST.Properties.Resources.bow;
            this.pictureBox_Bow.Location = new System.Drawing.Point(292, 65);
            this.pictureBox_Bow.Name = "pictureBox_Bow";
            this.pictureBox_Bow.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bow.TabIndex = 10;
            this.pictureBox_Bow.TabStop = false;
            this.pictureBox_Bow.Visible = false;
            // 
            // pictureBox_Ghost
            // 
            this.pictureBox_Ghost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Ghost.Image = global::JCW_CS_THEQUEST.Properties.Resources.ghost;
            this.pictureBox_Ghost.Location = new System.Drawing.Point(256, 65);
            this.pictureBox_Ghost.Name = "pictureBox_Ghost";
            this.pictureBox_Ghost.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ghost.TabIndex = 9;
            this.pictureBox_Ghost.TabStop = false;
            this.pictureBox_Ghost.Visible = false;
            // 
            // pictureBox_Bomb
            // 
            this.pictureBox_Bomb.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bomb.Image = global::JCW_CS_THEQUEST.Properties.Resources.bomb;
            this.pictureBox_Bomb.Location = new System.Drawing.Point(220, 65);
            this.pictureBox_Bomb.Name = "pictureBox_Bomb";
            this.pictureBox_Bomb.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bomb.TabIndex = 8;
            this.pictureBox_Bomb.TabStop = false;
            this.pictureBox_Bomb.Visible = false;
            // 
            // pictureBox_Battleaxe
            // 
            this.pictureBox_Battleaxe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Battleaxe.Image = global::JCW_CS_THEQUEST.Properties.Resources.battleaxe;
            this.pictureBox_Battleaxe.Location = new System.Drawing.Point(184, 65);
            this.pictureBox_Battleaxe.Name = "pictureBox_Battleaxe";
            this.pictureBox_Battleaxe.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Battleaxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Battleaxe.TabIndex = 7;
            this.pictureBox_Battleaxe.TabStop = false;
            this.pictureBox_Battleaxe.Visible = false;
            // 
            // pictureBox_Sword
            // 
            this.pictureBox_Sword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Sword.Image = global::JCW_CS_THEQUEST.Properties.Resources.sword;
            this.pictureBox_Sword.Location = new System.Drawing.Point(148, 65);
            this.pictureBox_Sword.Name = "pictureBox_Sword";
            this.pictureBox_Sword.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sword.TabIndex = 6;
            this.pictureBox_Sword.TabStop = false;
            this.pictureBox_Sword.Visible = false;
            // 
            // pictureBox_Player
            // 
            this.pictureBox_Player.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Player.Image = global::JCW_CS_THEQUEST.Properties.Resources.player;
            this.pictureBox_Player.Location = new System.Drawing.Point(112, 65);
            this.pictureBox_Player.Name = "pictureBox_Player";
            this.pictureBox_Player.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Player.TabIndex = 5;
            this.pictureBox_Player.TabStop = false;
            this.pictureBox_Player.Visible = false;
            // 
            // pictureBox_Bat
            // 
            this.pictureBox_Bat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Bat.Image = global::JCW_CS_THEQUEST.Properties.Resources.bat;
            this.pictureBox_Bat.Location = new System.Drawing.Point(76, 65);
            this.pictureBox_Bat.Name = "pictureBox_Bat";
            this.pictureBox_Bat.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bat.TabIndex = 4;
            this.pictureBox_Bat.TabStop = false;
            this.pictureBox_Bat.Visible = false;
            // 
            // pictureBox_Equip_Sword
            // 
            this.pictureBox_Equip_Sword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Sword.Image = global::JCW_CS_THEQUEST.Properties.Resources.sword;
            this.pictureBox_Equip_Sword.Location = new System.Drawing.Point(76, 317);
            this.pictureBox_Equip_Sword.Name = "pictureBox_Equip_Sword";
            this.pictureBox_Equip_Sword.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Sword.TabIndex = 19;
            this.pictureBox_Equip_Sword.TabStop = false;
            // 
            // pictureBox_Equip_Potion_Blu
            // 
            this.pictureBox_Equip_Potion_Blu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Potion_Blu.Image = global::JCW_CS_THEQUEST.Properties.Resources.potion_blue;
            this.pictureBox_Equip_Potion_Blu.Location = new System.Drawing.Point(468, 317);
            this.pictureBox_Equip_Potion_Blu.Name = "pictureBox_Equip_Potion_Blu";
            this.pictureBox_Equip_Potion_Blu.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Potion_Blu.TabIndex = 20;
            this.pictureBox_Equip_Potion_Blu.TabStop = false;
            // 
            // pictureBox_Equip_Bow
            // 
            this.pictureBox_Equip_Bow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Bow.Image = global::JCW_CS_THEQUEST.Properties.Resources.bow;
            this.pictureBox_Equip_Bow.Location = new System.Drawing.Point(188, 317);
            this.pictureBox_Equip_Bow.Name = "pictureBox_Equip_Bow";
            this.pictureBox_Equip_Bow.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Bow.TabIndex = 21;
            this.pictureBox_Equip_Bow.TabStop = false;
            // 
            // pictureBox_Equip_Potion_Red
            // 
            this.pictureBox_Equip_Potion_Red.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Potion_Red.Image = global::JCW_CS_THEQUEST.Properties.Resources.potion_red;
            this.pictureBox_Equip_Potion_Red.Location = new System.Drawing.Point(412, 317);
            this.pictureBox_Equip_Potion_Red.Name = "pictureBox_Equip_Potion_Red";
            this.pictureBox_Equip_Potion_Red.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Potion_Red.TabIndex = 22;
            this.pictureBox_Equip_Potion_Red.TabStop = false;
            // 
            // pictureBox_Equip_Mace
            // 
            this.pictureBox_Equip_Mace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Mace.Image = global::JCW_CS_THEQUEST.Properties.Resources.mace;
            this.pictureBox_Equip_Mace.Location = new System.Drawing.Point(300, 317);
            this.pictureBox_Equip_Mace.Name = "pictureBox_Equip_Mace";
            this.pictureBox_Equip_Mace.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Mace.TabIndex = 23;
            this.pictureBox_Equip_Mace.TabStop = false;
            // 
            // pictureBox_Equip_Battleaxe
            // 
            this.pictureBox_Equip_Battleaxe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Battleaxe.Image = global::JCW_CS_THEQUEST.Properties.Resources.battleaxe;
            this.pictureBox_Equip_Battleaxe.Location = new System.Drawing.Point(356, 317);
            this.pictureBox_Equip_Battleaxe.Name = "pictureBox_Equip_Battleaxe";
            this.pictureBox_Equip_Battleaxe.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Battleaxe.TabIndex = 24;
            this.pictureBox_Equip_Battleaxe.TabStop = false;
            // 
            // pictureBox_Equip_Quiver
            // 
            this.pictureBox_Equip_Quiver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Quiver.Image = global::JCW_CS_THEQUEST.Properties.Resources.quiver;
            this.pictureBox_Equip_Quiver.Location = new System.Drawing.Point(244, 317);
            this.pictureBox_Equip_Quiver.Name = "pictureBox_Equip_Quiver";
            this.pictureBox_Equip_Quiver.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Quiver.TabIndex = 25;
            this.pictureBox_Equip_Quiver.TabStop = false;
            // 
            // pictureBox_Equip_Shield
            // 
            this.pictureBox_Equip_Shield.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Equip_Shield.Image = global::JCW_CS_THEQUEST.Properties.Resources.shield;
            this.pictureBox_Equip_Shield.Location = new System.Drawing.Point(132, 317);
            this.pictureBox_Equip_Shield.Name = "pictureBox_Equip_Shield";
            this.pictureBox_Equip_Shield.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Equip_Shield.TabIndex = 26;
            this.pictureBox_Equip_Shield.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCW_CS_THEQUEST.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.pictureBox_Equip_Shield);
            this.Controls.Add(this.pictureBox_Equip_Quiver);
            this.Controls.Add(this.pictureBox_Equip_Battleaxe);
            this.Controls.Add(this.pictureBox_Equip_Mace);
            this.Controls.Add(this.pictureBox_Equip_Potion_Red);
            this.Controls.Add(this.pictureBox_Equip_Bow);
            this.Controls.Add(this.pictureBox_Equip_Potion_Blu);
            this.Controls.Add(this.pictureBox_Equip_Sword);
            this.Controls.Add(this.pictureBox_Player);
            this.Controls.Add(this.pictureBox_Wizard);
            this.Controls.Add(this.pictureBox_Ghoul);
            this.Controls.Add(this.pictureBox_Potion_Red);
            this.Controls.Add(this.pictureBox_Potion_Blu);
            this.Controls.Add(this.pictureBox_Ghost);
            this.Controls.Add(this.pictureBox_Bomb);
            this.Controls.Add(this.pictureBox_Bat);
            this.Controls.Add(this.Character_Point);
            this.Controls.Add(this.groupBox_Attack);
            this.Controls.Add(this.groupBox_Move);
            this.Controls.Add(this.pictureBox_Shield);
            this.Controls.Add(this.pictureBox_Quiver);
            this.Controls.Add(this.pictureBox_Mace);
            this.Controls.Add(this.pictureBox_Bow);
            this.Controls.Add(this.pictureBox_Battleaxe);
            this.Controls.Add(this.pictureBox_Sword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Move.ResumeLayout(false);
            this.groupBox_Attack.ResumeLayout(false);
            this.Character_Point.ResumeLayout(false);
            this.Character_Point.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Quiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Potion_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Potion_Blu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Battleaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Potion_Blu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Potion_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Battleaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Quiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equip_Shield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Move;
        private System.Windows.Forms.Button button_Move_Down;
        private System.Windows.Forms.Button button_Move_Right;
        private System.Windows.Forms.Button button_Move_Left;
        private System.Windows.Forms.Button button_Move_Up;
        private System.Windows.Forms.GroupBox groupBox_Attack;
        private System.Windows.Forms.Button button_Attack_Down;
        private System.Windows.Forms.Button button_Attack_Right;
        private System.Windows.Forms.Button button_Attack_Up;
        private System.Windows.Forms.Button button_Attack_Left;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel Character_Point;
        private System.Windows.Forms.PictureBox pictureBox_Bat;
        private System.Windows.Forms.PictureBox pictureBox_Player;
        private System.Windows.Forms.PictureBox pictureBox_Sword;
        private System.Windows.Forms.PictureBox pictureBox_Battleaxe;
        private System.Windows.Forms.PictureBox pictureBox_Bomb;
        private System.Windows.Forms.PictureBox pictureBox_Ghost;
        private System.Windows.Forms.PictureBox pictureBox_Bow;
        private System.Windows.Forms.PictureBox pictureBox_Potion_Blu;
        private System.Windows.Forms.PictureBox pictureBox_Potion_Red;
        private System.Windows.Forms.PictureBox pictureBox_Mace;
        private System.Windows.Forms.PictureBox pictureBox_Ghoul;
        private System.Windows.Forms.PictureBox pictureBox_Wizard;
        private System.Windows.Forms.PictureBox pictureBox_Quiver;
        private System.Windows.Forms.PictureBox pictureBox_Shield;
        private System.Windows.Forms.Label label_Ghoul;
        private System.Windows.Forms.Label label_PlayerHitPoints;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.Label label_Bat;
        private System.Windows.Forms.Label label_Ghost;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Sword;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Potion_Blu;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Bow;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Potion_Red;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Mace;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Battleaxe;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Quiver;
        private System.Windows.Forms.PictureBox pictureBox_Equip_Shield;
        private System.Windows.Forms.Label label_BatHitPoints;
        private System.Windows.Forms.Label label_GhostHitPoints;
        private System.Windows.Forms.Label label_GhoulHitPoints;
    }
}

