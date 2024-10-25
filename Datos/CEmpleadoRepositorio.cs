using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Registro_de_empleados.Datos
{
    public static class CEmpleadoRepositorio
    {
        //private const string rutaArchivoJSON = @"\Datos.json";

        public static List<CEmpleado> listaDeEmpleados { get; private set; }
        
        public static void InicalizarRepositorio()
        {
                listaDeEmpleados = new List<CEmpleado>();        
        }
        public static void AgregarEmpleado(CEmpleado empleado)
        {
            listaDeEmpleados.Add(empleado);
            string json= JsonSerializer.Serialize(listaDeEmpleados);
            File.WriteAllText("Datos.json", json);
        }

        public static void EliminarEmpleado(string id)
        {
            listaDeEmpleados.RemoveAll(e => e.Id.Equals(id));
            string json = JsonSerializer.Serialize(listaDeEmpleados);
            File.WriteAllText("Datos.json", json);
        }

        public static void  ActuatlizarEmpleado(string IdEmpleado,CEmpleado empleadoModificado)
        {
           
            int indiceEmpleadoOriginal = listaDeEmpleados.FindIndex(e=> e.Id == IdEmpleado);
            if(indiceEmpleadoOriginal != -1)
            {
                listaDeEmpleados[indiceEmpleadoOriginal]= empleadoModificado;
                string json = JsonSerializer.Serialize(listaDeEmpleados);
                File.WriteAllText("Datos.json", json);
            } 
        }

    }
}
