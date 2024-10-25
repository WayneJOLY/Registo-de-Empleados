using Registro_de_empleados.Datos;
using Registro_de_empleados.Formularios;

namespace Registro_de_empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CEmpleadoRepositorio.InicalizarRepositorio();

        }

        public void VisualizacionDeLaListadeEmpleados()
        {
            dataGridView1.Rows.Clear();
            foreach (CEmpleado empleado in CEmpleadoRepositorio.listaDeEmpleados)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = empleado.Id.ToString();
                dataGridView1.Rows[index].Cells[1].Value = empleado.FirstName;
                dataGridView1.Rows[index].Cells[2].Value = empleado.LastName;
                dataGridView1.Rows[index].Cells[3].Value = empleado.Age.ToString();
                dataGridView1.Rows[index].Cells[4].Value = empleado.Email.ToLower().ToString();
            }
        }

        private void PcbAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosForm empleadosForm = new EmpleadosForm();
            DialogResult dialogResult = empleadosForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CEmpleadoRepositorio.AgregarEmpleado(empleadosForm.empleado);

                
                VisualizacionDeLaListadeEmpleados();
            }
            else
            {

            }
        }

        private void PcbEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idSelectionado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CEmpleadoRepositorio.EliminarEmpleado(idSelectionado);
                VisualizacionDeLaListadeEmpleados();
            }
            else
            {
                MessageBox.Show("No se selectiono una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PcbModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellido= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                uint edad = uint.Parse( dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                string email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                CEmpleado empleadoAModificar= new CEmpleado(id, nombre, apellido, edad,email);

                EmpleadosForm empleadosForm = new EmpleadosForm(empleadoAModificar);
                DialogResult dialogResult= empleadosForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    CEmpleadoRepositorio.ActuatlizarEmpleado(empleadoAModificar.Id, empleadosForm.empleado);
                    VisualizacionDeLaListadeEmpleados();
                }
            }
            else
            {
                MessageBox.Show(" No Se selectiono una fila valida para Modificar !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        
    }

}
//11137007