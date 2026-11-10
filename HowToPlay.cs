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
    public partial class HowToPlay : Form
    {
        MainMenu menu;
        public HowToPlay(MainMenu main)
        {

            InitializeComponent();
            menu = main;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {           
            this.Close();           
        }
    }
}
