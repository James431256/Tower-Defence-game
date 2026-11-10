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
    

    public abstract class Bullet
    {
        Direction direction; //brings the enum into the class
        int BulletPosLeft; //interger for left position of bullet
        int BulletPosTop; //interger for top of bullet
        public int speed = 10; //sets speed of bullet
        PictureBox bullet = new PictureBox(); //createss a new picturebox for bullets
        Timer bulletTimer = new Timer(); //creates a new timer for each spawning bullet

        public Direction Direction { get => direction; set => direction = value; }
        public int BulletPosLeft1 { get => BulletPosLeft; set => BulletPosLeft = value; }
        public int BulletPosTop1 { get => BulletPosTop; set => BulletPosTop = value; }
        public PictureBox currentBullet { get => bullet; set => bullet = value; }
        public Timer BulletTimer { get => bulletTimer; set => bulletTimer = value; }

        public virtual void CreateBullet(Form form)
        {
            currentBullet.BackColor = Color.Transparent; //makes the back of the image transparent
            currentBullet.Image = Properties.Resources.bullet; //Assigns the image saved in resources to the bullet
            currentBullet.SizeMode = PictureBoxSizeMode.Zoom; //gives the bullet the size 10 by 10
            currentBullet.Size = new Size(20, 20);
            currentBullet.Left = BulletPosLeft1; //assigns the left side of the bullet the interger BulletPosLeft
            currentBullet.Top = BulletPosTop1; //assigns the top of the bullet the interger BulletPosTop
            currentBullet.BringToFront(); //brings the bullet to the fromt of the screen so doesnt get lost behind any pictureboxes
            form.Controls.Add(currentBullet); //adds bullet to the form(TowerDefence)

        }



    }
}
