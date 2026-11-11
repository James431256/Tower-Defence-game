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
    public class BasicTower : Tower //Inherits Tower class
    {
        Bullet bulletUp; //uses attribute from Bullet class
        Bullet bulletDown; //uses attribute from Bullet class
        Bullet bulletLeft; //uses attribute from Bullet class
        Bullet bulletRight; //uses attribute from Bullet class
        frmTowerDefence gameScreen; //uses form
        Timer shootTimer = new Timer(); //creates new timer foe when a tower shoots
        Random randomNum = new Random();


        Direction direction;

        public override void SpawnTower(frmTowerDefence form,int MouseX,int  MouseY)
        {
            base.SpawnTower(form,MouseX,MouseY); //add this void to the form
            TowerSpawn.Left = (MouseX); //Spawns tower X coordinate
            TowerSpawn.Top = MouseY; //Spawns tower Y coordinate
            gameScreen = form; //sets the form type to gameScreen
            TowerSpawn.Image = Properties.Resources.BasicTower; //sets image to tower in resources
            TowerSpawn.SizeMode = PictureBoxSizeMode.StretchImage;
            TowerSpawn.Size = new Size(65,65);
            gameScreen.Controls.Add(TowerSpawn); //adds this tower to the gameScreen
            TowerSpawn.BringToFront(); //brings the picturebox to front so isnt hidden behind anything
           
            shootTimer.Tick += new EventHandler(ShootTick); //sets what happens each time the timer ticks
            shootTimer.Start(); //starts the timer names shootTimer
            shootTimer.Interval = 1700; //sets a timer for the interval for when the tower shoots


        }
        private void ShootTick(object sender, EventArgs e)
        {
            if (gameScreen.GameTimer.Enabled)
            {
                if (!gameScreen.Controls.Contains(TowerSpawn)) //only spawns bullets where towers are
                {
                    bulletUp = null; //if theres no towers deletes bullet
                    bulletDown = null; //if theres no towers deletes bullet
                    bulletLeft = null; //if theres no towers deletes bullet
                    bulletRight = null; //if theres no towers deletes bullet
                    shootTimer.Stop(); //stop 
                }
                else
                {
                   
                    bulletUp = new BasicTowerBullet(); //creates new instances of each bullet in this variable 
                    bulletDown = new BasicTowerBullet(); //creates new instances of each bullet in this variable
                    bulletLeft = new BasicTowerBullet(); //creates new instances of each bullet in this variable
                    bulletRight = new BasicTowerBullet(); //creates new instances of each bullet in this variable

                    bulletUp.Direction = Direction.up; //sets the bulletUp variable to go upwards
                    bulletUp.BulletPosLeft1 = (TowerSpawn.Left + (TowerSpawn.Width / 2))-9; //spawns the bullet in the midde of the tower
                    bulletUp.BulletPosTop1 = TowerSpawn.Top + (TowerSpawn.Height / 2); //spawns the bullet in the midde of the tower
                    bulletUp.CreateBullet(gameScreen); //creates the bullet on the game screen

                    bulletDown.Direction = Direction.down; //sets the bulletDown variable to go downwards
                    bulletDown.BulletPosLeft1 = (TowerSpawn.Left + (TowerSpawn.Width / 2))-9; //spawns the bullet in the midde of the tower
                    bulletDown.BulletPosTop1 = TowerSpawn.Top + (TowerSpawn.Height / 2); //spawns the bullet in the midde of the tower
                    bulletDown.CreateBullet(gameScreen); //creates the bullet on the game screen

                    bulletLeft.Direction = Direction.left; //sets the bulletLeft variable to fo to the left
                    bulletLeft.BulletPosLeft1 = TowerSpawn.Left + (TowerSpawn.Width / 2); //spawns the bullet in the midde of the tower
                    bulletLeft.BulletPosTop1 = (TowerSpawn.Top + (TowerSpawn.Height / 2))-9; //spawns the bullet in the midde of the tower
                    bulletLeft.CreateBullet(gameScreen); //creates the bullet on the game screen

                    bulletRight.Direction = Direction.right; //sets the bulletRight variable to fo to the right
                    bulletRight.BulletPosLeft1 = TowerSpawn.Left + (TowerSpawn.Width / 2); //spawns the bullet in the midde of the tower
                    bulletRight.BulletPosTop1 = (TowerSpawn.Top + (TowerSpawn.Height / 2))-9; //spawns the bullet in the midde of the tower
                    bulletRight.CreateBullet(gameScreen); //creates the bullet on the game screen
                    //TowerSpawn.Image = Properties.Resources.BasicTowerstat;
                    
                }
            }

        }





    }


}
