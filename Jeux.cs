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
        Question ques;
        public Jeux()
        {
            InitializeComponent();
            ques = new Question("Qui est la femme de De Niro?","Celle que vous avez \"buck\"?","Monica Belluci","Bendersdick Brokenback","Sasha de pokémon");
            UpdateView();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateView()
        {
            lbl_Question.Text = ques.Question1;
            rdb_rp1.Text = ques.Option[0];
            rdb_rp2.Text = ques.Option[1];
            rdb_rp3.Text = ques.Option[2];
            rdb_rp4.Text = ques.Option[3];
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            ques = new Question("Ou se trouve l'Asie?", "À l'Est de l'Europe", "De quoi? La Chine?", "Au Nord", "420 Blaze it");
            UpdateView();
        }

    }
}
