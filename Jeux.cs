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
    public partial class Jeux : Form
    {
        Models models = new Models();
        List<List<string>> listQuestion = new List<List<string>>();
        List<List<string>> reponses;
        List<List<string>> questlist = new List<List<string>>();
        Question que;
        int count = 0;
        int length;

        public Jeux()
        {
            InitializeComponent();
            MessageBox.Show(models.ReadPicturesInDataBase("SELECT Question FROM tquestion")[0].ToString());

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateView()
        {
            
                lbl_Question.Text = listQuestion[count][1];
            rdb_rp1.Text = que.Option[0];
            rdb_rp2.Text = que.Option[1];
            rdb_rp3.Text = que.Option[2];
            rdb_rp4.Text = que.Option[3];
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (count + 1 < listQuestion.Count){
                count++;
                reponses = new List<List<string>>();
                foreach (List<string> item in models.GetTextData("SELECT * FROM `tanswer` WHERE idQuestion = " + listQuestion[count][0]))
                {
                    reponses.Add(item);
                }
                UpdateView();
            }
            else
            {
                lbl_Question.Text = "fin";
            }
        }

        private void Jeux_Load(object sender, EventArgs e)
        {
            foreach (List<string> item in models.GetTextData("SELECT * FROM tquestion"))
            {
                listQuestion.Add(item);
                length = questlist.Count;
            }
            reponses = new List<List<string>>();
            foreach (List<string> item in models.GetTextData("SELECT * FROM `tanswer` WHERE idQuestion = "+listQuestion[1][0]))
            {
                reponses.Add(item);
            }
            que = new Question(listQuestion[0][1], reponses[1][1], reponses[0][1], reponses[2][1], reponses[3][1]);
            UpdateView();
        }

        private void NextQuestion()
        {
            
        }
    }
}
