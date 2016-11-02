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


namespace Projet_Quizz
{
    public partial class QuestionCreator : Form
    {

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
            string ConnexionString = "SERVER=10.134.181.213; DATABASE=Quizz; UID=Quizz; PASSWORD=SuperC101";
            MySqlConnection connectionBase = new MySqlConnection(ConnexionString);

            try
            {
                connectionBase.Open();
                MessageBox.Show("Connection Ouverte");

                /*MySqlCommand commande = connectionBase.CreateCommand();

                commande.CommandText = "INSERT INTO `tquestion`(`TextQuestion`) VALUES ('Test Question 2')";
                commande.ExecuteNonQuery();*/
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
            }
        }

        private void btn_ValidChange()
        {
            if (cmb_QuestType.SelectedIndex == 0)
            {
                if (tbx_Rep1.Text != "" && tbx_Rep2.Text != "" && tbx_Rep3.Text != "" && tbx_Rep4.Text != "")
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
                if (pb_Rep1.Image != null && pb_Rep2.Image != null && pb_Rep3.Image != null && pb_Rep4.Image != null)
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
