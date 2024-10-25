using Registro_de_empleados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_de_empleados.Formularios
{
    public partial class EmpleadosForm : Form
    {

        public CEmpleado empleado { get; private set; }
        public EmpleadosForm()
        {
            InitializeComponent();
        }


        public EmpleadosForm(CEmpleado empleado)
        {
            InitializeComponent();
            TxbIdEmpleado.Text = empleado.Id.ToString();
            TxbNombre.Text = empleado.FirstName;
            TxbApellido.Text = empleado.LastName;
            TxbFechaDeNacimiento.Text = empleado.Age.ToString();
            TxbEmail.Text = empleado.Email.ToString();

        }
        private void EmpleadosForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAcceptar_Click(object sender, EventArgs e)
        {
            bool validar = ValidarEpleado(out string errMsg);
            if (validar)
            {
                empleado = new CEmpleado(TxbIdEmpleado.Text, TxbNombre.Text, TxbApellido.Text, uint.Parse(TxbFechaDeNacimiento.Text), TxbEmail.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }


        private bool ValidarEpleado(out string erroMsg)
        {
            erroMsg = string.Empty;

            if (string.IsNullOrEmpty(TxbIdEmpleado.Text))
            {
                erroMsg += "El Id del Empleado no puede estar vacio \n";
            }

            if (string.IsNullOrEmpty(TxbNombre.Text))
            {
                erroMsg += "El Nombre del Empleado no puede estar vacio \n";
            }

            if (string.IsNullOrEmpty(TxbApellido.Text))
            {
                erroMsg += "El Apellidode empleado no puede estrar vacio \n";
            }


            bool fechaOK = uint.TryParse(TxbFechaDeNacimiento.Text, out uint edad);

            if (fechaOK)
            {
                if (edad < 16)
                {
                    erroMsg += " La edad Deber ser Mayor a 16 años";
                }
            }
            else
            {
                erroMsg += " La edad debe ser un  numero valido";
            }

            if (string.IsNullOrEmpty(TxbEmail.Text))
            {
                erroMsg += "El Email del Empleado no puede estar vacio \n";
            }

            try
            {
                new MailAddress(TxbEmail.Text);
            }
            catch (Exception ex)
            {
                erroMsg += "El Email Es Incorrecto";
            }

            return erroMsg == string.Empty;
        }

        private void TxbFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbIdEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido del beep al presionar Enter
                e.SuppressKeyPress = true;

                // Cambia el foco al siguiente TextBox
                TxbNombre.Focus();
            }
        }

        private void TxbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido del beep al presionar Enter
                e.SuppressKeyPress = true;

                // Cambia el foco al siguiente TextBox
                TxbApellido.Focus();
            }
        }
        private void TxbApellido_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido del beep al presionar Enter
                e.SuppressKeyPress = true;

                // Cambia el foco al siguiente TextBox
                TxbFechaDeNacimiento.Focus();
            }
        }
    }
}
