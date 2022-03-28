using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicosYPacientesInterfaz
{
    class Persona
    {
        String nombre;
        String telefono;
        String dni;

        public Persona()
        {
        }

        public Persona(string nombre, string telefono, string dni)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Dni { get => dni; set => dni = value; }

        //Metodos
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " Telefono: " + this.telefono + " Dni: " + this.dni;
        }
    }
}
