using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Quizz
{
    public partial class Score : Form
    {        
        List<List<string>> list2 = new List<List<string>>();
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            list2.Add(new List<string> { "Leila", "30" });
            list2.Add(new List<string> { "Hulk", "50" });
            list2.Add(new List<string> { "Tony", "100" });
            list2.Add(new List<string> { "Bob", "48" });
            
            for (int i = 0; i < list2.Count; i++)
            {
                lsb_ListeJoueur.Items.Add(list2[i][0]);
            }
            

        }

        private void lsb_ListeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NumScore.Text = list2[lsb_ListeJoueur.SelectedIndex][1];
        }
    }
}
