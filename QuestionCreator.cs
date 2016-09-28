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
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            DialogResult result = fdb.ShowDialog();
            MessageBox.Show(result.ToString());

        }
    }
}
