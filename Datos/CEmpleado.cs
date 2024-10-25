using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_empleados.Datos
{
    public class CEmpleado
    {

        public CEmpleado() { }
        public CEmpleado(string id, string lastName, string firstName, uint age, string email)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Email = email;
        }

        public string Id {  get; private set; }
        public string LastName {  get; private set; }
        public string FirstName { get; private set;}
        public uint Age { get; private set; }
        public string Email { get; private set; }
    }
}
