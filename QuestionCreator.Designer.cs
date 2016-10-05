namespace Projet_Quizz
{
    partial class QuestionCreator
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
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tbx_Question = new System.Windows.Forms.TextBox();
            this.gb_Answer1 = new System.Windows.Forms.GroupBox();
            this.cmb_QuestType = new System.Windows.Forms.ComboBox();
            this.rdb_CorrectAnswer2 = new System.Windows.Forms.RadioButton();
            this.gb_Answer2 = new System.Windows.Forms.GroupBox();
            this.rdb_CorrectAnswer1 = new System.Windows.Forms.RadioButton();
            this.gb_Answer3 = new System.Windows.Forms.GroupBox();
            this.rdb_CorrectAnswer3 = new System.Windows.Forms.RadioButton();
            this.gb_Answer4 = new System.Windows.Forms.GroupBox();
            this.rdb_CorrectAnswer4 = new System.Windows.Forms.RadioButton();
            this.pb_Rep1 = new System.Windows.Forms.PictureBox();
            this.tbx_Rep1 = new System.Windows.Forms.TextBox();
            this.lbl_Rep1 = new System.Windows.Forms.Label();
            this.btn_OpenImage1 = new System.Windows.Forms.Button();
            this.gb_Answer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(12, 9);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(81, 13);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "Votre question :";
            // 
            // tbx_Question
            // 
            this.tbx_Question.Location = new System.Drawing.Point(12, 25);
            this.tbx_Question.Multiline = true;
            this.tbx_Question.Name = "tbx_Question";
            this.tbx_Question.Size = new System.Drawing.Size(471, 112);
            this.tbx_Question.Size = new System.Drawing.Size(297, 69);
            this.tbx_Question.TabIndex = 1;
            // 
            // gb_Answer1
            // 
            this.gb_Answer1.Controls.Add(this.btn_OpenImage1);
            this.gb_Answer1.Controls.Add(this.lbl_Rep1);
            this.gb_Answer1.Controls.Add(this.tbx_Rep1);
            this.gb_Answer1.Controls.Add(this.pb_Rep1);
            this.gb_Answer1.Location = new System.Drawing.Point(15, 166);
            this.gb_Answer1.Name = "gb_Answer1";
            this.gb_Answer1.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer1.TabIndex = 2;
            this.gb_Answer1.TabStop = false;
            this.gb_Answer1.Text = "Reponse 1";
            // 
            // cmb_QuestType
            // 
            this.cmb_QuestType.FormattingEnabled = true;
            this.cmb_QuestType.Items.AddRange(new object[] {
            "Text",
            "Images"});
            this.cmb_QuestType.Location = new System.Drawing.Point(736, 25);
            this.cmb_QuestType.Location = new System.Drawing.Point(736, 60);
            this.cmb_QuestType.Name = "cmb_QuestType";
            this.cmb_QuestType.Size = new System.Drawing.Size(221, 21);
            this.cmb_QuestType.TabIndex = 0;
            // 
            // rdb_CorrectAnswer2
            // 
            this.rdb_CorrectAnswer2.AutoSize = true;
            this.rdb_CorrectAnswer2.Location = new System.Drawing.Point(312, 143);
            this.rdb_CorrectAnswer2.Name = "rdb_CorrectAnswer2";
            this.rdb_CorrectAnswer2.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer2.TabIndex = 0;
            this.rdb_CorrectAnswer2.Location = new System.Drawing.Point(331, 143);
            this.rdb_CorrectAnswer2.Name = "rdb_CorrectAnswer2";
            this.rdb_CorrectAnswer2.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer2.TabIndex = 0;
            this.rdb_CorrectAnswer2.TabStop = true;
            this.rdb_CorrectAnswer2.Text = "Correcte";
            this.rdb_CorrectAnswer2.UseVisualStyleBackColor = true;
            // 
            // gb_Answer2
            // 
            this.gb_Answer2.Location = new System.Drawing.Point(252, 166);
            this.gb_Answer2.Name = "gb_Answer2";
            this.gb_Answer2.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer2.TabIndex = 3;
            this.gb_Answer2.TabStop = false;
            this.gb_Answer2.Text = "Reponse 2";
            // 
            // rdb_CorrectAnswer1
            // 
            this.rdb_CorrectAnswer1.AutoSize = true;
            this.rdb_CorrectAnswer1.Checked = true;
            this.rdb_CorrectAnswer1.Location = new System.Drawing.Point(74, 143);
            this.rdb_CorrectAnswer1.Location = new System.Drawing.Point(89, 143);
            this.rdb_CorrectAnswer1.Name = "rdb_CorrectAnswer1";
            this.rdb_CorrectAnswer1.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer1.TabIndex = 0;
            this.rdb_CorrectAnswer1.TabStop = true;
            this.rdb_CorrectAnswer1.Text = "Correcte";
            this.rdb_CorrectAnswer1.UseVisualStyleBackColor = true;
            // 
            // gb_Answer3
            // 
            this.gb_Answer3.Location = new System.Drawing.Point(489, 166);
            this.gb_Answer3.Name = "gb_Answer3";
            this.gb_Answer3.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer3.TabIndex = 3;
            this.gb_Answer3.TabStop = false;
            this.gb_Answer3.Text = "Reponse 3";
            // 
            // rdb_CorrectAnswer3
            // 
            this.rdb_CorrectAnswer3.AutoSize = true;
            this.rdb_CorrectAnswer3.Location = new System.Drawing.Point(548, 143);
            this.rdb_CorrectAnswer3.Name = "rdb_CorrectAnswer3";
            this.rdb_CorrectAnswer3.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer3.TabIndex = 0;
            this.rdb_CorrectAnswer3.Location = new System.Drawing.Point(568, 143);
            this.rdb_CorrectAnswer3.Name = "rdb_CorrectAnswer3";
            this.rdb_CorrectAnswer3.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer3.TabIndex = 0;
            this.rdb_CorrectAnswer3.TabStop = true;
            this.rdb_CorrectAnswer3.Text = "Correcte";
            this.rdb_CorrectAnswer3.UseVisualStyleBackColor = true;
            // 
            // gb_Answer4
            // 
            this.gb_Answer4.Location = new System.Drawing.Point(726, 166);
            this.gb_Answer4.Name = "gb_Answer4";
            this.gb_Answer4.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer4.TabIndex = 3;
            this.gb_Answer4.TabStop = false;
            this.gb_Answer4.Text = "Reponse 4";
            // 
            // rdb_CorrectAnswer4
            // 
            this.rdb_CorrectAnswer4.AutoSize = true;
            this.rdb_CorrectAnswer4.Location = new System.Drawing.Point(783, 143);
            this.rdb_CorrectAnswer4.Name = "rdb_CorrectAnswer4";
            this.rdb_CorrectAnswer4.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer4.TabIndex = 0;
            this.rdb_CorrectAnswer4.Text = "Correcte";
            this.rdb_CorrectAnswer4.UseVisualStyleBackColor = true;
            // 
            this.rdb_CorrectAnswer4.Location = new System.Drawing.Point(806, 143);
            this.rdb_CorrectAnswer4.Name = "rdb_CorrectAnswer4";
            this.rdb_CorrectAnswer4.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer4.TabIndex = 0;
            this.rdb_CorrectAnswer4.TabStop = true;
            this.rdb_CorrectAnswer4.Text = "Correcte";
            this.rdb_CorrectAnswer4.UseVisualStyleBackColor = true;
            // 
            // pb_Rep1
            // 
            this.pb_Rep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Rep1.Location = new System.Drawing.Point(6, 129);
            this.pb_Rep1.Name = "pb_Rep1";
            this.pb_Rep1.Size = new System.Drawing.Size(219, 276);
            this.pb_Rep1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Rep1.TabIndex = 0;
            this.pb_Rep1.TabStop = false;
            // 
            // tbx_Rep1
            // 
            this.tbx_Rep1.Location = new System.Drawing.Point(6, 31);
            this.tbx_Rep1.Multiline = true;
            this.tbx_Rep1.Name = "tbx_Rep1";
            this.tbx_Rep1.Size = new System.Drawing.Size(219, 55);
            this.tbx_Rep1.TabIndex = 1;
            // 
            // lbl_Rep1
            // 
            this.lbl_Rep1.AutoSize = true;
            this.lbl_Rep1.Location = new System.Drawing.Point(6, 16);
            this.lbl_Rep1.Name = "lbl_Rep1";
            this.lbl_Rep1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Rep1.TabIndex = 2;
            this.lbl_Rep1.Text = "Réponse :";
            // 
            // btn_OpenImage1
            // 
            this.btn_OpenImage1.Location = new System.Drawing.Point(9, 100);
            this.btn_OpenImage1.Name = "btn_OpenImage1";
            this.btn_OpenImage1.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenImage1.TabIndex = 3;
            this.btn_OpenImage1.Text = "Sélectionner Image";
            this.btn_OpenImage1.UseVisualStyleBackColor = true;
            this.btn_OpenImage1.Click += new System.EventHandler(this.btn_OpenImage1_Click);
            // 
            // QuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 589);
            this.Controls.Add(this.rdb_CorrectAnswer4);
            this.Controls.Add(this.rdb_CorrectAnswer3);
            this.Controls.Add(this.rdb_CorrectAnswer2);
            this.Controls.Add(this.rdb_CorrectAnswer1);
            this.Controls.Add(this.gb_Answer4);
            this.Controls.Add(this.gb_Answer3);
            this.Controls.Add(this.gb_Answer2);
            this.Controls.Add(this.cmb_QuestType);
            this.Controls.Add(this.gb_Answer1);
            this.Controls.Add(this.tbx_Question);
            this.Controls.Add(this.lbl_Question);
            this.Name = "QuestionCreator";
            this.Text = "QuestionCreator";
            this.gb_Answer1.ResumeLayout(false);
            this.gb_Answer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox tbx_Question;
        private System.Windows.Forms.GroupBox gb_Answer1;
        private System.Windows.Forms.RadioButton rdb_CorrectAnswer2;
        private System.Windows.Forms.ComboBox cmb_QuestType;
        private System.Windows.Forms.GroupBox gb_Answer2;
        private System.Windows.Forms.RadioButton rdb_CorrectAnswer1;
        private System.Windows.Forms.GroupBox gb_Answer3;
        private System.Windows.Forms.RadioButton rdb_CorrectAnswer3;
        private System.Windows.Forms.GroupBox gb_Answer4;
        private System.Windows.Forms.RadioButton rdb_CorrectAnswer4;
        private System.Windows.Forms.TextBox tbx_Rep1;
        private System.Windows.Forms.PictureBox pb_Rep1;
        private System.Windows.Forms.Label lbl_Rep1;
        private System.Windows.Forms.Button btn_OpenImage1;
    }
}