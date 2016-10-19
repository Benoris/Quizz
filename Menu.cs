﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionCreator QC = new QuestionCreator();
            QC.ShowDialog();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Jeux J = new Jeux();
            J.ShowDialog();
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            Score Score = new Score();
            Score.ShowDialog();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
