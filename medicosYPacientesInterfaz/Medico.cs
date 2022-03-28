using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicosYPacientesInterfaz
{
    public enum PuestoMedico
    {
        Pediatra,
        Cirujano,
        Dermatologo,
        Cardiologo
    }
    class Medico : Persona
    {
        int idMedico;
        PuestoMedico puesto;
        public Medico()
        {
        }

        public Medico(string nombre, string telefono, string dni, int idmedico, PuestoMedico puesto) : base(nombre, telefono, dni)
        {
            Nombre = nombre;
            Telefono = telefono;
            Dni = dni;
            IdMedico = idmedico;
            Puesto = puesto;

        }

        public int IdMedico { get => idMedico; set => idMedico = value; }
        public PuestoMedico Puesto { get => puesto; set => puesto = value; }

        //Metodos
        public override string ToString()
        {
            return base.ToString() + " ID Medico: " + this.idMedico + " Puesto: " + this.puesto;
        }
    }
}
