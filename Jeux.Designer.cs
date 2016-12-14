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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoEllipsis = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(12, 9);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(537, 139);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Comment s\'appelle le dernier Pirates des Caraïbes qui va sortir?";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdb_rp1
            // 
            this.rdb_rp1.AutoSize = true;
            this.rdb_rp1.Location = new System.Drawing.Point(93, 182);
            this.rdb_rp1.Name = "rdb_rp1";
            this.rdb_rp1.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp1.TabIndex = 1;
            this.rdb_rp1.TabStop = true;
            this.rdb_rp1.Text = "2016";
            this.rdb_rp1.UseVisualStyleBackColor = true;
            this.rdb_rp1.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rdb_rp2
            // 
            this.rdb_rp2.AutoSize = true;
            this.rdb_rp2.Location = new System.Drawing.Point(93, 205);
            this.rdb_rp2.Name = "rdb_rp2";
            this.rdb_rp2.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp2.TabIndex = 2;
            this.rdb_rp2.TabStop = true;
            this.rdb_rp2.Text = "2017";
            this.rdb_rp2.UseVisualStyleBackColor = true;
            this.rdb_rp2.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rdb_rp3
            // 
            this.rdb_rp3.AutoSize = true;
            this.rdb_rp3.Location = new System.Drawing.Point(93, 228);
            this.rdb_rp3.Name = "rdb_rp3";
            this.rdb_rp3.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp3.TabIndex = 3;
            this.rdb_rp3.TabStop = true;
            this.rdb_rp3.Text = "2018";
            this.rdb_rp3.UseVisualStyleBackColor = true;
            this.rdb_rp3.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rdb_rp4
            // 
            this.rdb_rp4.AutoSize = true;
            this.rdb_rp4.Location = new System.Drawing.Point(93, 251);
            this.rdb_rp4.Name = "rdb_rp4";
            this.rdb_rp4.Size = new System.Drawing.Size(49, 17);
            this.rdb_rp4.TabIndex = 4;
            this.rdb_rp4.TabStop = true;
            this.rdb_rp4.Text = "2020";
            this.rdb_rp4.UseVisualStyleBackColor = true;
            this.rdb_rp4.Click += new System.EventHandler(this.btn_Next_Click);
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
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(12, 146);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 168);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 7;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(148, 146);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 168);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx2.TabIndex = 8;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(284, 146);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 168);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx3.TabIndex = 9;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(420, 146);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 168);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx4.TabIndex = 10;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(230, 162);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(100, 20);
            this.tbx_Name.TabIndex = 11;
            this.tbx_Name.TextChanged += new System.EventHandler(this.tbx_Name_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(227, 146);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(93, 13);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "Entrez votre nom :";
            // 
            // Jeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 360);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.rdb_rp4);
            this.Controls.Add(this.rdb_rp3);
            this.Controls.Add(this.rdb_rp2);
            this.Controls.Add(this.rdb_rp1);
            this.Controls.Add(this.lbl_Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jeux";
            this.Text = "Jeux";
            this.Load += new System.EventHandler(this.Jeux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.RadioButton rdb_rp1;
        private System.Windows.Forms.RadioButton rdb_rp2;
        private System.Windows.Forms.RadioButton rdb_rp3;
        private System.Windows.Forms.RadioButton rdb_rp4;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_Name;
    }
}