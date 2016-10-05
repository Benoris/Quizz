namespace Projet_Quizz
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_ShowCreator = new System.Windows.Forms.Button();
            this.btn_Score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(78, 35);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(86, 34);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Jouer";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_ShowCreator
            // 
            this.btn_ShowCreator.Location = new System.Drawing.Point(254, 35);
            this.btn_ShowCreator.Name = "btn_ShowCreator";
            this.btn_ShowCreator.Size = new System.Drawing.Size(185, 34);
            this.btn_ShowCreator.TabIndex = 1;
            this.btn_ShowCreator.Text = "Afficher le créateur de questions";
            this.btn_ShowCreator.UseVisualStyleBackColor = true;
            this.btn_ShowCreator.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Score
            // 
            this.btn_Score.Location = new System.Drawing.Point(179, 110);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(86, 34);
            this.btn_Score.TabIndex = 2;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = true;
            this.btn_Score.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 180);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.btn_ShowCreator);
            this.Controls.Add(this.btn_Play);
            this.Name = "Form1";
            this.Text = "Quizz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_ShowCreator;
        private System.Windows.Forms.Button btn_Score;
    }
}

