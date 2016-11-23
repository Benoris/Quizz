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
            else if((sender as ComboBox).SelectedIndex == 1)
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
            List<object> a = new List<object>();
            /*string ConnexionString = "SERVER=10.134.181.213; DATABASE=Quizz; UID=Quizz; PASSWORD=SuperC101";
            MySqlConnection connectionBase = new MySqlConnection(ConnexionString);

            try
            {
                connectionBase.Open();
                MessageBox.Show("Connection Ouverte");

                //MySqlCommand commande = connectionBase.CreateCommand();

                //commande.CommandText = "INSERT INTO `tquestion`(`TextQuestion`) VALUES ('Test Question 2')";
                //commande.ExecuteNonQuery();
                //connectionBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                connectionBase.Close();
                MessageBox.Show("Connection Fermée");
            }*/
            a.Add(tbx_Question.Text);

            if (cmb_QuestType.SelectedIndex == 0)
            {
                a.Add(tbx_Rep1.Text);
                a.Add(tbx_Rep2.Text);
                a.Add(tbx_Rep3.Text);
                a.Add(tbx_Rep4.Text);

                MessageBox.Show(a[0].ToString());

                if (rdb_CorrectAnswer1.Checked)
                {
                    MessageBox.Show(a[1].ToString());
                }
                if (rdb_CorrectAnswer2.Checked)
                {
                    MessageBox.Show(a[2].ToString());
                }
                if (rdb_CorrectAnswer3.Checked)
                {
                    MessageBox.Show(a[3].ToString());
                }
                if (rdb_CorrectAnswer4.Checked)
                {
                    MessageBox.Show(a[4].ToString());
                }

                model.WirtePicturesInDataBase("d", a);
                
            }
            else if (cmb_QuestType.SelectedIndex == 1)
            {
                ImageConverter converter = new ImageConverter();
                a.Add((byte[])converter.ConvertTo(pb_Rep1.Image, typeof(byte[])));

                a.Add(pb_Rep1.Image);
                a.Add(pb_Rep2.Image);
                a.Add(pb_Rep3.Image);
                a.Add(pb_Rep4.Image);

                

                MessageBox.Show(a[0].ToString());

                if (rdb_CorrectAnswer1.Checked)
                {
                    pictureBox1.Image = (Image)a[1];
                }
                if (rdb_CorrectAnswer2.Checked)
                {
                    pictureBox1.Image = (Image)a[2];
                }
                if (rdb_CorrectAnswer3.Checked)
                {
                    pictureBox1.Image = (Image)a[3];
                }
                if (rdb_CorrectAnswer4.Checked)
                {
                    pictureBox1.Image = (Image)a[4];
                }

                model.WirtePicturesInDataBase("d", a);
                //pictureBox1.Image = (Image)model.readBd2()[0];

                MemoryStream mStream = new MemoryStream();
                byte[] pData = (byte[])model.ReadPicturesInDataBase("SELECT imgtest FROM ttest")[0];
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream);
                mStream.Dispose();
                pictureBox1.Image = bm;
            }
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

        
    }
}
