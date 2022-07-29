
namespace JCW_CS_WINDOWSFORM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BettingDogNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Minimum_Bet_Label = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Betting_Button = new System.Windows.Forms.Button();
            this.Race_Button = new System.Windows.Forms.Button();
            this.Al_label = new System.Windows.Forms.Label();
            this.Bob_label = new System.Windows.Forms.Label();
            this.Joe_label = new System.Windows.Forms.Label();
            this.Al_radioButton = new System.Windows.Forms.RadioButton();
            this.Bob_radioButton = new System.Windows.Forms.RadioButton();
            this.Joe_radioButton = new System.Windows.Forms.RadioButton();
            this.BettingMoney = new System.Windows.Forms.NumericUpDown();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Background_Race = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BettingDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_Race)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BettingDogNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Minimum_Bet_Label);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.Betting_Button);
            this.groupBox1.Controls.Add(this.Race_Button);
            this.groupBox1.Controls.Add(this.Al_label);
            this.groupBox1.Controls.Add(this.Bob_label);
            this.groupBox1.Controls.Add(this.Joe_label);
            this.groupBox1.Controls.Add(this.Al_radioButton);
            this.groupBox1.Controls.Add(this.Bob_radioButton);
            this.groupBox1.Controls.Add(this.Joe_radioButton);
            this.groupBox1.Controls.Add(this.BettingMoney);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // BettingDogNumber
            // 
            this.BettingDogNumber.Location = new System.Drawing.Point(343, 127);
            this.BettingDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BettingDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingDogNumber.Name = "BettingDogNumber";
            this.BettingDogNumber.Size = new System.Drawing.Size(88, 21);
            this.BettingDogNumber.TabIndex = 14;
            this.BettingDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(187, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "bucks on dog number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(512, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bets";
            // 
            // Minimum_Bet_Label
            // 
            this.Minimum_Bet_Label.AutoSize = true;
            this.Minimum_Bet_Label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.Minimum_Bet_Label.Location = new System.Drawing.Point(6, 19);
            this.Minimum_Bet_Label.Name = "Minimum_Bet_Label";
            this.Minimum_Bet_Label.Size = new System.Drawing.Size(194, 16);
            this.Minimum_Bet_Label.TabIndex = 11;
            this.Minimum_Bet_Label.Text = "Minimum Bet : 5 Bucks";
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(6, 127);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(34, 20);
            this.label_Name.TabIndex = 10;
            this.label_Name.Text = "Joe";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Betting_Button
            // 
            this.Betting_Button.Location = new System.Drawing.Point(41, 126);
            this.Betting_Button.Name = "Betting_Button";
            this.Betting_Button.Size = new System.Drawing.Size(75, 23);
            this.Betting_Button.TabIndex = 9;
            this.Betting_Button.Text = "Bets";
            this.Betting_Button.UseVisualStyleBackColor = true;
            this.Betting_Button.Click += new System.EventHandler(this.Bet_Click);
            // 
            // Race_Button
            // 
            this.Race_Button.Location = new System.Drawing.Point(632, 128);
            this.Race_Button.Name = "Race_Button";
            this.Race_Button.Size = new System.Drawing.Size(75, 23);
            this.Race_Button.TabIndex = 8;
            this.Race_Button.Text = "Race!";
            this.Race_Button.UseVisualStyleBackColor = true;
            this.Race_Button.Click += new System.EventHandler(this.Race_Button_Click);
            // 
            // Al_label
            // 
            this.Al_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Al_label.Location = new System.Drawing.Point(515, 100);
            this.Al_label.Name = "Al_label";
            this.Al_label.Size = new System.Drawing.Size(192, 20);
            this.Al_label.TabIndex = 7;
            this.Al_label.Text = "Al\'s Bet";
            // 
            // Bob_label
            // 
            this.Bob_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bob_label.Location = new System.Drawing.Point(515, 70);
            this.Bob_label.Name = "Bob_label";
            this.Bob_label.Size = new System.Drawing.Size(192, 20);
            this.Bob_label.TabIndex = 6;
            this.Bob_label.Text = "Bob\'s Bet";
            // 
            // Joe_label
            // 
            this.Joe_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Joe_label.Location = new System.Drawing.Point(515, 42);
            this.Joe_label.Name = "Joe_label";
            this.Joe_label.Size = new System.Drawing.Size(192, 20);
            this.Joe_label.TabIndex = 5;
            this.Joe_label.Text = "Joe\'s Bet";
            // 
            // Al_radioButton
            // 
            this.Al_radioButton.AutoSize = true;
            this.Al_radioButton.Location = new System.Drawing.Point(6, 86);
            this.Al_radioButton.Name = "Al_radioButton";
            this.Al_radioButton.Size = new System.Drawing.Size(34, 16);
            this.Al_radioButton.TabIndex = 3;
            this.Al_radioButton.TabStop = true;
            this.Al_radioButton.Text = "Al";
            this.Al_radioButton.UseVisualStyleBackColor = true;
            this.Al_radioButton.CheckedChanged += new System.EventHandler(this.AlButton_CheckedChanged);
            // 
            // Bob_radioButton
            // 
            this.Bob_radioButton.AutoSize = true;
            this.Bob_radioButton.Location = new System.Drawing.Point(6, 64);
            this.Bob_radioButton.Name = "Bob_radioButton";
            this.Bob_radioButton.Size = new System.Drawing.Size(45, 16);
            this.Bob_radioButton.TabIndex = 2;
            this.Bob_radioButton.TabStop = true;
            this.Bob_radioButton.Text = "Bob";
            this.Bob_radioButton.UseVisualStyleBackColor = true;
            this.Bob_radioButton.CheckedChanged += new System.EventHandler(this.BobButton_CheckedChanged);
            // 
            // Joe_radioButton
            // 
            this.Joe_radioButton.AutoSize = true;
            this.Joe_radioButton.Location = new System.Drawing.Point(6, 42);
            this.Joe_radioButton.Name = "Joe_radioButton";
            this.Joe_radioButton.Size = new System.Drawing.Size(43, 16);
            this.Joe_radioButton.TabIndex = 1;
            this.Joe_radioButton.TabStop = true;
            this.Joe_radioButton.Text = "Joe";
            this.Joe_radioButton.UseVisualStyleBackColor = true;
            this.Joe_radioButton.CheckedChanged += new System.EventHandler(this.JoeButton_CheckedChanged);
            // 
            // BettingMoney
            // 
            this.BettingMoney.Location = new System.Drawing.Point(122, 128);
            this.BettingMoney.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BettingMoney.Name = "BettingMoney";
            this.BettingMoney.Size = new System.Drawing.Size(59, 21);
            this.BettingMoney.TabIndex = 0;
            this.BettingMoney.ThousandsSeparator = true;
            this.BettingMoney.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Dog4
            // 
            this.Dog4.Image = global::JCW_CS_WINDOWSFORM.Properties.Resources.dog;
            this.Dog4.Location = new System.Drawing.Point(28, 214);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(72, 27);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4.TabIndex = 5;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = global::JCW_CS_WINDOWSFORM.Properties.Resources.dog;
            this.Dog3.Location = new System.Drawing.Point(28, 150);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(72, 27);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3.TabIndex = 4;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = global::JCW_CS_WINDOWSFORM.Properties.Resources.dog;
            this.Dog2.Location = new System.Drawing.Point(28, 80);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(72, 30);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2.TabIndex = 3;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.Image = global::JCW_CS_WINDOWSFORM.Properties.Resources.dog;
            this.Dog1.Location = new System.Drawing.Point(28, 13);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(72, 31);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1.TabIndex = 2;
            this.Dog1.TabStop = false;
            // 
            // Background_Race
            // 
            this.Background_Race.Image = global::JCW_CS_WINDOWSFORM.Properties.Resources.racetrack;
            this.Background_Race.Location = new System.Drawing.Point(12, 12);
            this.Background_Race.Name = "Background_Race";
            this.Background_Race.Size = new System.Drawing.Size(713, 251);
            this.Background_Race.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background_Race.TabIndex = 0;
            this.Background_Race.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Background_Race);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BettingDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_Race)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background_Race;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Al_radioButton;
        private System.Windows.Forms.RadioButton Bob_radioButton;
        private System.Windows.Forms.RadioButton Joe_radioButton;
        private System.Windows.Forms.NumericUpDown BettingMoney;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button Betting_Button;
        private System.Windows.Forms.Button Race_Button;
        private System.Windows.Forms.Label Al_label;
        private System.Windows.Forms.Label Bob_label;
        private System.Windows.Forms.Label Joe_label;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.NumericUpDown BettingDogNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Minimum_Bet_Label;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
    }
}

