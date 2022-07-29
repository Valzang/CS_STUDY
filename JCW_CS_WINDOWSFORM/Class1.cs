using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace JCW_CS_WINDOWSFORM
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location;
        public Random Randomizer;        


        public bool Run()
        {            
            Thread.Sleep(20);
            Point CurrentLocation = MyPictureBox.Location;
            if (CurrentLocation.X + MyPictureBox.Width >= RacetrackLength)
                return true;
            else
            {
                CurrentLocation.X += Randomizer.Next(5, 15);
                MyPictureBox.Location = CurrentLocation;
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = MyPictureBox.Location.Y;
            MyPictureBox.Location = new Point(StartingPosition, Location);
        }
    }
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy() { }

        public void UpdateLabels()
        {
            if (Cash >= 5)
            {
                MyRadioButton.Text = Name + " has " + Cash + " bucks";
                MyLabel.Text = this.MyBet.GetDescription();
            }
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = -1;
            if(Cash < 5)
            {
                if ( Cash == 0 )
                    MyRadioButton.Text = MyRadioButton.Text = Name + " is out of Money ";
                else
                    MyRadioButton.Text = MyRadioButton.Text = Name + " has " + Cash + " bucks but can't bet with that";
                MyRadioButton.Enabled = false;
            }
            else
                MyRadioButton.Text = MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = Name + " hasn't placed a bet";
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet();
            MyBet.Amount = Amount;
            MyBet.Dog = Dog;
            MyBet.Bettor = this;
            if (MyBet.Bettor.Cash >= Amount && MyBet.Bettor.Cash >= 5)
            {
                this.UpdateLabels();
                return true;
            }
            else
                return false;
        }
        public string Collect(int Winner)
        {            
            Cash += MyBet.PayOut(Winner);
            if (MyBet.PayOut(Winner) >= 0)
                return Name;
            else
                return null;
        }
    }

    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount != 0 || Bettor.MyBet.Amount > Bettor.Cash)
                return Bettor.Name + " bets " + Amount + " on dog " + "#" + Dog;
            else
                return Bettor.Name + " hasn't placed a bet";
        }
        public int PayOut(int Winner)
        {
            return Bettor.MyBet.Dog == Winner ? Amount : -Amount;
        }
    }

}
