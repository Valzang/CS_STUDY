using System;
using System.Drawing;
using System.Windows.Forms;

enum Direction : int { Up, Down, Left, Right};

namespace JCW_CS_THEQUEST.Mover
{
    abstract class Mover
    {
        // 움직이는 거리================================================================
        private const int MoveInterval = 10;

        // 현재 위치================================================================
        protected Point location;
        public Point Location { get { return location; } set { location = value; } }

        protected Game game;
        protected Random Randomizer;


        // 현재 생명력================================================================
        private int hitPoints; // 0 되면 죽음
        public int HitPoints { get { return hitPoints; } set { hitPoints = value; } }
        public bool Dead
        {
            get
            {
                return HitPoints <= 0;
            }
        }

        // 라벨================================================================
        protected Label label;
        public Label Label { get { return label; } set { label = value; } }
        protected Label label_HitPoints;
        public Label Label_HitPoints { get { return label_HitPoints; } set { label_HitPoints = value; } }



        // 픽쳐 박스================================================================
        protected PictureBox picture_Box;
        public PictureBox PictureBox 
        { 
            get { return picture_Box; }
            set { 
                picture_Box = value; 
                picture_Box.Location = location;
                picture_Box.Visible = true;
            } 
        }

        // 생성자 ================================================================
        public Mover() { }

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
            Randomizer = new Random(Guid.NewGuid().GetHashCode());
        }
        
        //=========================================================================
        virtual public void Update()
        {
            PictureBox.Location = Location;
            PictureBox.Update();
            Label_HitPoints.Text = hitPoints.ToString();
        }

        public bool NearBy(Point locationToCheck, int distance)
        {
            return (Math.Abs(location.X - locationToCheck.X) <= distance
                && (Math.Abs(location.Y - locationToCheck.Y) <= distance));
        }

        public bool NearBy(Point locationToCheck, Point CurrentLocation, int distance)
        {
            return (Math.Abs(CurrentLocation.X - locationToCheck.X) <= distance
                && (Math.Abs(CurrentLocation.Y - locationToCheck.Y) <= distance));
        }

        // 움직이는 함수 ================================================================
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
            }
            return newLocation;
        }
        public Point Move(Direction direction, Point Player_Location, Rectangle boundaries)
        {            
            switch (direction)
            {
                case Direction.Up:
                    if (Player_Location.Y - MoveInterval >= boundaries.Top)
                        Player_Location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (Player_Location.Y + MoveInterval <= boundaries.Bottom)
                        Player_Location.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (Player_Location.X - MoveInterval >= boundaries.Left)
                        Player_Location.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (Player_Location.X + MoveInterval <= boundaries.Right)
                        Player_Location.X += MoveInterval;
                    break;
                default:
                    break;
            }
            return Player_Location;
        }

    }
}
