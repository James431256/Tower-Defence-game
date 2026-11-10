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
    public class CollisionManager
    {
        frmTowerDefence gameScreen; //calls the form
        BigEnemy enemy;
        EnemyMovement movement;
        Timer HitTimer = new Timer();
        LightningTowerBullet explosionBullet;
        public int incScore = 0;
        bool dead = false;
        Random randomSpawn = new Random();

        public CollisionManager(frmTowerDefence game)
        {
            gameScreen = game; //names the form game
           // movement = move;
  
        }
        public void DetectCollision()
        {
            foreach (Control x in gameScreen.Controls) //for everything with 'x' in the form
            {
                foreach (Control y in gameScreen.Controls) //for everything with 'y' in the form
                {
                    if (x is PictureBox && (string)x.Tag == "BigEnemy" && y is PictureBox && (string)y.Tag == "MainBuilding"
                        || x is PictureBox && (string)x.Tag == "SmallEnemy" && y is PictureBox && (string)y.Tag == "MainBuilding")
                    { //sets x to the tag of the big enemy and small enemy and y to the tag of the main building which are the objects colliding
                        MainBuildingHit(x,y); 
                    }
                    if (x is PictureBox && (string)x.Tag == "BigEnemy" && y is PictureBox && (string)y.Tag == "BasicTowerBullet"
                        || x is PictureBox && (string)x.Tag == "SmallEnemy" && y is PictureBox && (string)y.Tag == "BasicTowerBullet")
                    { //assigned small and big enemy to x and the bullets from the basic tower to y
                        EnemyHit(x, y);
                    }
                    if (x is PictureBox && (string)x.Tag == "BigEnemy" && y is PictureBox && (string)y.Tag == "ClickedBullet"
                       || x is PictureBox && (string)x.Tag == "SmallEnemy" && y is PictureBox && (string)y.Tag == "ClickedBullet")
                    { //assigned small and big enemy to x and the bullets from the click tower to y
                        EnemyHit(x, y);
                    }
                    if (y is PictureBox && (string)y.Tag == "obstacle" && x is PictureBox && (string)x.Tag == "BigEnemy" ||
                        y is PictureBox && (string)y.Tag == "obstacle" && x is PictureBox && (string)x.Tag == "SmallEnemy" )
                    {
                        ObstacleHit(x, y);
                    }
                    if (y is PictureBox && (string)y.Tag == "TowerSelect" && x is PictureBox && (string)x.Tag == "SelectedTowerHolder")
                    {
                        Selected(x, y);
                    }
                }
            }
        }

        public void Selected(Control x, Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds))
            {
                y.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                y.BackColor = System.Drawing.Color.Transparent;
            }

        }


        public void DetectSight()
        {
            foreach (Control tower in gameScreen.Controls) //for everything set to tower in the form
            {
                foreach (Control enemy in gameScreen.Controls) //for everything set to enemy in the form
                {
                    if (tower is PictureBox && (string)tower.Tag == "LightningTower" && enemy is PictureBox && (string)enemy.Tag == "BigEnemy" ||
                         tower is PictureBox && (string)tower.Tag == "LightningTower" && enemy is PictureBox && (string)enemy.Tag == "SmallEnemy")
                    { // sets lighting tower to tower and the enemies to enemy
                        EnemyLock(tower, enemy);
                    }
                }
            }
        }
        public void EnemyLock(Control tower, Control enemy)
        {
            double range = Math.Sqrt(((tower.Bounds.X - enemy.Bounds.X) * (tower.Bounds.X - enemy.Bounds.X)) + ((tower.Bounds.Y - enemy.Bounds.Y) * (tower.Bounds.Y - enemy.Bounds.Y)));
            if (range < 150)
            {
                explosionBullet = new LightningTowerBullet(gameScreen,enemy.Bounds.X,enemy.Bounds.Y);
                gameScreen.Controls.Remove(enemy); // removes enemy once its been hit

                ((PictureBox)enemy).Dispose();

                HitTimer.Tick += new EventHandler(HitTick); //sets what happens each time the timer ticks
                HitTimer.Interval = 200;
                HitTimer.Start(); //starts the timer names HitTimer
                incScore = incScore + 50;
                gameScreen.enemies -= 1;

            }
        }
        public void HitTick(object sender, EventArgs e)
        {
            explosionBullet.currentBullet.Dispose();
            HitTimer.Stop();  
        }


        public void EnemyHit(Control x,Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds))
            {     //if the bullet hits the enemy        
               gameScreen.Controls.Remove(y);
               ((PictureBox)y).Dispose(); // removes bullet from screen
               gameScreen.Controls.Remove(x);
               ((PictureBox)x).Dispose(); // removes enemy from screen (enemy has been killed)
                incScore = incScore + 50;
                gameScreen.enemies -= 1;
            }
        }

        public void MainBuildingHit(Control x ,Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds)) //if x (the enemy) intersects with y (the main building) then...
            {
                if (x is PictureBox && (string)x.Tag == "BigEnemy")
                {
                    gameScreen.buildingHealth -= 10; //decreases the main buildings health by 10
                    gameScreen.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                }
                if (x is PictureBox && (string)x.Tag == "SmallEnemy")
                {
                    gameScreen.buildingHealth -= 5; //decreases the main buildings health by 5 
                    gameScreen.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                }

 
            }
            
        }
        public void ObstacleHit(Control x, Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds)) //if x (the enemy) intersects with y (the main building) then...
            {
               // movement.gameTime.Stop();
            }
        }








    }
}
