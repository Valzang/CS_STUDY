using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JCW_CS_THEQUEST.Mover;

namespace JCW_CS_THEQUEST
{
    public partial class Form1 : Form
    {
        Game c_ObjectController = new Game(new Rectangle(76, 54, 452, 188));
        Random Randomizer = new Random(Guid.NewGuid().GetHashCode());

        public Form1()
        {
            InitializeComponent();
            c_ObjectController.NewLevel(Randomizer);
            LevelInit();
            UpdateCharacters();
        }

        public void LevelInit()
        {
            c_ObjectController.PlayerSetPictureBox(pictureBox_Player, label_Player, label_PlayerHitPoints);
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
                    case "Mace":
                        weapon.PictureBox = pictureBox_Mace;
                        weapon.InventoryItem = pictureBox_Equip_Mace;
                        break;
                    case "Potion_Red":
                        weapon.PictureBox = pictureBox_Potion_Red;
                        weapon.InventoryItem = pictureBox_Equip_Potion_Red;
                        break;
                    case "Potion_Blue":
                        weapon.PictureBox = pictureBox_Potion_Blu;
                        weapon.InventoryItem = pictureBox_Equip_Potion_Blue;
                        break;
                    case "Bomb":
                        weapon.PictureBox = pictureBox_Bomb;
                        weapon.InventoryItem = pictureBox_Equip_Bomb;
                        break;
                }
            }
        }

        private void UpdateCharacters()
        {
            if(c_ObjectController.PlayerHitPoints <= 0)
            {
                MessageBox.Show("당신은 사망하였습니다");
                Close();
                return;
            }

            
            c_ObjectController.PlayerUpdate();
            bool needToDeleteEnemy = false;
            bool needToDeleteWeapon = false;
            List<Enemy> EnemyForDelete = new List<Enemy>();
            List<Weapon> WeaponForDelete = new List<Weapon>();
            foreach (Enemy enemy in c_ObjectController.Enemies)
            {
                enemy.Update();
                if (enemy.Dead)
                {
                    enemy.HitPoints = 0;
                    enemy.Label_HitPoints.Text = "0";
                    enemy.PictureBox.Visible = false;
                    enemy.PictureBox.Enabled = false;
                    EnemyForDelete.Add(enemy);
                    needToDeleteEnemy = true;
                }
            }
            foreach (Weapon weapon in c_ObjectController.WeaponInRoom)
            {
                weapon.Update();
                if (weapon.PickedUp)
                {
                    weapon.PictureBox.Visible = false;
                    weapon.PictureBox.Enabled = false;
                    WeaponForDelete.Add(weapon);
                    needToDeleteWeapon = true;
                }
            }
            if(needToDeleteEnemy)
            {
                c_ObjectController.Enemies.RemoveAll(EnemyForDelete.Contains);
            }
            if (needToDeleteWeapon)
            {
                c_ObjectController.WeaponInRoom.RemoveAll(WeaponForDelete.Contains);
            }

        }


        // 이동 =============================================================
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
        

        // 공격 =============================================================
        private void button_Attack_Left_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Left, Randomizer);
            UpdateCharacters();
            if (c_ObjectController.Enemies == null || c_ObjectController.Enemies.Count == 0)
            {
                if (c_ObjectController.Level == 3)
                {
                    MessageBox.Show("당신은 던전에서 탈출하셨습니다.");
                    Close();
                    return;
                }
                c_ObjectController.NewLevel(Randomizer);
                LevelInit();
                return;
            }
        }

        private void button_Attack_Right_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Right, Randomizer);
            UpdateCharacters();
            if (c_ObjectController.Enemies == null || c_ObjectController.Enemies.Count == 0)
            {
                if (c_ObjectController.Level == 3)
                {
                    MessageBox.Show("당신은 던전에서 탈출하셨습니다.");
                    Close();
                    return;
                }
                c_ObjectController.NewLevel(Randomizer);
                LevelInit();
                return;
            }
        }
        private void button_Attack_Up_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Up, Randomizer);
            UpdateCharacters();
            if (c_ObjectController.Enemies == null || c_ObjectController.Enemies.Count == 0)
            {
                if (c_ObjectController.Level == 3)
                {
                    MessageBox.Show("당신은 던전에서 탈출하셨습니다.");
                    Close();
                    return;
                }
                c_ObjectController.NewLevel(Randomizer);
                LevelInit();
                return;
            }
            UpdateCharacters();
        }

        private void button_Attack_Down_Click(object sender, EventArgs e)
        {
            c_ObjectController.Attack(Direction.Down, Randomizer);
            UpdateCharacters();
            if (c_ObjectController.Enemies == null || c_ObjectController.Enemies.Count == 0)
            {
                if (c_ObjectController.Level == 3)
                {
                    MessageBox.Show("당신은 던전에서 탈출하셨습니다.");
                    Close();
                    return;
                }
                c_ObjectController.NewLevel(Randomizer);
                LevelInit();
                return;
            }
        }

        // 장착 =============================================================
        private void pictureBox_Equip_Sword_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Sword");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Shield_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Shield");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Bow_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Bow");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Quiver_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Quiver");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Mace_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Mace");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Battleaxe_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Battleaxe");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Potion_Red_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Potion_Red");
            UpdateCharacters();
        }

        private void pictureBox_Equip_Potion_Blu_Click(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Potion_Blue");
            UpdateCharacters();
        }
        private void pictureBox_Equip_Bomb_Click_1(object sender, EventArgs e)
        {
            c_ObjectController.Equip("Bomb");
            UpdateCharacters();
        }
    }
}
