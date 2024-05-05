namespace ControlParqueoApp
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            txtuser = new MaskedTextBox();
            txtpass = new MaskedTextBox();
            lblUsuario = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(33, 53, 73);
            btnIniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.LightGray;
            btnIniciarSesion.Location = new Point(89, 169);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(408, 40);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "ACCEDER";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(39, 57, 80);
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.Silver;
            txtuser.Location = new Point(89, 38);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(408, 27);
            txtuser.TabIndex = 1;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(39, 57, 80);
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.Silver;
            txtpass.Location = new Point(86, 105);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(408, 27);
            txtpass.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(264, 14);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 21);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "USUARIO";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(249, 81);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 4;
            label1.Text = "CONTRASEÑA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 80);
            ClientSize = new Size(580, 230);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(btnIniciarSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private MaskedTextBox txtuser;
        private MaskedTextBox txtpass;
        private Label lblUsuario;
        private Label label1;
    }
}
