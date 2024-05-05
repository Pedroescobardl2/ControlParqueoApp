namespace ControlParqueoApp.Formularios
{
    partial class FormRegistrarVehiculo
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
            lblPlaca = new Label();
            lblNombre = new Label();
            txtPlaca = new TextBox();
            txtNombrePropietario = new TextBox();
            rbDama = new RadioButton();
            btnRegistrar = new Button();
            rbCaballero = new RadioButton();
            SuspendLayout();
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaca.Location = new Point(157, 76);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(58, 19);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "PLACA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(157, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(257, 72);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(304, 23);
            txtPlaca.TabIndex = 2;
            // 
            // txtNombrePropietario
            // 
            txtNombrePropietario.Location = new Point(257, 135);
            txtNombrePropietario.Name = "txtNombrePropietario";
            txtNombrePropietario.Size = new Size(304, 23);
            txtNombrePropietario.TabIndex = 3;
            // 
            // rbDama
            // 
            rbDama.AutoSize = true;
            rbDama.Location = new Point(157, 182);
            rbDama.Name = "rbDama";
            rbDama.Size = new Size(61, 19);
            rbDama.TabIndex = 4;
            rbDama.TabStop = true;
            rbDama.Text = "Damas";
            rbDama.UseVisualStyleBackColor = true;
            rbDama.CheckedChanged += RbDama_CheckedChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(302, 217);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(232, 31);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // rbCaballero
            // 
            rbCaballero.AutoSize = true;
            rbCaballero.Location = new Point(157, 223);
            rbCaballero.Name = "rbCaballero";
            rbCaballero.Size = new Size(80, 19);
            rbCaballero.TabIndex = 6;
            rbCaballero.TabStop = true;
            rbCaballero.Text = "Caballeros";
            rbCaballero.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbCaballero);
            Controls.Add(btnRegistrar);
            Controls.Add(rbDama);
            Controls.Add(txtNombrePropietario);
            Controls.Add(txtPlaca);
            Controls.Add(lblNombre);
            Controls.Add(lblPlaca);
            Name = "FormRegistrarVehiculo";
            Text = "FormRegistrarVehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlaca;
        private Label lblNombre;
        private TextBox txtPlaca;
        private TextBox txtNombrePropietario;
        private RadioButton rbDama;
        private Button btnRegistrar;
        private RadioButton rbCaballero;
    }
}