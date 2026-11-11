using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefence
{
    public class SpawnManager
    {
        frmTowerDefence gameScreen; //has the tower defence form as the gameScreen
        CollisionManager detectCollision;
        Random randomSpawn = new Random(); //creating a random spwaner which will be used later for enemies
        Timer SpawnTimer = new Timer(); //creates a spwan timer that everytime a tick happens something occurs
        Timer HitTimer = new Timer();
        Bullet explosionBullet;
        BigEnemy enemy = new BigEnemy(); //creates a new instance of BigEnemy in gameScreen
        Enemy smallEnemy = new SmallEnemy(); //creates a new instance of SmallEnemy

        public SpawnManager(frmTowerDefence game)
        {
            gameScreen = game; //gives form the name gameScreen
            SpawnTimer.Interval = 1000; //how long is between each tick
            SpawnTimer.Tick += new EventHandler(SpawnTick); //what happens when the timetr ticks
            SpawnTimer.Start(); //starts the timer
        }
        public void SpawnTick(object sender, EventArgs e)
        {
            ChangeBigEnemy();
            ChangeSmallEnemy();
            if (randomSpawn.Next(0,1000) < 300 && gameScreen.GameTimer.Enabled) //when a random number between 0 and 1000 is above 300 code is executed
            {
                SpawnBigEnemy(); //spawns one of the big enemy class
            }
            if (randomSpawn.Next(0, 1000) < 300 && gameScreen.GameTimer.Enabled)
            {//when a random number between 0 and 1000 is below 300 code is executed
                SpawnSmallEnemy(); //spawns one of the big enemy class
            }
        }

        public void SpawnBigEnemy()
        {
            enemy.SpawnEnemy(gameScreen);
            gameScreen.enemies = gameScreen.enemies + 1 ;
        }
        public void SpawnSmallEnemy()
        {

            smallEnemy.SpawnEnemy(gameScreen); //adds to form
            gameScreen.enemies = gameScreen.enemies + 1;
        }
        public void ChangeBigEnemy()
        {
            foreach (Control x in gameScreen.Controls) //for everything named x in gameScreen
            {
                if (x is PictureBox && (string)x.Tag == "BigEnemy")
                {
                    if (x.Left > gameScreen.mainBuilding.Left)
                    {
                       enemy.EnemySpawn.Image = Properties.Resources.EnemyLeft;
                    }                                    
                    if (x.Left < gameScreen.mainBuilding.Left)
                    {
                        enemy.EnemySpawn.Image = Properties.Resources.EnemyRight;
                    }                                   
                    if (x.Top > gameScreen.mainBuilding.Top)
                    {
                        enemy.EnemySpawn.Image = Properties.Resources.EnemyUp;
                    }                                  
                    if (x.Top < gameScreen.mainBuilding.Top)
                    {
                        enemy.EnemySpawn.Image = Properties.Resources.EnemyDown;

                    }                                  
                }
            }
        }
        public void ChangeSmallEnemy()
        {
            foreach (Control x in gameScreen.Controls) //for everything named x in gameScreen
            {
                if ( x is PictureBox && (string)x.Tag == "SmallEnemy")
                {
                    if (x.Left > gameScreen.mainBuilding.Left)
                    {
                        smallEnemy.EnemySpawn.Image = Properties.Resources.EnemyLeft;
                    }                                    
                    if (x.Left < gameScreen.mainBuilding.Left)
                    {
                        smallEnemy.EnemySpawn.Image = Properties.Resources.EnemyRight;
                    }                                  
                    if (x.Top > gameScreen.mainBuilding.Top)
                    {
                        smallEnemy.EnemySpawn.Image = Properties.Resources.EnemyUp;
                    }                                  
                    if (x.Top < gameScreen.mainBuilding.Top)
                    {
                        smallEnemy.EnemySpawn.Image = Properties.Resources.EnemyDown;

                    }                                 
                }
            }
        }

    }
}
