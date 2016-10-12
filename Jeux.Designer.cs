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
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(46, 40);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(305, 13);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Comment s\'appelle le dernier Pirates des Caraïbes qui va sortir?";
            // 
            // rdb_rp1
            // 
            this.rdb_rp1.AutoSize = true;
            this.rdb_rp1.Location = new System.Drawing.Point(49, 97);
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
            this.rdb_rp2.Location = new System.Drawing.Point(49, 120);
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
            this.rdb_rp3.Location = new System.Drawing.Point(49, 143);
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
            this.rdb_rp4.Location = new System.Drawing.Point(49, 166);
            this.rdb_rp4.Name = "rdb_rp4";
            this.rdb_rp4.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp4.TabIndex = 4;
            this.rdb_rp4.TabStop = true;
            this.rdb_rp4.Text = "2020";
            this.rdb_rp4.UseVisualStyleBackColor = true;
            // 
            // Jeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 360);
            this.Controls.Add(this.rdb_rp4);
            this.Controls.Add(this.rdb_rp3);
            this.Controls.Add(this.rdb_rp2);
            this.Controls.Add(this.rdb_rp1);
            this.Controls.Add(this.lbl_Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeux";
            this.Text = "Jeux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.RadioButton rdb_rp1;
        private System.Windows.Forms.RadioButton rdb_rp2;
        private System.Windows.Forms.RadioButton rdb_rp3;
        private System.Windows.Forms.RadioButton rdb_rp4;
    }
}