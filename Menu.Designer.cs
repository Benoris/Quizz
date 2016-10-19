namespace Projet_Quizz
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_ShowCreator = new System.Windows.Forms.Button();
            this.btn_Score = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Enregistrersous = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_aprop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(12, 27);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(86, 34);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Jouer";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_ShowCreator
            // 
            this.btn_ShowCreator.Location = new System.Drawing.Point(12, 67);
            this.btn_ShowCreator.Name = "btn_ShowCreator";
            this.btn_ShowCreator.Size = new System.Drawing.Size(185, 34);
            this.btn_ShowCreator.TabIndex = 1;
            this.btn_ShowCreator.Text = "Afficher le créateur de questions";
            this.btn_ShowCreator.UseVisualStyleBackColor = true;
            this.btn_ShowCreator.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Score
            // 
            this.btn_Score.Location = new System.Drawing.Point(111, 27);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(86, 34);
            this.btn_Score.TabIndex = 2;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = true;
            this.btn_Score.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(209, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Enregistrer,
            this.TSM_Enregistrersous,
            this.TSM_Quit});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // TSM_Enregistrer
            // 
            this.TSM_Enregistrer.Name = "TSM_Enregistrer";
            this.TSM_Enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSM_Enregistrer.Size = new System.Drawing.Size(170, 22);
            this.TSM_Enregistrer.Text = "Enregistrer";
            // 
            // TSM_Enregistrersous
            // 
            this.TSM_Enregistrersous.Name = "TSM_Enregistrersous";
            this.TSM_Enregistrersous.Size = new System.Drawing.Size(170, 22);
            this.TSM_Enregistrersous.Text = "Enregistrer sous";
            // 
            // TSM_Quit
            // 
            this.TSM_Quit.Name = "TSM_Quit";
            this.TSM_Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSM_Quit.Size = new System.Drawing.Size(170, 22);
            this.TSM_Quit.Text = "Quitter";
            this.TSM_Quit.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_aprop});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // TSM_aprop
            // 
            this.TSM_aprop.Name = "TSM_aprop";
            this.TSM_aprop.Size = new System.Drawing.Size(122, 22);
            this.TSM_aprop.Text = "À propos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem2.Text = "Aide";
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(12, 107);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(185, 36);
            this.btn_Quit.TabIndex = 4;
            this.btn_Quit.Text = "Quitter";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 148);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(209, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_Time
            // 
            this.tss_Time.Name = "tss_Time";
            this.tss_Time.Size = new System.Drawing.Size(0, 17);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 170);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.btn_ShowCreator);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Quizz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_ShowCreator;
        private System.Windows.Forms.Button btn_Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM_Enregistrer;
        private System.Windows.Forms.ToolStripMenuItem TSM_Enregistrersous;
        private System.Windows.Forms.ToolStripMenuItem TSM_Quit;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSM_aprop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_Time;
    }
}

