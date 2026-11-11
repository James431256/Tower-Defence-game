using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefence
{
    class BasicTowerBullet : Bullet //inherits bullet class
    {
        public override void CreateBullet(Form form)
        {
            base.CreateBullet(form); //creates an instance of the new bullet in form
            currentBullet.Tag = "BasicTowerBullet"; //gives a tag
            BulletTimer.Interval = 100; //executes the code at every inteval
            BulletTimer.Tick += new EventHandler(BulletTick); //everytime the timer ticks this code is executed
            BulletTimer.Start(); //starts the timer named BulletTimer

        }
        public  void BulletTick(object sender, EventArgs e)
        {
            if (Direction == Direction.left)//if the bullet is set to the left...
            {
                currentBullet.Left -= speed;//makes the bullet move left every tick
                currentBullet.Image = Properties.Resources.laserRedLeft;
            }
            if (Direction == Direction.right)//if the bullet is set to the right...
            {
                currentBullet.Left += speed;//makes the bullet move right every tick
                currentBullet.Image = Properties.Resources.LaserRedRight;
            }
            if (Direction == Direction.up)//if the bullet is set upwards...
            {
                currentBullet.Top -= speed;//makes the bullet up left every tick
                currentBullet.Image = Properties.Resources.LaserRedUp;
            }
            if (Direction == Direction.down)//if the bullet is set downwards..
            {
                currentBullet.Top += speed;//makes the bullet move down every tick
                currentBullet.Image = Properties.Resources.laserRedDown;
            }
            if (currentBullet.Right < 20 || currentBullet.Left > 900 || currentBullet.Bottom < 20 || currentBullet.Top > 500)//if bullets are at these co-ords
            {
                BulletTimer.Stop(); //stops bullets timer
                BulletTimer.Dispose(); //disposes of the bullet timer
                currentBullet.Dispose(); //disposes of the bullet
                BulletTimer = null; //nulls class
                currentBullet = null; //nulls class
            }
        }
    }
}
