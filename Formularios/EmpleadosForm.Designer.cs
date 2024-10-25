namespace Registro_de_empleados.Formularios
{
    partial class EmpleadosForm
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
            panel1 = new Panel();
            TxbIdEmpleado = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            TxbNombre = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            TxbFechaDeNacimiento = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            TxbApellido = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            TxbEmail = new TextBox();
            label5 = new Label();
            BtnAcceptar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TxbIdEmpleado);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(47, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 51);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // TxbIdEmpleado
            // 
            TxbIdEmpleado.Location = new Point(156, 15);
            TxbIdEmpleado.Name = "TxbIdEmpleado";
            TxbIdEmpleado.Size = new Size(203, 27);
            TxbIdEmpleado.TabIndex = 1;
            TxbIdEmpleado.TextChanged += TxbIdEmpleado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 1;
            label1.Text = "Id Empleado";
            // 
            // panel2
            // 
            panel2.Controls.Add(TxbNombre);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(47, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 51);
            panel2.TabIndex = 3;
            // 
            // TxbNombre
            // 
            TxbNombre.Location = new Point(156, 15);
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(203, 27);
            TxbNombre.TabIndex = 2;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(TxbFechaDeNacimiento);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(47, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 51);
            panel3.TabIndex = 5;
            // 
            // TxbFechaDeNacimiento
            // 
            TxbFechaDeNacimiento.Location = new Point(153, 15);
            TxbFechaDeNacimiento.Name = "TxbFechaDeNacimiento";
            TxbFechaDeNacimiento.Size = new Size(207, 27);
            TxbFechaDeNacimiento.TabIndex = 4;
            TxbFechaDeNacimiento.TextChanged += TxbFechaDeNacimiento_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 1;
            label3.Text = "Edad";
            // 
            // panel4
            // 
            panel4.Controls.Add(TxbApellido);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(47, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(363, 51);
            panel4.TabIndex = 4;
            // 
            // TxbApellido
            // 
            TxbApellido.Location = new Point(156, 15);
            TxbApellido.Name = "TxbApellido";
            TxbApellido.Size = new Size(203, 27);
            TxbApellido.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 1;
            label4.Text = "Apellido";
            // 
            // panel5
            // 
            panel5.Controls.Add(TxbEmail);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(47, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(363, 51);
            panel5.TabIndex = 6;
            // 
            // TxbEmail
            // 
            TxbEmail.Location = new Point(156, 15);
            TxbEmail.Name = "TxbEmail";
            TxbEmail.Size = new Size(203, 27);
            TxbEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.Font = new Font("Segoe UI", 18F);
            BtnAcceptar.Location = new Point(116, 401);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(251, 56);
            BtnAcceptar.TabIndex = 6;
            BtnAcceptar.Text = "Acceptar";
            BtnAcceptar.UseVisualStyleBackColor = true;
            BtnAcceptar.Click += BtnAcceptar_Click;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(493, 469);
            Controls.Add(BtnAcceptar);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Blue;
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            Load += EmpleadosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxbIdEmpleado;
        private Label label1;
        private Panel panel2;
        private TextBox TxbNombre;
        private Label label2;
        private Panel panel3;
        private TextBox TxbFechaDeNacimiento;
        private Label label3;
        private Panel panel4;
        private TextBox TxbApellido;
        private Label label4;
        private Panel panel5;
        private TextBox TxbEmail;
        private Label label5;
        private Button BtnAcceptar;
    }
}