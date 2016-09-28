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
            this.lbl_AnswerType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Answer1.SuspendLayout();
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
            this.tbx_Question.TabIndex = 1;
            // 
            // gb_Answer1
            // 
            this.gb_Answer1.Controls.Add(this.label1);
            this.gb_Answer1.Controls.Add(this.textBox1);
            this.gb_Answer1.Location = new System.Drawing.Point(15, 166);
            this.gb_Answer1.Name = "gb_Answer1";
            this.gb_Answer1.Size = new System.Drawing.Size(231, 318);
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
            this.rdb_CorrectAnswer2.Text = "Correcte";
            this.rdb_CorrectAnswer2.UseVisualStyleBackColor = true;
            // 
            // gb_Answer2
            // 
            this.gb_Answer2.Location = new System.Drawing.Point(252, 166);
            this.gb_Answer2.Name = "gb_Answer2";
            this.gb_Answer2.Size = new System.Drawing.Size(231, 318);
            this.gb_Answer2.TabIndex = 3;
            this.gb_Answer2.TabStop = false;
            this.gb_Answer2.Text = "Reponse 2";
            // 
            // rdb_CorrectAnswer1
            // 
            this.rdb_CorrectAnswer1.AutoSize = true;
            this.rdb_CorrectAnswer1.Checked = true;
            this.rdb_CorrectAnswer1.Location = new System.Drawing.Point(74, 143);
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
            this.gb_Answer3.Size = new System.Drawing.Size(231, 318);
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
            this.rdb_CorrectAnswer3.Text = "Correcte";
            this.rdb_CorrectAnswer3.UseVisualStyleBackColor = true;
            // 
            // gb_Answer4
            // 
            this.gb_Answer4.Location = new System.Drawing.Point(726, 166);
            this.gb_Answer4.Name = "gb_Answer4";
            this.gb_Answer4.Size = new System.Drawing.Size(231, 318);
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
            // lbl_AnswerType
            // 
            this.lbl_AnswerType.AutoSize = true;
            this.lbl_AnswerType.Location = new System.Drawing.Point(733, 9);
            this.lbl_AnswerType.Name = "lbl_AnswerType";
            this.lbl_AnswerType.Size = new System.Drawing.Size(92, 13);
            this.lbl_AnswerType.TabIndex = 4;
            this.lbl_AnswerType.Text = "Type de réponses";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 40);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Une réponse :";
            // 
            // QuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 496);
            this.Controls.Add(this.lbl_AnswerType);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_AnswerType;
        private System.Windows.Forms.Label label1;
    }
}