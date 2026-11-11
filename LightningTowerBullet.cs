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
    class LightningTowerBullet
    {
        frmTowerDefence gameScreen;
        PictureBox bullet = new PictureBox();
        int enX, enY;

        public PictureBox currentBullet { get => bullet; set => bullet = value; }

        public LightningTowerBullet(Form form,int enemyX, int enemyY)
        {
            enX = enemyX;
            enY = enemyY;
            CreateBullet(form);
        }
        public void CreateBullet(Form form)
        {

            gameScreen = (frmTowerDefence)form;
            form.Controls.Add(currentBullet);
            currentBullet.Tag = "LightningTowerBullet"; //gives a tag
            currentBullet.Image = Properties.Resources.newExplosion;
            currentBullet.SizeMode = PictureBoxSizeMode.Zoom;
            currentBullet.Size = new Size (45, 45); // sets size 
            currentBullet.Left = enX; //sets x coord
            currentBullet.Top = enY; //sets y coord
        }
    }
}
