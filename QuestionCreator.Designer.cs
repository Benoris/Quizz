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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionCreator));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tbx_Question = new System.Windows.Forms.TextBox();
            this.gb_Answer1 = new System.Windows.Forms.GroupBox();
            this.btn_OpenImage1 = new System.Windows.Forms.Button();
            this.lbl_Rep1 = new System.Windows.Forms.Label();
            this.tbx_Rep1 = new System.Windows.Forms.TextBox();
            this.pb_Rep1 = new System.Windows.Forms.PictureBox();
            this.cmb_QuestType = new System.Windows.Forms.ComboBox();
            this.rdb_CorrectAnswer2 = new System.Windows.Forms.RadioButton();
            this.gb_Answer2 = new System.Windows.Forms.GroupBox();
            this.btn_OpenImage2 = new System.Windows.Forms.Button();
            this.lbl_Rep2 = new System.Windows.Forms.Label();
            this.tbx_Rep2 = new System.Windows.Forms.TextBox();
            this.pb_Rep2 = new System.Windows.Forms.PictureBox();
            this.rdb_CorrectAnswer1 = new System.Windows.Forms.RadioButton();
            this.gb_Answer3 = new System.Windows.Forms.GroupBox();
            this.btn_OpenImage3 = new System.Windows.Forms.Button();
            this.lbl_Rep3 = new System.Windows.Forms.Label();
            this.tbx_Rep3 = new System.Windows.Forms.TextBox();
            this.pb_Rep3 = new System.Windows.Forms.PictureBox();
            this.rdb_CorrectAnswer3 = new System.Windows.Forms.RadioButton();
            this.gb_Answer4 = new System.Windows.Forms.GroupBox();
            this.btn_OpenImage4 = new System.Windows.Forms.Button();
            this.lbl_Rep4 = new System.Windows.Forms.Label();
            this.tbx_Rep4 = new System.Windows.Forms.TextBox();
            this.pb_Rep4 = new System.Windows.Forms.PictureBox();
            this.rdb_CorrectAnswer4 = new System.Windows.Forms.RadioButton();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.gb_Answer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep1)).BeginInit();
            this.gb_Answer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep2)).BeginInit();
            this.gb_Answer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep3)).BeginInit();
            this.gb_Answer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep4)).BeginInit();
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
            this.tbx_Question.Size = new System.Drawing.Size(297, 69);
            this.tbx_Question.TabIndex = 0;
            this.tbx_Question.TextChanged += new System.EventHandler(this.tbx_Rep1_TextChanged);
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
            this.gb_Answer1.TabIndex = 6;
            this.gb_Answer1.TabStop = false;
            this.gb_Answer1.Text = "Reponse 1";
            // 
            // btn_OpenImage1
            // 
            this.btn_OpenImage1.Location = new System.Drawing.Point(9, 100);
            this.btn_OpenImage1.Name = "btn_OpenImage1";
            this.btn_OpenImage1.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenImage1.TabIndex = 1;
            this.btn_OpenImage1.Text = "Sélectionner Image";
            this.btn_OpenImage1.UseVisualStyleBackColor = true;
            this.btn_OpenImage1.Click += new System.EventHandler(this.btn_OpenImage1_Click);
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
            // tbx_Rep1
            // 
            this.tbx_Rep1.Location = new System.Drawing.Point(6, 31);
            this.tbx_Rep1.Multiline = true;
            this.tbx_Rep1.Name = "tbx_Rep1";
            this.tbx_Rep1.Size = new System.Drawing.Size(219, 55);
            this.tbx_Rep1.TabIndex = 0;
            this.tbx_Rep1.TextChanged += new System.EventHandler(this.tbx_Rep1_TextChanged);
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
            // cmb_QuestType
            // 
            this.cmb_QuestType.FormattingEnabled = true;
            this.cmb_QuestType.Items.AddRange(new object[] {
            "Text",
            "Images"});
            this.cmb_QuestType.Location = new System.Drawing.Point(736, 60);
            this.cmb_QuestType.Name = "cmb_QuestType";
            this.cmb_QuestType.Size = new System.Drawing.Size(221, 21);
            this.cmb_QuestType.TabIndex = 1;
            this.cmb_QuestType.SelectedIndexChanged += new System.EventHandler(this.cmb_QuestType_SelectedIndexChanged);
            // 
            // rdb_CorrectAnswer2
            // 
            this.rdb_CorrectAnswer2.AutoSize = true;
            this.rdb_CorrectAnswer2.Location = new System.Drawing.Point(331, 143);
            this.rdb_CorrectAnswer2.Name = "rdb_CorrectAnswer2";
            this.rdb_CorrectAnswer2.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer2.TabIndex = 3;
            this.rdb_CorrectAnswer2.TabStop = true;
            this.rdb_CorrectAnswer2.Text = "Correcte";
            this.rdb_CorrectAnswer2.UseVisualStyleBackColor = true;
            // 
            // gb_Answer2
            // 
            this.gb_Answer2.Controls.Add(this.btn_OpenImage2);
            this.gb_Answer2.Controls.Add(this.lbl_Rep2);
            this.gb_Answer2.Controls.Add(this.tbx_Rep2);
            this.gb_Answer2.Controls.Add(this.pb_Rep2);
            this.gb_Answer2.Location = new System.Drawing.Point(252, 166);
            this.gb_Answer2.Name = "gb_Answer2";
            this.gb_Answer2.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer2.TabIndex = 7;
            this.gb_Answer2.TabStop = false;
            this.gb_Answer2.Text = "Reponse 2";
            // 
            // btn_OpenImage2
            // 
            this.btn_OpenImage2.Location = new System.Drawing.Point(9, 100);
            this.btn_OpenImage2.Name = "btn_OpenImage2";
            this.btn_OpenImage2.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenImage2.TabIndex = 1;
            this.btn_OpenImage2.Text = "Sélectionner Image";
            this.btn_OpenImage2.UseVisualStyleBackColor = true;
            this.btn_OpenImage2.Click += new System.EventHandler(this.btn_OpenImage2_Click);
            // 
            // lbl_Rep2
            // 
            this.lbl_Rep2.AutoSize = true;
            this.lbl_Rep2.Location = new System.Drawing.Point(6, 16);
            this.lbl_Rep2.Name = "lbl_Rep2";
            this.lbl_Rep2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Rep2.TabIndex = 6;
            this.lbl_Rep2.Text = "Réponse :";
            // 
            // tbx_Rep2
            // 
            this.tbx_Rep2.Location = new System.Drawing.Point(6, 31);
            this.tbx_Rep2.Multiline = true;
            this.tbx_Rep2.Name = "tbx_Rep2";
            this.tbx_Rep2.Size = new System.Drawing.Size(219, 55);
            this.tbx_Rep2.TabIndex = 0;
            this.tbx_Rep2.TextChanged += new System.EventHandler(this.tbx_Rep1_TextChanged);
            // 
            // pb_Rep2
            // 
            this.pb_Rep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Rep2.Location = new System.Drawing.Point(6, 129);
            this.pb_Rep2.Name = "pb_Rep2";
            this.pb_Rep2.Size = new System.Drawing.Size(219, 276);
            this.pb_Rep2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Rep2.TabIndex = 4;
            this.pb_Rep2.TabStop = false;
            // 
            // rdb_CorrectAnswer1
            // 
            this.rdb_CorrectAnswer1.AutoSize = true;
            this.rdb_CorrectAnswer1.Checked = true;
            this.rdb_CorrectAnswer1.Location = new System.Drawing.Point(89, 143);
            this.rdb_CorrectAnswer1.Name = "rdb_CorrectAnswer1";
            this.rdb_CorrectAnswer1.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer1.TabIndex = 2;
            this.rdb_CorrectAnswer1.TabStop = true;
            this.rdb_CorrectAnswer1.Text = "Correcte";
            this.rdb_CorrectAnswer1.UseVisualStyleBackColor = true;
            // 
            // gb_Answer3
            // 
            this.gb_Answer3.Controls.Add(this.btn_OpenImage3);
            this.gb_Answer3.Controls.Add(this.lbl_Rep3);
            this.gb_Answer3.Controls.Add(this.tbx_Rep3);
            this.gb_Answer3.Controls.Add(this.pb_Rep3);
            this.gb_Answer3.Location = new System.Drawing.Point(489, 166);
            this.gb_Answer3.Name = "gb_Answer3";
            this.gb_Answer3.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer3.TabIndex = 8;
            this.gb_Answer3.TabStop = false;
            this.gb_Answer3.Text = "Reponse 3";
            // 
            // btn_OpenImage3
            // 
            this.btn_OpenImage3.Location = new System.Drawing.Point(9, 100);
            this.btn_OpenImage3.Name = "btn_OpenImage3";
            this.btn_OpenImage3.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenImage3.TabIndex = 1;
            this.btn_OpenImage3.Text = "Sélectionner Image";
            this.btn_OpenImage3.UseVisualStyleBackColor = true;
            this.btn_OpenImage3.Click += new System.EventHandler(this.btn_OpenImage3_Click);
            // 
            // lbl_Rep3
            // 
            this.lbl_Rep3.AutoSize = true;
            this.lbl_Rep3.Location = new System.Drawing.Point(6, 16);
            this.lbl_Rep3.Name = "lbl_Rep3";
            this.lbl_Rep3.Size = new System.Drawing.Size(56, 13);
            this.lbl_Rep3.TabIndex = 6;
            this.lbl_Rep3.Text = "Réponse :";
            // 
            // tbx_Rep3
            // 
            this.tbx_Rep3.Location = new System.Drawing.Point(6, 31);
            this.tbx_Rep3.Multiline = true;
            this.tbx_Rep3.Name = "tbx_Rep3";
            this.tbx_Rep3.Size = new System.Drawing.Size(219, 55);
            this.tbx_Rep3.TabIndex = 0;
            this.tbx_Rep3.TextChanged += new System.EventHandler(this.tbx_Rep1_TextChanged);
            // 
            // pb_Rep3
            // 
            this.pb_Rep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Rep3.Location = new System.Drawing.Point(6, 129);
            this.pb_Rep3.Name = "pb_Rep3";
            this.pb_Rep3.Size = new System.Drawing.Size(219, 276);
            this.pb_Rep3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Rep3.TabIndex = 4;
            this.pb_Rep3.TabStop = false;
            // 
            // rdb_CorrectAnswer3
            // 
            this.rdb_CorrectAnswer3.AutoSize = true;
            this.rdb_CorrectAnswer3.Location = new System.Drawing.Point(568, 143);
            this.rdb_CorrectAnswer3.Name = "rdb_CorrectAnswer3";
            this.rdb_CorrectAnswer3.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer3.TabIndex = 4;
            this.rdb_CorrectAnswer3.TabStop = true;
            this.rdb_CorrectAnswer3.Text = "Correcte";
            this.rdb_CorrectAnswer3.UseVisualStyleBackColor = true;
            // 
            // gb_Answer4
            // 
            this.gb_Answer4.Controls.Add(this.btn_OpenImage4);
            this.gb_Answer4.Controls.Add(this.lbl_Rep4);
            this.gb_Answer4.Controls.Add(this.tbx_Rep4);
            this.gb_Answer4.Controls.Add(this.pb_Rep4);
            this.gb_Answer4.Location = new System.Drawing.Point(726, 166);
            this.gb_Answer4.Name = "gb_Answer4";
            this.gb_Answer4.Size = new System.Drawing.Size(231, 411);
            this.gb_Answer4.TabIndex = 9;
            this.gb_Answer4.TabStop = false;
            this.gb_Answer4.Text = "Reponse 4";
            // 
            // btn_OpenImage4
            // 
            this.btn_OpenImage4.Location = new System.Drawing.Point(9, 100);
            this.btn_OpenImage4.Name = "btn_OpenImage4";
            this.btn_OpenImage4.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenImage4.TabIndex = 1;
            this.btn_OpenImage4.Text = "Sélectionner Image";
            this.btn_OpenImage4.UseVisualStyleBackColor = true;
            this.btn_OpenImage4.Click += new System.EventHandler(this.btn_OpenImage4_Click);
            // 
            // lbl_Rep4
            // 
            this.lbl_Rep4.AutoSize = true;
            this.lbl_Rep4.Location = new System.Drawing.Point(6, 16);
            this.lbl_Rep4.Name = "lbl_Rep4";
            this.lbl_Rep4.Size = new System.Drawing.Size(56, 13);
            this.lbl_Rep4.TabIndex = 6;
            this.lbl_Rep4.Text = "Réponse :";
            // 
            // tbx_Rep4
            // 
            this.tbx_Rep4.Location = new System.Drawing.Point(6, 31);
            this.tbx_Rep4.Multiline = true;
            this.tbx_Rep4.Name = "tbx_Rep4";
            this.tbx_Rep4.Size = new System.Drawing.Size(219, 55);
            this.tbx_Rep4.TabIndex = 0;
            this.tbx_Rep4.TextChanged += new System.EventHandler(this.tbx_Rep1_TextChanged);
            // 
            // pb_Rep4
            // 
            this.pb_Rep4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Rep4.Location = new System.Drawing.Point(6, 129);
            this.pb_Rep4.Name = "pb_Rep4";
            this.pb_Rep4.Size = new System.Drawing.Size(219, 276);
            this.pb_Rep4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Rep4.TabIndex = 4;
            this.pb_Rep4.TabStop = false;
            // 
            // rdb_CorrectAnswer4
            // 
            this.rdb_CorrectAnswer4.AutoSize = true;
            this.rdb_CorrectAnswer4.Location = new System.Drawing.Point(806, 143);
            this.rdb_CorrectAnswer4.Name = "rdb_CorrectAnswer4";
            this.rdb_CorrectAnswer4.Size = new System.Drawing.Size(65, 17);
            this.rdb_CorrectAnswer4.TabIndex = 5;
            this.rdb_CorrectAnswer4.TabStop = true;
            this.rdb_CorrectAnswer4.Text = "Correcte";
            this.rdb_CorrectAnswer4.UseVisualStyleBackColor = true;
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddQuestion.Location = new System.Drawing.Point(15, 584);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(936, 34);
            this.btn_AddQuestion.TabIndex = 10;
            this.btn_AddQuestion.Text = "Ajouter question";
            this.btn_AddQuestion.UseVisualStyleBackColor = true;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // QuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.btn_AddQuestion);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionCreator";
            this.Text = "QuestionCreator";
            this.gb_Answer1.ResumeLayout(false);
            this.gb_Answer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep1)).EndInit();
            this.gb_Answer2.ResumeLayout(false);
            this.gb_Answer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep2)).EndInit();
            this.gb_Answer3.ResumeLayout(false);
            this.gb_Answer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep3)).EndInit();
            this.gb_Answer4.ResumeLayout(false);
            this.gb_Answer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rep4)).EndInit();
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
        private System.Windows.Forms.Button btn_OpenImage2;
        private System.Windows.Forms.Label lbl_Rep2;
        private System.Windows.Forms.TextBox tbx_Rep2;
        private System.Windows.Forms.PictureBox pb_Rep2;
        private System.Windows.Forms.Button btn_OpenImage3;
        private System.Windows.Forms.Label lbl_Rep3;
        private System.Windows.Forms.TextBox tbx_Rep3;
        private System.Windows.Forms.PictureBox pb_Rep3;
        private System.Windows.Forms.Button btn_OpenImage4;
        private System.Windows.Forms.Label lbl_Rep4;
        private System.Windows.Forms.TextBox tbx_Rep4;
        private System.Windows.Forms.PictureBox pb_Rep4;
        private System.Windows.Forms.Button btn_AddQuestion;
    }
}