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
            this.lsb_ListeJoueur = new System.Windows.Forms.ListBox();
            this.lbl_ListeJoueur = new System.Windows.Forms.Label();
            this.btn_QuitterScore = new System.Windows.Forms.Button();
            this.lbl_NumScore = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsb_ListeJoueur
            // 
            this.lsb_ListeJoueur.FormattingEnabled = true;
            this.lsb_ListeJoueur.Location = new System.Drawing.Point(12, 32);
            this.lsb_ListeJoueur.Name = "lsb_ListeJoueur";
            this.lsb_ListeJoueur.Size = new System.Drawing.Size(179, 277);
            this.lsb_ListeJoueur.TabIndex = 0;
            this.lsb_ListeJoueur.SelectedIndexChanged += new System.EventHandler(this.lsb_ListeJoueur_SelectedIndexChanged);
            // 
            // lbl_ListeJoueur
            // 
            this.lbl_ListeJoueur.AutoSize = true;
            this.lbl_ListeJoueur.Location = new System.Drawing.Point(39, 9);
            this.lbl_ListeJoueur.Name = "lbl_ListeJoueur";
            this.lbl_ListeJoueur.Size = new System.Drawing.Size(97, 13);
            this.lbl_ListeJoueur.TabIndex = 2;
            this.lbl_ListeJoueur.Text = "La liste des joueurs";
            // 
            // btn_QuitterScore
            // 
            this.btn_QuitterScore.Location = new System.Drawing.Point(238, 286);
            this.btn_QuitterScore.Name = "btn_QuitterScore";
            this.btn_QuitterScore.Size = new System.Drawing.Size(75, 23);
            this.btn_QuitterScore.TabIndex = 5;
            this.btn_QuitterScore.Text = "Quitter";
            this.btn_QuitterScore.UseVisualStyleBackColor = true;
            // 
            // lbl_NumScore
            // 
            this.lbl_NumScore.AutoSize = true;
            this.lbl_NumScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumScore.Location = new System.Drawing.Point(287, 71);
            this.lbl_NumScore.Name = "lbl_NumScore";
            this.lbl_NumScore.Size = new System.Drawing.Size(42, 20);
            this.lbl_NumScore.TabIndex = 4;
            this.lbl_NumScore.Text = "Num";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(210, 71);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(59, 20);
            this.lbl_Score.TabIndex = 3;
            this.lbl_Score.Text = "Score :";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 331);
            this.Controls.Add(this.btn_QuitterScore);
            this.Controls.Add(this.lbl_NumScore);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_ListeJoueur);
            this.Controls.Add(this.lsb_ListeJoueur);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_ListeJoueur;
        private System.Windows.Forms.Label lbl_ListeJoueur;
        private System.Windows.Forms.Button btn_QuitterScore;
        private System.Windows.Forms.Label lbl_NumScore;
        private System.Windows.Forms.Label lbl_Score;
    }
}