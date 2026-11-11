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
    class ClickTower : Tower
    {
        ClickTowerBullet bullet; //creates an instance of Bullet class
        frmTowerDefence gameScreen; //uses form
        Timer shootTimer = new Timer();
        //creates new timer foe when a tower shoots
        Random randomNum = new Random();
        double TowerDirection;
        private Graphics graphics;
        PictureBox pic = new PictureBox();


        public override void SpawnTower(frmTowerDefence form, int MouseX, int MouseY)
        {
            base.SpawnTower(form, MouseX, MouseY); //add this subroutine to the form
            TowerSpawn.Left = (MouseX); //Spawns tower X coordinate
            TowerSpawn.Top = MouseY; //Spawns tower Y coordinate
            gameScreen = form; //sets the form type to gameScreen
            TowerSpawn.Image = Properties.Resources.ClickTower; //sets image to tower in resources
            TowerSpawn.SizeMode = PictureBoxSizeMode.StretchImage;
            TowerSpawn.Size = new Size(65, 65);
            gameScreen.Controls.Add(TowerSpawn); //adds this tower to the gameScreen
            TowerSpawn.BringToFront(); //brings the picturebox to front so isnt hidden behind anything


            shootTimer.Tick += new EventHandler(ShootTick); //sets what happens each time the timer ticks
            shootTimer.Start(); //starts the timer names shootTimer
            shootTimer.Interval = 1200; //sets a timer for the interval for when the tower shoots
        }
        private void ShootTick(object sender, EventArgs e)
        {
            if (gameScreen.GameTimer.Enabled)
            {
                if (gameScreen.clickX > 0 || gameScreen.clickY > 0)
                {
                    if (!gameScreen.Controls.Contains(TowerSpawn)) //only spawns bullets where towers are
                    {
                        bullet = null; //if theres no towers deletes bullet
                        shootTimer.Stop(); //stop 
                    }
                    else
                    {

                        
                        bullet = new ClickTowerBullet(); //creates a new instance of ClickTowerBullet bullet and sets it to the name bullet 
                        bullet.BulletPosLeft1 = TowerSpawn.Left + (TowerSpawn.Width / 2); //spawns the bullet in the midde of the tower
                        bullet.BulletPosTop1 = TowerSpawn.Top + (TowerSpawn.Height / 2); //spawns the bullet in the midde of the tower
                        bullet.CreateBullet(gameScreen); //creates the bullet on the game screen/ adds subroutine to form
                        bullet.setStartx(TowerSpawn.Left + (TowerSpawn.Width / 2));
                        bullet.setStarty(TowerSpawn.Top + (TowerSpawn.Height / 2));
                        bullet.setclickx(gameScreen.clickX);
                        bullet.setclicky(gameScreen.clickY);
                    }
                }


            }
        }
        public void TowerFacing(double theDirection)
        {
            TowerDirection = theDirection;
        }
       

    }

}
