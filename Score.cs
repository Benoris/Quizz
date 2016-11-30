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

            foreach (List<string> item in model.GetTextData("SELECT `NameUser`, `Score` FROM `tuser`"))
            {
                list2.Add(item);
                lsb_ListeJoueur.Items.Add(item[0]);
            }            
        }

        private void Score_Load(object sender, EventArgs e)
        {           
            lbl_Connect.Text = model.Status;
        }

        private void lsb_ListeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_NumScore.Text = list2[lsb_ListeJoueur.SelectedIndex][1];
            
        }

        private void btn_QuitterScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
