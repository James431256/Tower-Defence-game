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
    public class BigEnemy : Enemy //inherits enemy class
    {
        Random randomNum = new Random(); //creates a random number
        Form gameScreen; //Calls the form gameScreen
        public int Health;
        int enemyDirec = 0;


        public override void SpawnEnemy(frmTowerDefence form)
        {
            base.SpawnEnemy(form); //acceses base class from inside this class
            EnemySpawn.Left = randomNum.Next(-20, 800); //spawns an enemy at any point in these x co-ords 
            EnemySpawn.Top = randomNum.Next(-100, 0); //spawns an enemy at any point in these y co-ords
            EnemySpawn.Tag = "BigEnemy";
            gameScreen = form;
            EnemySpawn.Enabled = true;
            EnemySpawn.SizeMode = PictureBoxSizeMode.AutoSize;
            gameScreen.Controls.Add(EnemySpawn); //adds the subroutine into this form
            Health = 100;
            
        }
        public void GetDirection(int TheEnemyDirec)
        {
            enemyDirec = TheEnemyDirec;
        }
        

    }
}
