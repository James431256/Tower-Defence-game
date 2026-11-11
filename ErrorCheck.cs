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
    public partial class ErrorCheck : Form
    {
        public ErrorCheck()
        {
            InitializeComponent();
        }

        private void btnOK_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
