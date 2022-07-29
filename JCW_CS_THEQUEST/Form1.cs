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
            c_ObjectController.PlayerSetPictureBox(pictureBox_Player, label_Player, label_PlayerHitPoints);
            c_ObjectController.NewLevel(Randomizer);
            LevelInit();


        }

        private void LevelInit()
        {
            foreach (Enemy enemy in c_ObjectController.Enemies)
            {
                switch (enemy.EnemyName)
                {
                    case "Bat":
                        enemy.PictureBox = pictureBox_Bat;
                        enemy.Label = label_Bat;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_BatHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        break;
                    case "Ghoul":
                        enemy.PictureBox = pictureBox_Ghoul;
                        enemy.Label = label_Ghoul;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_GhoulHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        break;
                    case "Ghost":
                        enemy.PictureBox = pictureBox_Ghost;
                        enemy.Label = label_Ghost;
                        enemy.Label.Visible = true;
                        enemy.Label_HitPoints = label_GhostHitPoints;
                        enemy.Label_HitPoints.Visible = true;
                        enemy.Label_HitPoints.Text = enemy.HitPoints.ToString();
                        break;
                }
            }
            foreach (Weapon weapon in c_ObjectController.WeaponInRoom)
            {
                switch (weapon.Weapon_Name)
                {
                    case "Sword":
                        weapon.PictureBox = pictureBox_Sword;
                        weapon.InventoryItem = pictureBox_Equip_Sword;
                        break;
                    case "Bow":
                        weapon.PictureBox = pictureBox_Bow;
                        weapon.InventoryItem = pictureBox_Equip_Bow;
                        break;
                    case "Battleaxe":
                        weapon.PictureBox = pictureBox_Battleaxe;
                        weapon.InventoryItem = pictureBox_Equip_Battleaxe;
                        break;
                    case "Mace":
                        weapon.PictureBox = pictureBox_Mace;
                        weapon.InventoryItem = pictureBox_Equip_Mace;
                        break;
                    case "Shield":
                        weapon.PictureBox = pictureBox_Shield;
                        weapon.InventoryItem = pictureBox_Equip_Shield;
                        break;
                    case "Quiver":
                        weapon.PictureBox = pictureBox_Quiver;
                        weapon.InventoryItem = pictureBox_Equip_Quiver;
                        break;
                }
            }
        }

        private void UpdateCharacters()
        {
            c_ObjectController.PlayerUpdate();
            foreach (Enemy enemy in c_ObjectController.Enemies)
            {
                enemy.Update();
            }
            foreach (Weapon weapon in c_ObjectController.WeaponInRoom)
            {
                weapon.Update();
            }
        }

        private void button_Move_Left_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Left, Randomizer);
            UpdateCharacters();
        }

        private void button_Move_Right_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Right, Randomizer);
            UpdateCharacters();
        }

        private void button_Move_Up_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Up, Randomizer);
            UpdateCharacters();
        }

        private void button_Move_Down_Click(object sender, EventArgs e)
        {
            c_ObjectController.Move(Direction.Down, Randomizer);
            UpdateCharacters();
        }
        
        private void button_Attack_Left_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Left, Randomizer);
            UpdateCharacters();
        }

        private void button_Attack_Right_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Right, Randomizer);
            UpdateCharacters();
        }
        private void button_Attack_Up_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Up, Randomizer);
            UpdateCharacters();
        }

        private void button_Attack_Down_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Down, Randomizer);
            UpdateCharacters();
        }

    }
}
