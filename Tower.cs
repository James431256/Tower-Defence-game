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
    public abstract class Tower
    {
        public PictureBox tower;
        public int towerPosLeft; //interger showing the left position of the tower
        public int towerPosTop;//interger shwoing the top position of the tower
        public int MouseX, mouseY;

        public PictureBox TowerSpawn { get => tower; set => tower = value; }
        public int TowerPosLeft { get => towerPosLeft; set => towerPosLeft = value; }
        public int TowerPosTop { get => towerPosTop; set => towerPosTop = value; }

        public virtual void SpawnTower(frmTowerDefence form,int MouseX, int MouseY)
        {
            tower = new PictureBox(); // creates a new picturebox for the tower
            TowerSpawn.Tag = "tower"; //gives it the tag tower so it can be identified as such
            TowerSpawn.Size = new Size(53,45); // shows how big the tower will be (width & height)
        }


    }
}
