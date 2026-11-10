using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TowerDefence
{
    public partial class HighScores : Form
    {
        List<string> names = new List<string>();
        List<int> scores = new List<int>();
        public HighScores()
        {
            InitializeComponent();
            GetStats();
            SortLists();
            DisplayData();
        }

        private void btnBack_click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetStats()
        {
            using (var reader = new StreamReader(@"Player Stats.csv"))
                //uses the same csv file i created earlier
            {

                //creates 2 lists, one for player name and another for their score
                while (!reader.EndOfStream)
                //runs until tend of the file
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    names.Add(values[0]);
                    scores.Add(Convert.ToInt32(values[1]));
                    //adds value to to the lists
                }
            }
        }
        public void SortLists()
        {
            int ScoreTemp;
            string NameTemp;
            for (int i = 0; i < scores.Count; i++)
            {
                for (int sort = 0; sort < scores.Count - 1; sort++)
                {
                    if (scores[sort] < scores[sort + 1])
                    {
                        ScoreTemp = scores[sort + 1];
                        NameTemp = names[sort + 1];
                        scores[sort + 1] = scores[sort];
                        names[sort + 1] = names[sort];
                        scores[sort] = ScoreTemp;
                        names[sort] = NameTemp;
                    }
                }
            }
        }
        private void DisplayData()
        {
            int i = 0;
            int order = 1;
            foreach (string name in names)
                //for every player thats been stored in the list names
            {
                if (order <= 10)
                {
                    lblNamesList.Text += (names[i] + "\n");
                    lblScoresList.Text += (scores[i] + "\n");
                    i++;
                    lblPos.Text += order + "\n";
                    order++;
                    //adds to the textbox then moves to the next line
                }
            }
            

        }


    }
}
        