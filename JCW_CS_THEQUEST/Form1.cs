using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCW_CS_THEQUEST
{
    public partial class Form1 : Form
    {
        Game c_ObjectController = new Game(new Rectangle(76, 54, 452, 188));
        Random Randomizer = new Random(Guid.NewGuid().GetHashCode());

        public Form1()
        {
            InitializeComponent();
            c_ObjectController.SetPictureBox(pictureBox_Player, label_Player, label_PlayerHitPoints);
            c_ObjectController.NewLevel(Randomizer);
            foreach(Enemy enemy in c_ObjectController.Enemies)
            {
                switch(enemy.EnemyName)
                {
                    case "Bat":
                        enemy.PictureBox = pictureBox_Bat;
                        enemy.Label = label_Bat;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_BatHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        //pictureBox_Bat.Visible = true;
                        break;
                    case "Ghoul":
                        enemy.PictureBox = pictureBox_Ghoul;
                        enemy.Label = label_Ghoul;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_GhoulHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        //pictureBox_Ghoul.Visible = true;
                        break;
                    case "Ghost":
                        enemy.PictureBox = pictureBox_Ghost;
                        enemy.Label = label_Ghost;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_GhostHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        //pictureBox_Ghost.Visible = true;
                        break;
                }
            }
            foreach (Weapon weapon in c_ObjectController.WeaponInRoom)
            {
                switch (weapon.Weapon_Name)
                {
                    case "Sword":
                        weapon.PictureBox = pictureBox_Sword;
                        //pictureBox_Sword.Visible = true;
                        break;
                    case "Bow":
                        weapon.PictureBox = pictureBox_Bow;
                        //pictureBox_Bow.Visible = true;
                        break;
                    case "Battleaxe":
                        weapon.PictureBox = pictureBox_Battleaxe;
                        //pictureBox_Battleaxe.Visible = true;
                        break;
                    case "Mase":                        
                        weapon.PictureBox = pictureBox_Mace;
                        //pictureBox_Mace.Visible = true;
                        break;
                    case "Shield":
                        weapon.PictureBox = pictureBox_Shield;
                        ///pictureBox_Shield.Visible = true;
                        break;                        
                    case "Quiver":
                        weapon.PictureBox = pictureBox_Quiver;
                        //pictureBox_Quiver.Visible = true;
                        break;
                }
            }



        }

        private void UpdateCharacters()
        {
            foreach (Enemy enemy in c_ObjectController.Enemies)
            {

            }
        }

        private void button_Move_Left_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Left, Randomizer);
        }

        private void button_Move_Right_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Right, Randomizer);
        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Up, Randomizer);
        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Down, Randomizer);
        }
        
        private void button_Attack_Left_Click(object sender, EventArgs e)
        {

        }

        private void button_Attack_Right_Click(object sender, EventArgs e)
        {

        }
        private void button_Attack_Up_Click(object sender, EventArgs e)
        {

        }

        private void button_Attack_Down_Click(object sender, EventArgs e)
        {

        }

    }
}
