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
    class LightningTower : Tower
    {
        frmTowerDefence gameScreen; //uses form
        Timer shootTimer = new Timer(); //creates new timer foe when a tower shoots
        Random randomNum = new Random();
        Bullet bullet;

        public override void SpawnTower(frmTowerDefence form, int MouseX, int MouseY)
        {
            base.SpawnTower(form, MouseX, MouseY); //add this void to the form
            TowerSpawn.Left = (MouseX); //Spawns tower X coordinate
            TowerSpawn.Top = MouseY; //Spawns tower Y coordinate
            gameScreen = form; //sets the form type to gameScreen
            TowerSpawn.Image = Properties.Resources.Mortar; //sets image to tower in resources
            TowerSpawn.SizeMode = PictureBoxSizeMode.StretchImage; 
            TowerSpawn.Size = new Size(65, 65);
            gameScreen.Controls.Add(TowerSpawn); //adds this tower to the gameScreen
            TowerSpawn.BringToFront(); //brings the picturebox to front so isnt hidden behind anything
            TowerSpawn.Tag = "LightningTower";

        }

    }
   
}
