using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicosYPacientesInterfaz
{
    public partial class Form1 : Form
    {
        List<Medico> listaMedicos = new List<Medico>();
        List<Paciente> listaPacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            //Recogiendo variables de los inputs.
            string nombre = this.inputTxtNombre.Text;
            string telefono = this.inputTextTelefono.Text;
            string dni = this.inputTextDni.Text;
            int idmedico = Int32.Parse(this.inputTextIdMedico.Text);
            string puesto = (string)this.inputComboBoxPuestos.SelectedItem;

            Medico nuevoMedico = new Medico(nombre, telefono, dni, idmedico, (PuestoMedico)Enum.Parse(typeof(PuestoMedico), puesto));

            listaMedicos.Add(nuevoMedico);

            this.registroMedico.Visible = false;
            this.Menu.Visible = true;
        }

        private void btnAltaMedico_Click(object sender, EventArgs e)
        {
            this.registroMedico.Visible = true;
            this.Menu.Visible = false;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.ListadoMedicos.Visible = false;
            this.Menu.Visible = true;
        }

        private void btnListaMedicos_Click(object sender, EventArgs e)
        {
            this.lblListadoMedico.Text = null;
            for (int i = 0; i < listaMedicos.Count; i++)
            {
                this.lblListadoMedico.Text += listaMedicos[i].ToString() + "\n";
            }
            this.ListadoMedicos.Visible = true;
            this.Menu.Visible = false;
        }

        private void btnAñadirPacienteConMedico_Click(object sender, EventArgs e)
        {
            this.registroPaciente.Visible = true;
            this.Menu.Visible = false;
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            string nombre = this.nombrePaciente.Text;
            string telefono = this.telefonoPaciente.Text;
            string dni = this.dniPaciente.Text;
            int idmedico = Int32.Parse(this.idMedicoPaciente.Text);
            int numPaciente = Int32.Parse(this.numPaciente.Text);
            Medico MedicoPaciente = new Medico();

            for (int i = 0; i < listaMedicos.Count; i++)
            {
                if (listaMedicos[i].IdMedico == idmedico)
                    MedicoPaciente = listaMedicos[i];

            }

            Paciente NuevoPaciente = new Paciente(nombre,telefono,dni,numPaciente,MedicoPaciente);

            listaPacientes.Add(NuevoPaciente);

            this.registroPaciente.Visible = false;
            this.Menu.Visible = true;
        }

        private void btnListaPacientesDeMedico_Click(object sender, EventArgs e)
        {
            this.panelBuscarMedicoPorPacienete.Visible = true;
            this.Menu.Visible = false;
        }

        private void btnBuscarPacientesPorMedico_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientesPorIdMedico = new List<Paciente>();
            int idMedico = int.Parse(this.inputTextIDMedicoABuscar.Text);

            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if (listaPacientes[i].MedicoAsignado.IdMedico == idMedico)
                {
                    pacientesPorIdMedico.Add(listaPacientes[i]);
                    
                }
                   
            }

            this.lbllistadoPacientesXMedico.Text = "";
            for (int i = 0; i < pacientesPorIdMedico.Count; i++)
            {
                this.lbllistadoPacientesXMedico.Text += pacientesPorIdMedico[i].ToString() + "\n";
            }

            this.listadoPacientesPorMedico.Visible = true;
            this.panelBuscarMedicoPorPacienete.Visible = false;
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.listadoPacientesPorMedico.Visible = false;
            this.Menu.Visible = true;
        }

        private void btnListaHospital_Click(object sender, EventArgs e)
        {
            this.panelListadoHospital.Visible = true;
            this.Menu.Visible = false;

            if (listaMedicos.Count!=0 || listaPacientes.Count != 0)
            {
                this.lblListadoHospital.Text = "";
                if (listaMedicos != null)
                {
                    for (int i = 0; i < listaMedicos.Count; i++)
                        this.lblListadoHospital.Text += listaMedicos[i].ToString() + "\n";
                }
                if (listaPacientes != null)
                {
                    for (int i = 0; i < listaPacientes.Count; i++)
                        this.lblListadoHospital.Text += listaPacientes[i].ToString() + "\n";
                }
            }            
        }

        private void btnVolverMenuHospital_Click(object sender, EventArgs e)
        {
            this.panelListadoHospital.Visible = false;
            this.Menu.Visible = true;
        }

        private void btnBorrarPaciente_Click(object sender, EventArgs e)
        {
            this.Menu.Visible = false;
            this.panelEliminarPaciente.Visible = true;
            this.buttonEliminarPaciente.Visible = true;
        }

        private void buttonEliminarPaciente_Click(object sender, EventArgs e)
        {
            int numPacienteEliminar = Int32.Parse(this.textBoxNumEliminar.Text);
            bool pacienteEliminated = false;

            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if (listaPacientes[i].numPaciente == numPacienteEliminar)
                {
                    listaPacientes.RemoveAt(i);
                    pacienteEliminated = true;
                }
            }

            if(pacienteEliminated)
                MessageBox.Show("El paciente se elimino.");
            else
                MessageBox.Show("El paciente no se encontro.");

            this.panelEliminarPaciente.Visible = false;
            this.buttonEliminarPaciente.Visible = false;
            this.Menu.Visible = true;
        }

        private void buttonModificarPaciente_Click(object sender, EventArgs e)
        {
            this.registroPaciente.Visible = true;
            this.btnModPaciente.Visible = true;
            this.panelEliminarPaciente.Visible = false;
            this.buttonModificarPaciente.Visible = false;
            this.numPaciente.Visible = false;
            this.btnCrearPaciente.Visible = false;
        }

        private void buttonModPaciente_Click(object sender, EventArgs e)
        {
            this.Menu.Visible = false;
            this.panelEliminarPaciente.Visible = true;
            this.buttonModificarPaciente.Visible = true;
        }

        private void btnModPaciente_Click(object sender, EventArgs e)
        {
            string nombre = this.nombrePaciente.Text;
            string telef = this.telefonoPaciente.Text;
            string dni = this.telefonoPaciente.Text;
            int numPaciente = Int32.Parse(this.textBoxNumEliminar.Text);
            int idMedico = Int32.Parse(this.idMedicoPaciente.Text);
            Medico medicoNuevo = new Medico();
            bool pacienteModified = false;

            for (int i = 0; i < listaMedicos.Count; i++)
            {
                if (listaMedicos[i].IdMedico == idMedico)
                    medicoNuevo = listaMedicos[i];
            }

            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if (listaPacientes[i].numPaciente == numPaciente)
                {
                    listaPacientes[i].Nombre = nombre;
                    listaPacientes[i].Telefono = telef;
                    listaPacientes[i].Dni = dni;
                    listaPacientes[i].medicoAsignado = medicoNuevo;
                    pacienteModified = true;
                }
            }

            if (pacienteModified)
                MessageBox.Show("El paciente se modifico.");
            else
                MessageBox.Show("El paciente no se encontro.");
        }
    }
}
