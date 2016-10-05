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
    public partial class QuestionCreator : Form
    {
        public QuestionCreator()
        {
            InitializeComponent();
            cmb_QuestType.SelectedIndex = 0;
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
        }
    }
}
