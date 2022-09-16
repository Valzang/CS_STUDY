using System;
using System.Drawing;
using System.Windows.Forms;


namespace JCW_CS_WINDOWSFORM
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        public Form1() {
            InitializeComponent();
            guys[0] = new Guy() { Cash = 50, Name = "Joe", MyBet = new Bet() { Bettor = new Guy() }, MyLabel = Joe_label, MyRadioButton = Joe_radioButton};
            guys[1] = new Guy() { Cash = 75, Name = "Bob", MyBet = new Bet() { Bettor = new Guy() }, MyLabel = Bob_label, MyRadioButton = Bob_radioButton };           
            guys[2] = new Guy() { Cash = 45, Name = "Al", MyBet = new Bet() { Bettor = new Guy() }, MyLabel = Al_label, MyRadioButton = Al_radioButton };
            
            for (int i=0; i<3; ++i)
            {
                guys[i].MyBet.Bettor = guys[i];
                guys[i].UpdateLabels();
            }

            Dog1.BackColor = Color.Transparent;
            Dog1.Parent = Background_Race;
            Dog2.BackColor = Color.Transparent;
            Dog2.Parent = Background_Race;
            Dog3.BackColor = Color.Transparent;
            Dog3.Parent = Background_Race;
            Dog4.BackColor = Color.Transparent;
            Dog4.Parent = Background_Race;
            dogs[0] = new Greyhound() { MyPictureBox = Dog1, Randomizer = new Random(DateTime.Now.Millisecond), StartingPosition = 28, RacetrackLength = Background_Race.Width };
            dogs[1] = new Greyhound() { MyPictureBox = Dog2, Randomizer = new Random(DateTime.Now.Millisecond-10), StartingPosition = 28, RacetrackLength = Background_Race.Width };
            dogs[2] = new Greyhound() { MyPictureBox = Dog3, Randomizer = new Random(DateTime.Now.Millisecond-20), StartingPosition = 28, RacetrackLength = Background_Race.Width };
            dogs[3] = new Greyhound() { MyPictureBox = Dog4, Randomizer = new Random(DateTime.Now.Millisecond-30), StartingPosition = 28, RacetrackLength = Background_Race.Width };
            
        }

        private void JoeButton_CheckedChanged(object sender, EventArgs e)
        {
            label_Name.Text = "Joe";
            BettingMoney.Maximum = guys[0].Cash;

        }

        private void BobButton_CheckedChanged(object sender, EventArgs e)
        {
            label_Name.Text = "Bob";
            BettingMoney.Maximum = guys[1].Cash;
        }

        private void AlButton_CheckedChanged(object sender, EventArgs e)
        {
            label_Name.Text = "Al";
            BettingMoney.Maximum = guys[2].Cash;
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            switch(label_Name.Text)
            {
                case "Joe":
                    guys[0].PlaceBet((int)BettingMoney.Value, (int)BettingDogNumber.Value);
                    break;
                case "Bob":
                    guys[1].PlaceBet((int)BettingMoney.Value, (int)BettingDogNumber.Value);
                    break;
                case "Al":
                    guys[2].PlaceBet((int)BettingMoney.Value, (int)BettingDogNumber.Value);
                    break;
            }
        }

        private void Race_Button_Click(object sender, EventArgs e)
        {
            Race_Button.Enabled = false;
            BettingMoney.Enabled = false;

            int winningDog_number = 0;
            bool winner = false;

            while(!winner)
            {
                for (int i=0; i<4; ++i)
                {
                    if(dogs[i].Run())
                    {
                        winner = true;
                        winningDog_number = i+1;
                    }
                    Background_Race.Update();
                }
            }

            

            string Winner_name = "";
            int count = 0;
            for (int i=0; i<3; ++i)
            {
                string temp = guys[i].Collect(winningDog_number);
                if (temp != null)
                {
                    if ( guys[i].Cash >= 5)
                    {
                        if (count >= 1)
                            Winner_name += ", ";
                        ++count;
                        Winner_name += temp;
                    }
                }
                guys[i].ClearBet();                
            }
            if (count == 0)
                Winner_name = "없음";
            MessageBox.Show("우승한 개는 " + winningDog_number + "번째 개입니다\n" + "우승자는 " + Winner_name + " 입니다.");

            for (int i=0; i<4; ++i)
            {
                dogs[i].TakeStartingPosition();
            }

            Race_Button.Enabled = true;
            BettingMoney.Enabled = true;

        }
    }
}
