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
    public class EnemyMovement
    {
        frmTowerDefence gameScreen; //puts this class into gameScreen
        public Timer gameTime = new Timer(); //Creates new timer
        int speed = 1; //sets speed
        int direc = 0;
        BigEnemy enemy;


        public EnemyMovement(frmTowerDefence game)
        {
            gameScreen = game;
            gameTime.Interval = 100000; //Sets how often timer ticks
            gameTime.Start(); //starts timer
            gameTime.Tick += new EventHandler(GameTick); //executes this when timer ticks

        }
        public void moveBigEnemy()
        {
            foreach (Control x in gameScreen.Controls) //for everything named x in gameScreen
            {
                if (x is PictureBox && (string)x.Tag == "BigEnemy") //if x has a picturebox and the tag enemy..
                {
                    if (x.Left > gameScreen.mainBuilding.Left)
                    {
                       
                        x.Left -= speed;

                    }                                    //if the left side of enemy is greater than main building move right
                    if (x.Left < gameScreen.mainBuilding.Left)
                    {
                        x.Left += speed;

                    }                                   //if the left side of main building is greater than enemy move left
                    if (x.Top > gameScreen.mainBuilding.Top)
                    {
                        x.Top -= speed;

                    }                                  //if the top side of main building is less than enemy move down
                    if (x.Top < gameScreen.mainBuilding.Top)
                    {
                        x.Top += speed;
                    }                                  //if the top of main building is greater than enemy move up
                }
            }
        }
        public void moveSmallEnemy()
        {
            foreach (Control x in gameScreen.Controls) //for everything named x in gameScreen
            {
                if (x is PictureBox && (string)x.Tag == "SmallEnemy") //if x has a picturebox and the tag enemy..
                {
                    if (x.Left > gameScreen.mainBuilding.Left)
                    {
                        x.Left -= (speed + 1);
                    }                                    //if the left side of enemy is greater than main building move right
                    if (x.Left < gameScreen.mainBuilding.Left)
                    {
                        x.Left += (speed + 1);
                    }                                   //if the left side of main building is greater than enemy move left
                    if (x.Top > gameScreen.mainBuilding.Top)
                    {
                        x.Top -= (speed + 1);
                    }                                  //if the top side of main building is less than enemy move down
                    if (x.Top < gameScreen.mainBuilding.Top)
                    {
                        x.Top += (speed + 1);
                    }                                  //if the top of main building is greater than enemy move up
                }
            }
        }
        private void GameTick(object sender, EventArgs e)
        {
            speed++; //adds to speed
        }

    }

}

