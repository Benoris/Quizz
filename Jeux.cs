using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<List<object>> reponses;

        int count = 0;

        int score = 0;

        const int ADDSCORE = 20;

        public Jeux()
        {
            InitializeComponent();

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public void UpdateView()
        {


            lbl_Question.Text = listQuestion[count][1];
            if (reponses[0][1].ToString().Length > 0)
            {

                rdb_rp1.Visible = true;
                rdb_rp2.Visible = true;
                rdb_rp3.Visible = true;
                rdb_rp4.Visible = true;

                pbx1.Visible = false;
                pbx2.Visible = false;
                pbx3.Visible = false;
                pbx4.Visible = false;

                rdb_rp1.Text = reponses[0][1].ToString();
                rdb_rp2.Text = reponses[1][1].ToString();
                rdb_rp3.Text = reponses[2][1].ToString();
                rdb_rp4.Text = reponses[3][1].ToString();
            }
            else
            {

                rdb_rp1.Visible = false;
                rdb_rp2.Visible = false;
                rdb_rp3.Visible = false;
                rdb_rp4.Visible = false;

                pbx1.Visible = true;
                pbx2.Visible = true;
                pbx3.Visible = true;
                pbx4.Visible = true;

                MemoryStream mStream;
                int increment = 0;
                foreach (var item in this.Controls)
                {
                    if (item is PictureBox)
                    {
                        mStream = new MemoryStream();
                        byte[] pData = (byte[])reponses[increment][2];
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        Bitmap bm = new Bitmap(mStream);
                        mStream.Dispose();
                        (item as PictureBox).Image = bm;
                        increment++;
                    }
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int s;
            int number = 0;
            char a;

            if (sender is PictureBox)
            {
                s = (sender as PictureBox).Name.Length;
                a = (sender as PictureBox).Name[s - 1];
                number = Convert.ToInt32((sender as PictureBox).Name[s - 1]);
            }
            else if (sender is RadioButton)
            {
                s = (sender as RadioButton).Name.Length;
                a = (sender as RadioButton).Name[s - 1];
                number = Convert.ToInt32((sender as RadioButton).Name[s - 1]);
                number = Convert.ToInt32(a);
            }
/*
            switch (number)
            {
                case 1:
                    if ((bool)reponses[0][3])
                    {
                        score += ADDSCORE;
                    }
                    break;
                case 2:
                    if ((bool)reponses[1][3])
                    {
                        score += ADDSCORE;
                    }
                    break;
                case 3:
                    if ((bool)reponses[2][3])
                    {
                        score += ADDSCORE;
                    }
                    break;
                case 4:
                    if ((bool)reponses[3][3])
                    {
                        score += ADDSCORE;
                    }
                    break;
                default:
                    break;
            }*/

            if ((bool)reponses[number - 1][3])
            {
                score += ADDSCORE;
            }

            if (count + 1 < listQuestion.Count)
            {
                count++;
                reponses = new List<List<object>>();
                foreach (List<object> item in models.ReadAnswersInDataBase("SELECT * FROM `tanswer` WHERE idQuestion = " + listQuestion[count][0] + " ORDER BY RAND()"))
                {
                    reponses.Add(item);
                }
                UpdateView();
            }
            else
            {
                lbl_Question.Text = "QUIZZ TERMINÉ!";

                pbx1.Visible = false;
                pbx2.Visible = false;
                pbx3.Visible = false;
                pbx4.Visible = false;

                rdb_rp1.Visible = false;
                rdb_rp2.Visible = false;
                rdb_rp3.Visible = false;
                rdb_rp4.Visible = false;


                btn_Quit.Enabled = false;

                lbl_Name.Visible = true;
                tbx_Name.Visible = true;
            }
        }

        private void Jeux_Load(object sender, EventArgs e)
        {
            foreach (List<string> item in models.GetTextData("SELECT * FROM tquestion ORDER BY RAND()"))
            {
                listQuestion.Add(item);
            }
            reponses = new List<List<object>>();
            foreach (List<object> item in models.ReadAnswersInDataBase("SELECT * FROM `tanswer` WHERE idQuestion = " + listQuestion[count][0] + " ORDER BY RAND()"))
            {
                reponses.Add(item);
            }
            UpdateView();

            lbl_Name.Visible = false;
            tbx_Name.Visible = false;
        }

        private void tbx_Name_TextChanged(object sender, EventArgs e)
        {
            if (tbx_Name.Text == "")
            {
                btn_Quit.Enabled = false;
            }
            else
            {
                btn_Quit.Enabled = true;
            }
        }
    }
}
