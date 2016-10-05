namespace Projet_Quizz
{
    partial class Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_ListeJoueur = new System.Windows.Forms.ListBox();
            this.lbl_ListeJoueur = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_NumScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_ListeJoueur
            // 
            this.lbx_ListeJoueur.FormattingEnabled = true;
            this.lbx_ListeJoueur.Location = new System.Drawing.Point(12, 45);
            this.lbx_ListeJoueur.Name = "lbx_ListeJoueur";
            this.lbx_ListeJoueur.Size = new System.Drawing.Size(179, 264);
            this.lbx_ListeJoueur.TabIndex = 0;
            // 
            // lbl_ListeJoueur
            // 
            this.lbl_ListeJoueur.AutoSize = true;
            this.lbl_ListeJoueur.Location = new System.Drawing.Point(39, 29);
            this.lbl_ListeJoueur.Name = "lbl_ListeJoueur";
            this.lbl_ListeJoueur.Size = new System.Drawing.Size(97, 13);
            this.lbl_ListeJoueur.TabIndex = 2;
            this.lbl_ListeJoueur.Text = "La liste des joueurs";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(211, 101);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(41, 13);
            this.lbl_Score.TabIndex = 3;
            this.lbl_Score.Text = "Score :";
            // 
            // lbl_NumScore
            // 
            this.lbl_NumScore.AutoSize = true;
            this.lbl_NumScore.Location = new System.Drawing.Point(258, 101);
            this.lbl_NumScore.Name = "lbl_NumScore";
            this.lbl_NumScore.Size = new System.Drawing.Size(41, 13);
            this.lbl_NumScore.TabIndex = 4;
            this.lbl_NumScore.Text = "Score :";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.Controls.Add(this.lbl_NumScore);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_ListeJoueur);
            this.Controls.Add(this.lbx_ListeJoueur);
            this.Name = "Score";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_ListeJoueur;
        private System.Windows.Forms.Label lbl_ListeJoueur;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_NumScore;
    }
}