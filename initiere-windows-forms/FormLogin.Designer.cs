namespace initiere_windows_forms
{
    partial class FormLogin
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
            lblMail = new Label();
            textMail = new TextBox();
            lblPin = new Label();
            textPin = new TextBox();
            btnIntra = new Button();
            pnlSigla = new Panel();
            lblOnlineSchool = new Label();
            SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AccessibleDescription = "s";
            lblMail.AutoSize = true;
            lblMail.Location = new Point(52, 166);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(46, 20);
            lblMail.TabIndex = 0;
            lblMail.Text = "Email";
            // 
            // textMail
            // 
            textMail.Location = new Point(52, 201);
            textMail.Name = "textMail";
            textMail.Size = new Size(125, 27);
            textMail.TabIndex = 1;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(52, 243);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(50, 20);
            lblPin.TabIndex = 2;
            lblPin.Text = "Parola";
            // 
            // textPin
            // 
            textPin.Location = new Point(52, 266);
            textPin.Name = "textPin";
            textPin.PasswordChar = '*';
            textPin.Size = new Size(125, 27);
            textPin.TabIndex = 4;
            // 
            // btnIntra
            // 
            btnIntra.Location = new Point(52, 343);
            btnIntra.Name = "btnIntra";
            btnIntra.Size = new Size(94, 29);
            btnIntra.TabIndex = 5;
            btnIntra.Tag = " ";
            btnIntra.Text = "Intra";
            btnIntra.UseVisualStyleBackColor = true;
            // 
            // pnlSigla
            // 
            pnlSigla.BackColor = Color.Purple;
            pnlSigla.Location = new Point(62, 47);
            pnlSigla.Name = "pnlSigla";
            pnlSigla.Size = new Size(98, 90);
            pnlSigla.TabIndex = 6;
            // 
            // lblOnlineSchool
            // 
            lblOnlineSchool.AutoSize = true;
            lblOnlineSchool.Font = new Font("Microsoft Sans Serif", 9F);
            lblOnlineSchool.Location = new Point(229, 78);
            lblOnlineSchool.Name = "lblOnlineSchool";
            lblOnlineSchool.Size = new Size(101, 18);
            lblOnlineSchool.TabIndex = 7;
            lblOnlineSchool.Text = "Online School";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOnlineSchool);
            Controls.Add(pnlSigla);
            Controls.Add(btnIntra);
            Controls.Add(textPin);
            Controls.Add(lblPin);
            Controls.Add(textMail);
            Controls.Add(lblMail);
            Name = "FormLogin";
            Text = "s";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMail;
        private TextBox textMail;
        private Label lblPin;
        private TextBox textPin;
        private Button btnIntra;
        private Panel pnlSigla;
        private Label lblOnlineSchool;
    }
}