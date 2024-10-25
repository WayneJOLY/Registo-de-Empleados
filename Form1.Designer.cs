namespace Registro_de_empleados
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PcbAgregar = new PictureBox();
            PcbModificar = new PictureBox();
            PcbEliminar = new PictureBox();
            dataGridView1 = new DataGridView();
            ColumnaId = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaFechaDeNacimiento = new DataGridViewTextBoxColumn();
            ColumnaEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PcbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbModificar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PcbAgregar
            // 
            PcbAgregar.BackColor = SystemColors.ControlLightLight;
            PcbAgregar.Image = Properties.Resources.icons8_add_64;
            PcbAgregar.Location = new Point(803, 47);
            PcbAgregar.Name = "PcbAgregar";
            PcbAgregar.Size = new Size(64, 64);
            PcbAgregar.TabIndex = 0;
            PcbAgregar.TabStop = false;
            PcbAgregar.Click += PcbAgregar_Click;
            // 
            // PcbModificar
            // 
            PcbModificar.BackColor = SystemColors.ControlLightLight;
            PcbModificar.Image = (Image)resources.GetObject("PcbModificar.Image");
            PcbModificar.Location = new Point(803, 176);
            PcbModificar.Name = "PcbModificar";
            PcbModificar.Size = new Size(64, 64);
            PcbModificar.TabIndex = 1;
            PcbModificar.TabStop = false;
            PcbModificar.Click += PcbModificar_Click;
            // 
            // PcbEliminar
            // 
            PcbEliminar.BackColor = SystemColors.ControlLightLight;
            PcbEliminar.Image = (Image)resources.GetObject("PcbEliminar.Image");
            PcbEliminar.Location = new Point(803, 305);
            PcbEliminar.Name = "PcbEliminar";
            PcbEliminar.Size = new Size(64, 64);
            PcbEliminar.TabIndex = 2;
            PcbEliminar.TabStop = false;
            PcbEliminar.Click += PcbEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaId, ColumnaNombre, ColumnaApellido, ColumnaFechaDeNacimiento, ColumnaEmail });
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 322);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnaId
            // 
            ColumnaId.HeaderText = "Id";
            ColumnaId.MinimumWidth = 6;
            ColumnaId.Name = "ColumnaId";
            ColumnaId.Width = 125;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.HeaderText = "Nombre";
            ColumnaNombre.MinimumWidth = 6;
            ColumnaNombre.Name = "ColumnaNombre";
            ColumnaNombre.Width = 125;
            // 
            // ColumnaApellido
            // 
            ColumnaApellido.HeaderText = "Apellido";
            ColumnaApellido.MinimumWidth = 6;
            ColumnaApellido.Name = "ColumnaApellido";
            ColumnaApellido.Width = 125;
            // 
            // ColumnaFechaDeNacimiento
            // 
            ColumnaFechaDeNacimiento.HeaderText = "Fecha de Nacimiento";
            ColumnaFechaDeNacimiento.MinimumWidth = 6;
            ColumnaFechaDeNacimiento.Name = "ColumnaFechaDeNacimiento";
            ColumnaFechaDeNacimiento.Width = 125;
            // 
            // ColumnaEmail
            // 
            ColumnaEmail.HeaderText = "Email";
            ColumnaEmail.MinimumWidth = 6;
            ColumnaEmail.Name = "ColumnaEmail";
            ColumnaEmail.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(911, 450);
            Controls.Add(dataGridView1);
            Controls.Add(PcbEliminar);
            Controls.Add(PcbModificar);
            Controls.Add(PcbAgregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PcbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbModificar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PcbAgregar;
        private PictureBox PcbModificar;
        private PictureBox PcbEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaId;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaFechaDeNacimiento;
        private DataGridViewTextBoxColumn ColumnaEmail;
    }
}
