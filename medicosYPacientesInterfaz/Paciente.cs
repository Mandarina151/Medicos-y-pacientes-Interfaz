using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicosYPacientesInterfaz
{
    class Paciente:Persona
    {
        public int numPaciente;
        public Medico medicoAsignado;

        public Paciente()
        {
        }

        public Paciente(string nombre, string telefono, string dni, int numpaciente, Medico medico) : base(nombre, telefono, dni)
        {
            Nombre = nombre;
            Telefono = telefono;
            Dni = dni;
            NumPaciente = numpaciente;
            MedicoAsignado = medico;

        }

        public int NumPaciente { get => numPaciente; set => numPaciente = value; }
        public Medico MedicoAsignado { get => medicoAsignado; set => medicoAsignado = value; }

        //Metodos
        public override string ToString()
        {
            return base.ToString() + " numPaciente : " + this.numPaciente + " ID Medico: " + medicoAsignado.IdMedico;
        }
    }
}
