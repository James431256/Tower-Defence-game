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
    public partial class MainMenu : Form
    {
        private bool check = false;
        frmTowerDefence gameScreen;
        public MainMenu()
        {
            InitializeComponent();          
        }


        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            
            if(check == true)
            {
                frmTowerDefence game = new frmTowerDefence(); // opens the towerdefence form
                game.ShowDialog();
            }
            else
            {
                ErrorCheck error = new ErrorCheck(); // opens the error
                error.ShowDialog();
            }
            
        }

        private void BtnHowToPlay_Click(object sender, EventArgs e)
        {
            check = true;
            HowToPlay instructions = new HowToPlay(this);
            instructions.ShowDialog();
        }

        private void BtnHighScores_Click(object sender, EventArgs e)
        {
            HighScores highScore = new HighScores();
            highScore.ShowDialog();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
