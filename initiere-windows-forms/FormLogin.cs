using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace initiere_windows_forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnIntra_Click(object sender, EventArgs e)
        {
            txtEmail.Font = new Font(txtEmail.Font.FontFamily, 10);
            foreach (Student student in DateTest.Students())
            {
                if (student.Email.Equals(txtEmail.Text) && student.Password.Equals(textParola.Text))
                {

                    Hide();
                    new FormaPrincipala(student).Show();
                    return;

                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
