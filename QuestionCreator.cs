using System;
using System.Collections.Generic;
using System.ComponentModel;
//
//using System.Data;
//using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
//
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projet_Quizz
{
    public partial class QuestionCreator : Form
    {
        Models model = new Models();
        List<TextBox> list_TbxAnswers = new List<TextBox>();


        public QuestionCreator()
        {
            InitializeComponent();
            cmb_QuestType.SelectedIndex = 0;

            MessageBox.Show(model.ReadAnswersInDataBase("SELECT * FROM tanswer")[10][1].ToString());

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    /*if((item as TextBox).Name.ToLower().Contains(''))
                    {
                        //comp = StringComparison.OrdinalIgnoreCase;
                        //Console.WriteLine("   {0:G}: {1}", comp, s.Contains(sub1, comp));
                    }*/
                }
            }
        }

        private void btn_OpenImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Images BMP (*.bmp)|*.bmp|Images PNG (*.png)|*.png|Images JPG(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_Rep1.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            btn_ValidChange();
        }

        private void btn_OpenImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Images BMP (*.bmp)|*.bmp|Images PNG (*.png)|*.png|Images JPG(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_Rep2.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            btn_ValidChange();
        }

        private void btn_OpenImage3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Images BMP (*.bmp)|*.bmp|Images PNG (*.png)|*.png|Images JPG(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_Rep3.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            btn_ValidChange();
        }

        private void btn_OpenImage4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Images BMP (*.bmp)|*.bmp|Images PNG (*.png)|*.png|Images JPG(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_Rep4.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            btn_ValidChange();
        }

        private void cmb_QuestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                //To enable
                changeEnableState(tbx_Rep1, true);
                changeEnableState(tbx_Rep2, true);
                changeEnableState(tbx_Rep3, true);
                changeEnableState(tbx_Rep4, true);

                //To disable
                changeEnableState(pb_Rep1, false);
                changeEnableState(pb_Rep2, false);
                changeEnableState(pb_Rep3, false);
                changeEnableState(pb_Rep4, false);
                changeEnableState(btn_OpenImage1, false);
                changeEnableState(btn_OpenImage2, false);
                changeEnableState(btn_OpenImage3, false);
                changeEnableState(btn_OpenImage4, false);
            }
            else if ((sender as ComboBox).SelectedIndex == 1)
            {
                //To disable
                changeEnableState(tbx_Rep1, false);
                changeEnableState(tbx_Rep2, false);
                changeEnableState(tbx_Rep3, false);
                changeEnableState(tbx_Rep4, false);

                //To enable
                changeEnableState(pb_Rep1, true);
                changeEnableState(pb_Rep2, true);
                changeEnableState(pb_Rep3, true);
                changeEnableState(pb_Rep4, true);
                changeEnableState(btn_OpenImage1, true);
                changeEnableState(btn_OpenImage2, true);
                changeEnableState(btn_OpenImage3, true);
                changeEnableState(btn_OpenImage4, true);
            }

            btn_ValidChange();

        }

        public void changeEnableState(Control a, bool enableOrNot)
        {
            a.Enabled = enableOrNot;
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            List<object> Questions = new List<object>();
            List<List<object>> Reponses = new List<List<object>>();

            Questions.Add(tbx_Question.Text);

            int lastQuestionId = model.WriteQuestionInDataBase("INSERT INTO tquestion (Question) VALUES", Questions);
            int fau = 0;

            if (cmb_QuestType.SelectedIndex == 0)
            {
                List<object> l1 = new List<object>();
                List<object> l2 = new List<object>();
                List<object> l3 = new List<object>();
                List<object> l4 = new List<object>();

                l1.Add(tbx_Rep1.Text);
                l2.Add(tbx_Rep2.Text);
                l3.Add(tbx_Rep3.Text);
                l4.Add(tbx_Rep4.Text);

                l1.Add(fau);
                l2.Add(fau);
                l3.Add(fau);
                l4.Add(fau);

                l1.Add(lastQuestionId);
                l2.Add(lastQuestionId);
                l3.Add(lastQuestionId);
                l4.Add(lastQuestionId);

                if (rdb_CorrectAnswer1.Checked)
                {
                    //MessageBox.Show(Questions[1].ToString());
                    l1[1] = 1;
                }
                if (rdb_CorrectAnswer2.Checked)
                {
                    //MessageBox.Show(Questions[2].ToString());
                    l2[1] = 1;
                }
                if (rdb_CorrectAnswer3.Checked)
                {
                    //MessageBox.Show(Questions[3].ToString());
                    l3[1] = 1;
                }
                if (rdb_CorrectAnswer4.Checked)
                {
                    //MessageBox.Show(Questions[4].ToString());
                    l4[1] = 1;
                }

                Reponses.Add(l1);
                Reponses.Add(l2);
                Reponses.Add(l3);
                Reponses.Add(l4);

                model.WirteAnswersInDataBase("INSERT INTO tanswer (Answer,isCorrect,idQuestion) VALUES", Reponses);

            }
            else if (cmb_QuestType.SelectedIndex == 1)
            {
                ImageConverter converter = new ImageConverter();

                List<object> l1 = new List<object>();
                List<object> l2 = new List<object>();
                List<object> l3 = new List<object>();
                List<object> l4 = new List<object>();

                l1.Add((byte[])converter.ConvertTo(pb_Rep1.Image, typeof(byte[])));
                l2.Add((byte[])converter.ConvertTo(pb_Rep2.Image, typeof(byte[])));
                l3.Add((byte[])converter.ConvertTo(pb_Rep3.Image, typeof(byte[])));
                l4.Add((byte[])converter.ConvertTo(pb_Rep4.Image, typeof(byte[])));

                l1.Add(fau);
                l2.Add(fau);
                l3.Add(fau);
                l4.Add(fau);

                l1.Add(lastQuestionId);
                l2.Add(lastQuestionId);
                l3.Add(lastQuestionId);
                l4.Add(lastQuestionId);

                if (rdb_CorrectAnswer1.Checked)
                {
                    //MessageBox.Show(Questions[1].ToString());
                    l1[1] = 1;
                }
                if (rdb_CorrectAnswer2.Checked)
                {
                    //MessageBox.Show(Questions[2].ToString());
                    l2[1] = 1;
                }
                if (rdb_CorrectAnswer3.Checked)
                {
                    //MessageBox.Show(Questions[3].ToString());
                    l3[1] = 1;
                }
                if (rdb_CorrectAnswer4.Checked)
                {
                    //MessageBox.Show(Questions[4].ToString());
                    l4[1] = 1;
                }

                Reponses.Add(l1);
                Reponses.Add(l2);
                Reponses.Add(l3);
                Reponses.Add(l4);

                model.WirteAnswersInDataBase("INSERT INTO tanswer (Image,isCorrect,idQuestion) VALUES", Reponses);
                //pictureBox1.Image = (Image)model.readBd2()[0];

                /*MemoryStream mStream = new MemoryStream();
                byte[] pData = (byte[])model.ReadPicturesInDataBase("SELECT imgtest FROM ttest")[8];
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream);
                mStream.Dispose();
                pictureBox1.Image = bm;*/

            }

            resetView();

        }

        private void btn_ValidChange()
        {
            if (cmb_QuestType.SelectedIndex == 0)
            {
                if (tbx_Rep1.Text != "" && tbx_Rep2.Text != "" && tbx_Rep3.Text != "" && tbx_Rep4.Text != "" && tbx_Question.Text != "")
                {
                    btn_AddQuestion.Enabled = true;
                }
                else
                {
                    btn_AddQuestion.Enabled = false;
                }
            }
            else if (cmb_QuestType.SelectedIndex == 1)
            {
                if (pb_Rep1.Image != null && pb_Rep2.Image != null && pb_Rep3.Image != null && pb_Rep4.Image != null && tbx_Question.Text != "")
                {
                    btn_AddQuestion.Enabled = true;
                }
                else
                {
                    btn_AddQuestion.Enabled = false;
                }
            }
            else
            {
                btn_AddQuestion.Enabled = false;
            }
        }

        private void tbx_Rep1_TextChanged(object sender, EventArgs e)
        {
            btn_ValidChange();
        }

        private void resetView()
        {
            tbx_Question.Text = "";
            tbx_Rep1.Text = "";
            tbx_Rep2.Text = "";
            tbx_Rep3.Text = "";
            tbx_Rep4.Text = "";

            pb_Rep1.Image = null;
            pb_Rep2.Image = null;
            pb_Rep3.Image = null;
            pb_Rep4.Image = null;
        }


    }
}
