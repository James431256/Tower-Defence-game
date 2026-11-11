using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefence
{
    public abstract class Enemy
    {
        PictureBox enemy; 
        int enemyPosLeft; //creates enemyposition left
        int enemyPosTop; //creates enemy position top
        frmTowerDefence gameScreen;
        Timer HitTimer = new Timer();
        public int Health;
        Bullet explosionBullet;
        


        public PictureBox EnemySpawn { get => enemy; set => enemy = value; } //encapsulates
        public int EnemyPosLeft { get => enemyPosLeft; set => enemyPosLeft = value; } //encapsulates
        public int EnemyPosTop { get => enemyPosTop; set => enemyPosTop = value; } //encapsulates

        public virtual void SpawnEnemy(frmTowerDefence form)
        {
            enemy = new PictureBox();  //sets name of picturebox to enemy
            EnemySpawn.Tag = "enemy"; //gives enemy the tag "enemy"
            EnemySpawn.Size = new Size (45,45); //sets size of enemy pictureboxes
            Health = 100;
            gameScreen = form;
        }
        





    }
}
