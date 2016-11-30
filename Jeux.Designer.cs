namespace Projet_Quizz
{
    partial class Jeux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeux));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.rdb_rp1 = new System.Windows.Forms.RadioButton();
            this.rdb_rp2 = new System.Windows.Forms.RadioButton();
            this.rdb_rp3 = new System.Windows.Forms.RadioButton();
            this.rdb_rp4 = new System.Windows.Forms.RadioButton();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(135, 43);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(305, 13);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Comment s\'appelle le dernier Pirates des Caraïbes qui va sortir?";
            // 
            // rdb_rp1
            // 
            this.rdb_rp1.AutoSize = true;
            this.rdb_rp1.Location = new System.Drawing.Point(293, 127);
            this.rdb_rp1.Name = "rdb_rp1";
            this.rdb_rp1.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp1.TabIndex = 1;
            this.rdb_rp1.TabStop = true;
            this.rdb_rp1.Text = "2016";
            this.rdb_rp1.UseVisualStyleBackColor = true;
            // 
            // rdb_rp2
            // 
            this.rdb_rp2.AutoSize = true;
            this.rdb_rp2.Location = new System.Drawing.Point(293, 150);
            this.rdb_rp2.Name = "rdb_rp2";
            this.rdb_rp2.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp2.TabIndex = 2;
            this.rdb_rp2.TabStop = true;
            this.rdb_rp2.Text = "2017";
            this.rdb_rp2.UseVisualStyleBackColor = true;
            // 
            // rdb_rp3
            // 
            this.rdb_rp3.AutoSize = true;
            this.rdb_rp3.Location = new System.Drawing.Point(293, 173);
            this.rdb_rp3.Name = "rdb_rp3";
            this.rdb_rp3.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp3.TabIndex = 3;
            this.rdb_rp3.TabStop = true;
            this.rdb_rp3.Text = "2018";
            this.rdb_rp3.UseVisualStyleBackColor = true;
            // 
            // rdb_rp4
            // 
            this.rdb_rp4.AutoSize = true;
            this.rdb_rp4.Location = new System.Drawing.Point(293, 196);
            this.rdb_rp4.Name = "rdb_rp4";
            this.rdb_rp4.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp4.TabIndex = 4;
            this.rdb_rp4.TabStop = true;
            this.rdb_rp4.Text = "2020";
            this.rdb_rp4.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(475, 325);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(13, 325);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 6;
            this.btn_Quit.Text = "Quitter";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // Jeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 360);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.rdb_rp4);
            this.Controls.Add(this.rdb_rp3);
            this.Controls.Add(this.rdb_rp2);
            this.Controls.Add(this.rdb_rp1);
            this.Controls.Add(this.lbl_Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeux";
            this.Text = "Jeux";
            this.Load += new System.EventHandler(this.Jeux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.RadioButton rdb_rp1;
        private System.Windows.Forms.RadioButton rdb_rp2;
        private System.Windows.Forms.RadioButton rdb_rp3;
        private System.Windows.Forms.RadioButton rdb_rp4;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Quit;
    }
}