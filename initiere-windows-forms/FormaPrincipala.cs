using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace initiere_windows_forms
{
    public partial class FormaPrincipala : Form
    {
        private Student student;
        public FormaPrincipala(Student student)
        {
            InitializeComponent();
            this.student = student;

        }

        private void FormaPrincipala_Load(object sender, EventArgs e)
        {
            lblSalut.Text = "Salut, " + student.FirstName + "!";
        }

        private void lblSalut_Click(object sender, EventArgs e)
        {

        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti.SelectedIndex = 0;
        }

        private void cursuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti.SelectedIndex = 1;
        }

        private void optiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti.SelectedIndex = 2;
        }

        private void inscriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti.SelectedIndex = 3;
        }

        private void pozaSiCeasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studenti.SelectedIndex = 4;
        }

        private void ceMaiFaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult raspuns = MessageBox.Show("Sigur vrei sa iesi?",
                "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (raspuns == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormaPrincipala_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
