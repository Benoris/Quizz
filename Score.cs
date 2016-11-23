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
        Models model = new Models();
        
        public Score()
        {
            InitializeComponent();
           
            model.StartConnectionWithBDD("10.134.181.213", "Quizz", "Quizz", "SuperC101");

            foreach (List<string> item in model.GetTextData("SELECT `NameUser`, `Score` FROM `tuser`"))
            {
                list2.Add(item);
                lsb_ListeJoueur.Items.Add(item[0]);
            }

            model.CloseConnectionWithBDD();
        }

        private void Score_Load(object sender, EventArgs e)
        {


            /*list2.Add(new List<string> { "Leila", "30" });
            list2.Add(new List<string> { "Hulk", "50" });
            list2.Add(new List<string> { "Tony", "100" });
            list2.Add(new List<string> { "Bob", "48" });
            
            for (int i = 0; i < list2.Count; i++)
            {
                lsb_ListeJoueur.Items.Add(list2[i][0]);
            }*/

            lbl_Connect.Text = model.Status;
        }

        private void lsb_ListeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NumScore.Text = list2[lsb_ListeJoueur.SelectedIndex][1];
            
        }
    }
}
