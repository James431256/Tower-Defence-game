using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace TowerDefence
{
    class ClickTowerBullet : Bullet
    {
        frmTowerDefence gameScreen;
        Timer movementTrack = new Timer();
        int startx;
        int starty;
        int clickx;
        int clicky;
        ClickTower clickTower;
        public override void CreateBullet(Form form)
        {
            gameScreen = (frmTowerDefence)form;
            base.CreateBullet(form); //creates an instance of the new bullet in form
            currentBullet.Image = Properties.Resources.laserBlue08;
            currentBullet.Size = new System.Drawing.Size(15, 15);
            currentBullet.Tag = "ClickedBullet"; //gives a tag
            BulletTimer.Start();
            BulletTimer.Interval = 25; //executes the code at every inteval
            BulletTimer.Tick += new EventHandler(BulletTick); //everytime the timer ticks this code is executed
            speed = 10;

        }
        public void BulletTick(object sender, EventArgs e)
        {
            Vector move = movetowards(); //adds the vector to the subroutine
            
        }
        public Vector movetowards()
        {
            //works out direction the bullet needs to move
            double direction = (float)(Math.Atan2(starty - clicky, startx - clickx) * 180 / Math.PI);
            Vector move = new Vector(0, 0); //creates new vector 

            move.X = (float)Math.Cos(direction * Math.PI / 180) * speed; //finds the angle for the x coordinate 
            move.Y = (float)Math.Sin(direction * Math.PI / 180) * speed; //finds angle of y coordinate

            currentBullet.Location = new System.Drawing.Point((int)(currentBullet.Location.X - move.X), (int)(currentBullet.Location.Y - move.Y));

            return move;
            //move is the diagonal vector the bullet moves along
        }
        public void setStartx(int startx1)
        {
            startx = startx1; 
        }
        public void setStarty(int starty1)
        {
            starty = starty1;
        }
        public void setclickx(int clickx1)
        {
           clickx = clickx1;
        }
        public void setclicky(int clicky1)
        {
            clicky = clicky1;
        }
        public void TheDirection()
        {
            double direction = (float)(Math.Atan2(starty - clicky, startx - clickx) * 180 / Math.PI);
            clickTower.TowerFacing(direction);
        }
    }
}
