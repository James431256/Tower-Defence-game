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
    class Obstacle
    {
        int obX, obY, sizeX, sizeY; 
        frmTowerDefence gameScreen; //creates an instance of the form within the class
        private PictureBox obstacle; //creates a new  instance of a picturebox

        public PictureBox obstacleSpawn { get => obstacle; set => obstacle = value; } //encapsulates the picturebox

        public Obstacle(frmTowerDefence form, int obstacleX, int obstacleY, int sx, int sy)
        {
            obX = obstacleX; // the X coord of the obstacle 
            obY = obstacleY; // the Y coord of the obstacle
            sizeX = sx; //its size (x coord)
            sizeY = sy; //its size (y coord)
            gameScreen = form;
            SpawnObstacle(); //calls the subroutine SpawnObstacle
        }

        public void SpawnObstacle() 
        {
            obstacleSpawn =  new PictureBox();
            obstacleSpawn.Left = obX; //sets the inputted x coord to the left of the obstacle
            obstacleSpawn.Top = obY; //sets the inputted y coord to the top of the obstacle
            obstacleSpawn.Size = new Size(sizeX, sizeY); //sets the obstacles size
            obstacleSpawn.Image = Properties.Resources.obstacle;
            gameScreen.Controls.Add(obstacleSpawn); //adds the obstacle to the form
            obstacleSpawn.Tag = "obstacle";
            obstacleSpawn.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
