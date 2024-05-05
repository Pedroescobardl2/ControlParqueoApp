namespace ControlParqueoApp
{
    partial class FormPrincipalAdmin
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
            btnRegistrarVehiculo = new Button();
            btnSalidaVehiculo = new Button();
            btnMostrar = new Button();
            button2 = new Button();
            dataGridViewVehiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarVehiculo
            // 
            btnRegistrarVehiculo.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarVehiculo.ForeColor = Color.ForestGreen;
            btnRegistrarVehiculo.Location = new Point(87, 86);
            btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            btnRegistrarVehiculo.Size = new Size(236, 67);
            btnRegistrarVehiculo.TabIndex = 1;
            btnRegistrarVehiculo.Text = "Registrar Vehículo";
            btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            btnRegistrarVehiculo.Click += btnRegistrarVehiculo_Click;
            // 
            // btnSalidaVehiculo
            // 
            btnSalidaVehiculo.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalidaVehiculo.ForeColor = Color.DarkOrange;
            btnSalidaVehiculo.Location = new Point(424, 86);
            btnSalidaVehiculo.Name = "btnSalidaVehiculo";
            btnSalidaVehiculo.Size = new Size(236, 67);
            btnSalidaVehiculo.TabIndex = 2;
            btnSalidaVehiculo.Text = "Sacar Vehiculo";
            btnSalidaVehiculo.UseVisualStyleBackColor = true;
            btnSalidaVehiculo.Click += btnSalidaVehiculo_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.ForestGreen;
            btnMostrar.Location = new Point(424, 231);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(236, 67);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Vehiculos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(87, 231);
            button2.Name = "button2";
            button2.Size = new Size(236, 67);
            button2.TabIndex = 4;
            button2.Text = "Imprimir Reporte";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(87, 332);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.Size = new Size(573, 573);
            dataGridViewVehiculos.TabIndex = 5;
            dataGridViewVehiculos.CellContentClick += dataGridViewVehiculos_CellContentClick;
            // 
            // FormPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(button2);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalidaVehiculo);
            Controls.Add(btnRegistrarVehiculo);
            Name = "FormPrincipalAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrarVehiculo;
        private Button btnSalidaVehiculo;
        private Button btnMostrar;
        private Button button2;
        private DataGridView dataGridViewVehiculos;
    }
}