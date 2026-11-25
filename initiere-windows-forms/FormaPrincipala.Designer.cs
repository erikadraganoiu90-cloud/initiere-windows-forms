namespace initiere_windows_forms
{
    partial class FormaPrincipala
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
            menuStrip1 = new MenuStrip();
            contToolStripMenuItem = new ToolStripMenuItem();
            erikaToolStripMenuItem = new ToolStripMenuItem();
            ceMaiFaciToolStripMenuItem = new ToolStripMenuItem();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            bineToolStripMenuItem = new ToolStripMenuItem();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            cursuriToolStripMenuItem = new ToolStripMenuItem();
            optiuniToolStripMenuItem = new ToolStripMenuItem();
            inscriereToolStripMenuItem = new ToolStripMenuItem();
            pozaSiCeasToolStripMenuItem = new ToolStripMenuItem();
            Studenti = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            lblSalut = new Label();
            menuStrip1.SuspendLayout();
            Studenti.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { contToolStripMenuItem, bineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contToolStripMenuItem
            // 
            contToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { erikaToolStripMenuItem, ceMaiFaciToolStripMenuItem, fisierToolStripMenuItem });
            contToolStripMenuItem.Name = "contToolStripMenuItem";
            contToolStripMenuItem.Size = new Size(57, 24);
            contToolStripMenuItem.Text = "Fisier";
            // 
            // erikaToolStripMenuItem
            // 
            erikaToolStripMenuItem.Name = "erikaToolStripMenuItem";
            erikaToolStripMenuItem.Size = new Size(224, 26);
            erikaToolStripMenuItem.Text = "Profil";
            // 
            // ceMaiFaciToolStripMenuItem
            // 
            ceMaiFaciToolStripMenuItem.Name = "ceMaiFaciToolStripMenuItem";
            ceMaiFaciToolStripMenuItem.Size = new Size(224, 26);
            ceMaiFaciToolStripMenuItem.Text = "Iesire";
            ceMaiFaciToolStripMenuItem.Click += ceMaiFaciToolStripMenuItem_Click;
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(224, 26);
            fisierToolStripMenuItem.Text = " ";
            // 
            // bineToolStripMenuItem
            // 
            bineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, cursuriToolStripMenuItem, optiuniToolStripMenuItem, inscriereToolStripMenuItem, pozaSiCeasToolStripMenuItem });
            bineToolStripMenuItem.Name = "bineToolStripMenuItem";
            bineToolStripMenuItem.Size = new Size(83, 24);
            bineToolStripMenuItem.Text = "Navigare";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(170, 26);
            studentiToolStripMenuItem.Text = "Studenti";
            studentiToolStripMenuItem.Click += studentiToolStripMenuItem_Click;
            // 
            // cursuriToolStripMenuItem
            // 
            cursuriToolStripMenuItem.Name = "cursuriToolStripMenuItem";
            cursuriToolStripMenuItem.Size = new Size(170, 26);
            cursuriToolStripMenuItem.Text = "Cursuri";
            cursuriToolStripMenuItem.Click += cursuriToolStripMenuItem_Click;
            // 
            // optiuniToolStripMenuItem
            // 
            optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            optiuniToolStripMenuItem.Size = new Size(170, 26);
            optiuniToolStripMenuItem.Text = "Optiuni";
            optiuniToolStripMenuItem.Click += optiuniToolStripMenuItem_Click;
            // 
            // inscriereToolStripMenuItem
            // 
            inscriereToolStripMenuItem.Name = "inscriereToolStripMenuItem";
            inscriereToolStripMenuItem.Size = new Size(170, 26);
            inscriereToolStripMenuItem.Text = "Inscriere ";
            inscriereToolStripMenuItem.Click += inscriereToolStripMenuItem_Click;
            // 
            // pozaSiCeasToolStripMenuItem
            // 
            pozaSiCeasToolStripMenuItem.Name = "pozaSiCeasToolStripMenuItem";
            pozaSiCeasToolStripMenuItem.Size = new Size(170, 26);
            pozaSiCeasToolStripMenuItem.Text = "Poza si ceas";
            pozaSiCeasToolStripMenuItem.Click += pozaSiCeasToolStripMenuItem_Click;
            // 
            // Studenti
            // 
            Studenti.Controls.Add(tabPage1);
            Studenti.Controls.Add(tabPage2);
            Studenti.Controls.Add(tabPage3);
            Studenti.Controls.Add(tabPage4);
            Studenti.Controls.Add(tabPage5);
            Studenti.Location = new Point(12, 83);
            Studenti.Name = "Studenti";
            Studenti.SelectedIndex = 0;
            Studenti.Size = new Size(376, 125);
            Studenti.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(368, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Studenti";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(368, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cursuri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(368, 92);
            tabPage3.TabIndex = 2;
            tabPage3.Text = " Optiuni";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(368, 92);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Inscriere";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(368, 92);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Poza si ceas";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblSalut
            // 
            lblSalut.AutoSize = true;
            lblSalut.Location = new Point(16, 48);
            lblSalut.Name = "lblSalut";
            lblSalut.Size = new Size(42, 20);
            lblSalut.TabIndex = 2;
            lblSalut.Text = "Salut";
            lblSalut.Click += lblSalut_Click;
            // 
            // FormaPrincipala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalut);
            Controls.Add(Studenti);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormaPrincipala";
            Text = "FormaPrincipala";
            FormClosed += FormaPrincipala_FormClosed;
            Load += FormaPrincipala_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Studenti.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contToolStripMenuItem;
        private ToolStripMenuItem erikaToolStripMenuItem;
        private ToolStripMenuItem ceMaiFaciToolStripMenuItem;
        private ToolStripMenuItem bineToolStripMenuItem;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripMenuItem cursuriToolStripMenuItem;
        private ToolStripMenuItem optiuniToolStripMenuItem;
        private ToolStripMenuItem inscriereToolStripMenuItem;
        private ToolStripMenuItem pozaSiCeasToolStripMenuItem;
        private TabControl Studenti;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label lblSalut;
    }
}