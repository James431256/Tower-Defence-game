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
    class SmallEnemy : Enemy
    {
        
        Random randomNum = new Random(); //creates a random number
        Form gameScreen; //Calls the form gameScreen
        


        public override void SpawnEnemy(frmTowerDefence form)
        {
            base.SpawnEnemy(form); //acceses base class from inside this class
            EnemySpawn.Left = randomNum.Next(0, 750); //spawns an enemy at any point in these x co-ords 
            EnemySpawn.Top = randomNum.Next(470, 480); //spawns an enemy at any point in these y co-ords
            gameScreen = form;
            EnemySpawn.Tag = "SmallEnemy";
            gameScreen.Controls.Add(EnemySpawn); //adds the subroutine into this form
            EnemySpawn.Enabled = true;
            EnemySpawn.SizeMode = PictureBoxSizeMode.StretchImage;
            EnemySpawn.Size = new Size(35, 35);
            Health = 50;
        }
        public void DeadEnemy()
        {
            if(Health <= 0)
            {
                gameScreen.Controls.Remove(EnemySpawn);
                ((PictureBox)EnemySpawn).Dispose();
            }
        }
    }
}
