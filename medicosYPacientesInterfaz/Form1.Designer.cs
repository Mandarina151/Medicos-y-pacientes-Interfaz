
namespace medicosYPacientesInterfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.btnListaHospital = new System.Windows.Forms.Button();
            this.btnBorrarPaciente = new System.Windows.Forms.Button();
            this.btnListaPacientesDeMedico = new System.Windows.Forms.Button();
            this.btnListaMedicos = new System.Windows.Forms.Button();
            this.btnAñadirPacienteConMedico = new System.Windows.Forms.Button();
            this.btnAltaMedico = new System.Windows.Forms.Button();
            this.registroMedico = new System.Windows.Forms.Panel();
            this.inputComboBoxPuestos = new System.Windows.Forms.ComboBox();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.inputTextIdMedico = new System.Windows.Forms.TextBox();
            this.inputTextDni = new System.Windows.Forms.TextBox();
            this.inputTextTelefono = new System.Windows.Forms.TextBox();
            this.inputTxtNombre = new System.Windows.Forms.TextBox();
            this.ListadoMedicos = new System.Windows.Forms.Panel();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.lblListadoMedico = new System.Windows.Forms.Label();
            this.registroPaciente = new System.Windows.Forms.Panel();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.idMedicoPaciente = new System.Windows.Forms.TextBox();
            this.numPaciente = new System.Windows.Forms.TextBox();
            this.dniPaciente = new System.Windows.Forms.TextBox();
            this.telefonoPaciente = new System.Windows.Forms.TextBox();
            this.nombrePaciente = new System.Windows.Forms.TextBox();
            this.panelBuscarMedicoPorPacienete = new System.Windows.Forms.Panel();
            this.btnBuscarPacientesPorMedico = new System.Windows.Forms.Button();
            this.inputTextIDMedicoABuscar = new System.Windows.Forms.TextBox();
            this.labelListaPacientes = new System.Windows.Forms.Label();
            this.listadoPacientesPorMedico = new System.Windows.Forms.Panel();
            this.lbllistadoPacientesXMedico = new System.Windows.Forms.Label();
            this.btnVolverAlMenu = new System.Windows.Forms.Button();
            this.panelListadoHospital = new System.Windows.Forms.Panel();
            this.lblListadoHospital = new System.Windows.Forms.Label();
            this.btnVolverMenuHospital = new System.Windows.Forms.Button();
            this.panelEliminarPaciente = new System.Windows.Forms.Panel();
            this.textBoxNumEliminar = new System.Windows.Forms.TextBox();
            this.labelEliminarPaciente = new System.Windows.Forms.Label();
            this.buttonEliminarPaciente = new System.Windows.Forms.Button();
            this.buttonModificarPaciente = new System.Windows.Forms.Button();
            this.buttonModPaciente = new System.Windows.Forms.Button();
            this.btnModPaciente = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.registroMedico.SuspendLayout();
            this.ListadoMedicos.SuspendLayout();
            this.registroPaciente.SuspendLayout();
            this.panelBuscarMedicoPorPacienete.SuspendLayout();
            this.listadoPacientesPorMedico.SuspendLayout();
            this.panelListadoHospital.SuspendLayout();
            this.panelEliminarPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.buttonModPaciente);
            this.Menu.Controls.Add(this.btnListaHospital);
            this.Menu.Controls.Add(this.btnBorrarPaciente);
            this.Menu.Controls.Add(this.btnListaPacientesDeMedico);
            this.Menu.Controls.Add(this.btnListaMedicos);
            this.Menu.Controls.Add(this.btnAñadirPacienteConMedico);
            this.Menu.Controls.Add(this.btnAltaMedico);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(242, 222);
            this.Menu.TabIndex = 0;
            // 
            // btnListaHospital
            // 
            this.btnListaHospital.Location = new System.Drawing.Point(4, 162);
            this.btnListaHospital.Name = "btnListaHospital";
            this.btnListaHospital.Size = new System.Drawing.Size(235, 23);
            this.btnListaHospital.TabIndex = 5;
            this.btnListaHospital.Text = "Lista de personas presentes en el hospital ";
            this.btnListaHospital.UseVisualStyleBackColor = true;
            this.btnListaHospital.Click += new System.EventHandler(this.btnListaHospital_Click);
            // 
            // btnBorrarPaciente
            // 
            this.btnBorrarPaciente.Location = new System.Drawing.Point(17, 133);
            this.btnBorrarPaciente.Name = "btnBorrarPaciente";
            this.btnBorrarPaciente.Size = new System.Drawing.Size(190, 23);
            this.btnBorrarPaciente.TabIndex = 4;
            this.btnBorrarPaciente.Text = "Eliminar a un paciente";
            this.btnBorrarPaciente.UseVisualStyleBackColor = true;
            this.btnBorrarPaciente.Click += new System.EventHandler(this.btnBorrarPaciente_Click);
            // 
            // btnListaPacientesDeMedico
            // 
            this.btnListaPacientesDeMedico.Location = new System.Drawing.Point(17, 104);
            this.btnListaPacientesDeMedico.Name = "btnListaPacientesDeMedico";
            this.btnListaPacientesDeMedico.Size = new System.Drawing.Size(200, 23);
            this.btnListaPacientesDeMedico.TabIndex = 3;
            this.btnListaPacientesDeMedico.Text = "Listar los pacientes de un medico";
            this.btnListaPacientesDeMedico.UseVisualStyleBackColor = true;
            this.btnListaPacientesDeMedico.Click += new System.EventHandler(this.btnListaPacientesDeMedico_Click);
            // 
            // btnListaMedicos
            // 
            this.btnListaMedicos.Location = new System.Drawing.Point(17, 75);
            this.btnListaMedicos.Name = "btnListaMedicos";
            this.btnListaMedicos.Size = new System.Drawing.Size(190, 23);
            this.btnListaMedicos.TabIndex = 2;
            this.btnListaMedicos.Text = "Listar los medicos";
            this.btnListaMedicos.UseVisualStyleBackColor = true;
            this.btnListaMedicos.Click += new System.EventHandler(this.btnListaMedicos_Click);
            // 
            // btnAñadirPacienteConMedico
            // 
            this.btnAñadirPacienteConMedico.Location = new System.Drawing.Point(4, 46);
            this.btnAñadirPacienteConMedico.Name = "btnAñadirPacienteConMedico";
            this.btnAñadirPacienteConMedico.Size = new System.Drawing.Size(224, 23);
            this.btnAñadirPacienteConMedico.TabIndex = 1;
            this.btnAñadirPacienteConMedico.Text = "Dar de alta un paciente, para un medico concreto";
            this.btnAñadirPacienteConMedico.UseVisualStyleBackColor = true;
            this.btnAñadirPacienteConMedico.Click += new System.EventHandler(this.btnAñadirPacienteConMedico_Click);
            // 
            // btnAltaMedico
            // 
            this.btnAltaMedico.Location = new System.Drawing.Point(46, 17);
            this.btnAltaMedico.Name = "btnAltaMedico";
            this.btnAltaMedico.Size = new System.Drawing.Size(137, 23);
            this.btnAltaMedico.TabIndex = 0;
            this.btnAltaMedico.Text = "Dar de alta a un medico";
            this.btnAltaMedico.UseVisualStyleBackColor = true;
            this.btnAltaMedico.Click += new System.EventHandler(this.btnAltaMedico_Click);
            // 
            // registroMedico
            // 
            this.registroMedico.Controls.Add(this.inputComboBoxPuestos);
            this.registroMedico.Controls.Add(this.btnCrearMedico);
            this.registroMedico.Controls.Add(this.inputTextIdMedico);
            this.registroMedico.Controls.Add(this.inputTextDni);
            this.registroMedico.Controls.Add(this.inputTextTelefono);
            this.registroMedico.Controls.Add(this.inputTxtNombre);
            this.registroMedico.Location = new System.Drawing.Point(260, 19);
            this.registroMedico.Name = "registroMedico";
            this.registroMedico.Size = new System.Drawing.Size(127, 184);
            this.registroMedico.TabIndex = 1;
            this.registroMedico.Visible = false;
            // 
            // inputComboBoxPuestos
            // 
            this.inputComboBoxPuestos.FormattingEnabled = true;
            this.inputComboBoxPuestos.Items.AddRange(new object[] {
            "Pediatra",
            "Cirujano",
            "Dermatologo",
            "Cardiologo"});
            this.inputComboBoxPuestos.Location = new System.Drawing.Point(17, 118);
            this.inputComboBoxPuestos.Name = "inputComboBoxPuestos";
            this.inputComboBoxPuestos.Size = new System.Drawing.Size(99, 21);
            this.inputComboBoxPuestos.TabIndex = 6;
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(27, 154);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMedico.TabIndex = 5;
            this.btnCrearMedico.Text = "Crear medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // inputTextIdMedico
            // 
            this.inputTextIdMedico.Location = new System.Drawing.Point(17, 92);
            this.inputTextIdMedico.Name = "inputTextIdMedico";
            this.inputTextIdMedico.Size = new System.Drawing.Size(100, 20);
            this.inputTextIdMedico.TabIndex = 3;
            this.inputTextIdMedico.Text = "ID Medico";
            // 
            // inputTextDni
            // 
            this.inputTextDni.Location = new System.Drawing.Point(17, 65);
            this.inputTextDni.Name = "inputTextDni";
            this.inputTextDni.Size = new System.Drawing.Size(100, 20);
            this.inputTextDni.TabIndex = 2;
            this.inputTextDni.Text = "DNI";
            // 
            // inputTextTelefono
            // 
            this.inputTextTelefono.Location = new System.Drawing.Point(17, 39);
            this.inputTextTelefono.Name = "inputTextTelefono";
            this.inputTextTelefono.Size = new System.Drawing.Size(100, 20);
            this.inputTextTelefono.TabIndex = 1;
            this.inputTextTelefono.Text = "Telefono";
            // 
            // inputTxtNombre
            // 
            this.inputTxtNombre.Location = new System.Drawing.Point(17, 12);
            this.inputTxtNombre.Name = "inputTxtNombre";
            this.inputTxtNombre.Size = new System.Drawing.Size(100, 20);
            this.inputTxtNombre.TabIndex = 0;
            this.inputTxtNombre.Text = "Nombre";
            // 
            // ListadoMedicos
            // 
            this.ListadoMedicos.Controls.Add(this.btnVolverMenu);
            this.ListadoMedicos.Controls.Add(this.lblListadoMedico);
            this.ListadoMedicos.Location = new System.Drawing.Point(29, 546);
            this.ListadoMedicos.Name = "ListadoMedicos";
            this.ListadoMedicos.Size = new System.Drawing.Size(808, 123);
            this.ListadoMedicos.TabIndex = 2;
            this.ListadoMedicos.Visible = false;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(349, 93);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(123, 23);
            this.btnVolverMenu.TabIndex = 1;
            this.btnVolverMenu.Text = "Volver a menu";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // lblListadoMedico
            // 
            this.lblListadoMedico.AutoSize = true;
            this.lblListadoMedico.Location = new System.Drawing.Point(62, 32);
            this.lblListadoMedico.Name = "lblListadoMedico";
            this.lblListadoMedico.Size = new System.Drawing.Size(0, 13);
            this.lblListadoMedico.TabIndex = 0;
            // 
            // registroPaciente
            // 
            this.registroPaciente.Controls.Add(this.btnModPaciente);
            this.registroPaciente.Controls.Add(this.btnCrearPaciente);
            this.registroPaciente.Controls.Add(this.idMedicoPaciente);
            this.registroPaciente.Controls.Add(this.numPaciente);
            this.registroPaciente.Controls.Add(this.dniPaciente);
            this.registroPaciente.Controls.Add(this.telefonoPaciente);
            this.registroPaciente.Controls.Add(this.nombrePaciente);
            this.registroPaciente.Location = new System.Drawing.Point(393, 19);
            this.registroPaciente.Name = "registroPaciente";
            this.registroPaciente.Size = new System.Drawing.Size(150, 184);
            this.registroPaciente.TabIndex = 3;
            this.registroPaciente.Visible = false;
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(3, 154);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(66, 23);
            this.btnCrearPaciente.TabIndex = 6;
            this.btnCrearPaciente.Text = "Crear medico";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // idMedicoPaciente
            // 
            this.idMedicoPaciente.Location = new System.Drawing.Point(22, 119);
            this.idMedicoPaciente.Name = "idMedicoPaciente";
            this.idMedicoPaciente.Size = new System.Drawing.Size(100, 20);
            this.idMedicoPaciente.TabIndex = 7;
            this.idMedicoPaciente.Text = "ID Medico";
            // 
            // numPaciente
            // 
            this.numPaciente.Location = new System.Drawing.Point(22, 92);
            this.numPaciente.Name = "numPaciente";
            this.numPaciente.Size = new System.Drawing.Size(100, 20);
            this.numPaciente.TabIndex = 8;
            this.numPaciente.Text = "numPaciente";
            // 
            // dniPaciente
            // 
            this.dniPaciente.Location = new System.Drawing.Point(22, 64);
            this.dniPaciente.Name = "dniPaciente";
            this.dniPaciente.Size = new System.Drawing.Size(100, 20);
            this.dniPaciente.TabIndex = 7;
            this.dniPaciente.Text = "DNI";
            // 
            // telefonoPaciente
            // 
            this.telefonoPaciente.Location = new System.Drawing.Point(22, 38);
            this.telefonoPaciente.Name = "telefonoPaciente";
            this.telefonoPaciente.Size = new System.Drawing.Size(100, 20);
            this.telefonoPaciente.TabIndex = 2;
            this.telefonoPaciente.Text = "Telefono";
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.Location = new System.Drawing.Point(22, 12);
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.nombrePaciente.TabIndex = 1;
            this.nombrePaciente.Text = "Nombre";
            // 
            // panelBuscarMedicoPorPacienete
            // 
            this.panelBuscarMedicoPorPacienete.Controls.Add(this.btnBuscarPacientesPorMedico);
            this.panelBuscarMedicoPorPacienete.Controls.Add(this.inputTextIDMedicoABuscar);
            this.panelBuscarMedicoPorPacienete.Controls.Add(this.labelListaPacientes);
            this.panelBuscarMedicoPorPacienete.Location = new System.Drawing.Point(563, 19);
            this.panelBuscarMedicoPorPacienete.Name = "panelBuscarMedicoPorPacienete";
            this.panelBuscarMedicoPorPacienete.Size = new System.Drawing.Size(288, 75);
            this.panelBuscarMedicoPorPacienete.TabIndex = 9;
            this.panelBuscarMedicoPorPacienete.Visible = false;
            // 
            // btnBuscarPacientesPorMedico
            // 
            this.btnBuscarPacientesPorMedico.Location = new System.Drawing.Point(90, 52);
            this.btnBuscarPacientesPorMedico.Name = "btnBuscarPacientesPorMedico";
            this.btnBuscarPacientesPorMedico.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPacientesPorMedico.TabIndex = 2;
            this.btnBuscarPacientesPorMedico.Text = "Buscar";
            this.btnBuscarPacientesPorMedico.UseVisualStyleBackColor = true;
            this.btnBuscarPacientesPorMedico.Click += new System.EventHandler(this.btnBuscarPacientesPorMedico_Click);
            // 
            // inputTextIDMedicoABuscar
            // 
            this.inputTextIDMedicoABuscar.Location = new System.Drawing.Point(56, 26);
            this.inputTextIDMedicoABuscar.Name = "inputTextIDMedicoABuscar";
            this.inputTextIDMedicoABuscar.Size = new System.Drawing.Size(157, 20);
            this.inputTextIDMedicoABuscar.TabIndex = 1;
            // 
            // labelListaPacientes
            // 
            this.labelListaPacientes.AutoSize = true;
            this.labelListaPacientes.Location = new System.Drawing.Point(19, 10);
            this.labelListaPacientes.Name = "labelListaPacientes";
            this.labelListaPacientes.Size = new System.Drawing.Size(242, 13);
            this.labelListaPacientes.TabIndex = 0;
            this.labelListaPacientes.Text = "Inserte la id del medico para buscar sus pacientes";
            // 
            // listadoPacientesPorMedico
            // 
            this.listadoPacientesPorMedico.Controls.Add(this.lbllistadoPacientesXMedico);
            this.listadoPacientesPorMedico.Controls.Add(this.btnVolverAlMenu);
            this.listadoPacientesPorMedico.Location = new System.Drawing.Point(29, 391);
            this.listadoPacientesPorMedico.Name = "listadoPacientesPorMedico";
            this.listadoPacientesPorMedico.Size = new System.Drawing.Size(808, 149);
            this.listadoPacientesPorMedico.TabIndex = 10;
            this.listadoPacientesPorMedico.Visible = false;
            // 
            // lbllistadoPacientesXMedico
            // 
            this.lbllistadoPacientesXMedico.AutoSize = true;
            this.lbllistadoPacientesXMedico.Location = new System.Drawing.Point(285, 37);
            this.lbllistadoPacientesXMedico.Name = "lbllistadoPacientesXMedico";
            this.lbllistadoPacientesXMedico.Size = new System.Drawing.Size(0, 13);
            this.lbllistadoPacientesXMedico.TabIndex = 3;
            // 
            // btnVolverAlMenu
            // 
            this.btnVolverAlMenu.Location = new System.Drawing.Point(338, 123);
            this.btnVolverAlMenu.Name = "btnVolverAlMenu";
            this.btnVolverAlMenu.Size = new System.Drawing.Size(123, 23);
            this.btnVolverAlMenu.TabIndex = 2;
            this.btnVolverAlMenu.Text = "Volver a menu";
            this.btnVolverAlMenu.UseVisualStyleBackColor = true;
            this.btnVolverAlMenu.Click += new System.EventHandler(this.btnVolverAlMenu_Click);
            // 
            // panelListadoHospital
            // 
            this.panelListadoHospital.Controls.Add(this.lblListadoHospital);
            this.panelListadoHospital.Controls.Add(this.btnVolverMenuHospital);
            this.panelListadoHospital.Location = new System.Drawing.Point(29, 240);
            this.panelListadoHospital.Name = "panelListadoHospital";
            this.panelListadoHospital.Size = new System.Drawing.Size(808, 145);
            this.panelListadoHospital.TabIndex = 11;
            this.panelListadoHospital.Visible = false;
            // 
            // lblListadoHospital
            // 
            this.lblListadoHospital.AutoSize = true;
            this.lblListadoHospital.Location = new System.Drawing.Point(320, 58);
            this.lblListadoHospital.Name = "lblListadoHospital";
            this.lblListadoHospital.Size = new System.Drawing.Size(152, 13);
            this.lblListadoHospital.TabIndex = 1;
            this.lblListadoHospital.Text = "No hay personas en el hospital";
            // 
            // btnVolverMenuHospital
            // 
            this.btnVolverMenuHospital.Location = new System.Drawing.Point(344, 88);
            this.btnVolverMenuHospital.Name = "btnVolverMenuHospital";
            this.btnVolverMenuHospital.Size = new System.Drawing.Size(128, 23);
            this.btnVolverMenuHospital.TabIndex = 0;
            this.btnVolverMenuHospital.Text = "Volver a menu";
            this.btnVolverMenuHospital.UseVisualStyleBackColor = true;
            this.btnVolverMenuHospital.Click += new System.EventHandler(this.btnVolverMenuHospital_Click);
            // 
            // panelEliminarPaciente
            // 
            this.panelEliminarPaciente.Controls.Add(this.buttonModificarPaciente);
            this.panelEliminarPaciente.Controls.Add(this.textBoxNumEliminar);
            this.panelEliminarPaciente.Controls.Add(this.labelEliminarPaciente);
            this.panelEliminarPaciente.Controls.Add(this.buttonEliminarPaciente);
            this.panelEliminarPaciente.Location = new System.Drawing.Point(563, 103);
            this.panelEliminarPaciente.Name = "panelEliminarPaciente";
            this.panelEliminarPaciente.Size = new System.Drawing.Size(288, 100);
            this.panelEliminarPaciente.TabIndex = 12;
            this.panelEliminarPaciente.Visible = false;
            // 
            // textBoxNumEliminar
            // 
            this.textBoxNumEliminar.Location = new System.Drawing.Point(56, 35);
            this.textBoxNumEliminar.Name = "textBoxNumEliminar";
            this.textBoxNumEliminar.Size = new System.Drawing.Size(185, 20);
            this.textBoxNumEliminar.TabIndex = 2;
            // 
            // labelEliminarPaciente
            // 
            this.labelEliminarPaciente.AutoSize = true;
            this.labelEliminarPaciente.Location = new System.Drawing.Point(78, 11);
            this.labelEliminarPaciente.Name = "labelEliminarPaciente";
            this.labelEliminarPaciente.Size = new System.Drawing.Size(135, 13);
            this.labelEliminarPaciente.TabIndex = 1;
            this.labelEliminarPaciente.Text = "Inserte el num. de paciente";
            // 
            // buttonEliminarPaciente
            // 
            this.buttonEliminarPaciente.Location = new System.Drawing.Point(56, 70);
            this.buttonEliminarPaciente.Name = "buttonEliminarPaciente";
            this.buttonEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarPaciente.TabIndex = 0;
            this.buttonEliminarPaciente.Text = "Eliminar";
            this.buttonEliminarPaciente.UseVisualStyleBackColor = true;
            this.buttonEliminarPaciente.Click += new System.EventHandler(this.buttonEliminarPaciente_Click);
            // 
            // buttonModificarPaciente
            // 
            this.buttonModificarPaciente.Location = new System.Drawing.Point(166, 70);
            this.buttonModificarPaciente.Name = "buttonModificarPaciente";
            this.buttonModificarPaciente.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarPaciente.TabIndex = 3;
            this.buttonModificarPaciente.Text = "Modificar";
            this.buttonModificarPaciente.UseVisualStyleBackColor = true;
            this.buttonModificarPaciente.Visible = false;
            this.buttonModificarPaciente.Click += new System.EventHandler(this.buttonModificarPaciente_Click);
            // 
            // buttonModPaciente
            // 
            this.buttonModPaciente.Location = new System.Drawing.Point(15, 191);
            this.buttonModPaciente.Name = "buttonModPaciente";
            this.buttonModPaciente.Size = new System.Drawing.Size(213, 23);
            this.buttonModPaciente.TabIndex = 13;
            this.buttonModPaciente.Text = "Modificar paciente";
            this.buttonModPaciente.UseVisualStyleBackColor = true;
            this.buttonModPaciente.Click += new System.EventHandler(this.buttonModPaciente_Click);
            // 
            // btnModPaciente
            // 
            this.btnModPaciente.Location = new System.Drawing.Point(72, 154);
            this.btnModPaciente.Name = "btnModPaciente";
            this.btnModPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnModPaciente.TabIndex = 9;
            this.btnModPaciente.Text = "Modificar";
            this.btnModPaciente.UseVisualStyleBackColor = true;
            this.btnModPaciente.Visible = false;
            this.btnModPaciente.Click += new System.EventHandler(this.btnModPaciente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 670);
            this.Controls.Add(this.panelEliminarPaciente);
            this.Controls.Add(this.panelListadoHospital);
            this.Controls.Add(this.listadoPacientesPorMedico);
            this.Controls.Add(this.panelBuscarMedicoPorPacienete);
            this.Controls.Add(this.registroPaciente);
            this.Controls.Add(this.ListadoMedicos);
            this.Controls.Add(this.registroMedico);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.registroMedico.ResumeLayout(false);
            this.registroMedico.PerformLayout();
            this.ListadoMedicos.ResumeLayout(false);
            this.ListadoMedicos.PerformLayout();
            this.registroPaciente.ResumeLayout(false);
            this.registroPaciente.PerformLayout();
            this.panelBuscarMedicoPorPacienete.ResumeLayout(false);
            this.panelBuscarMedicoPorPacienete.PerformLayout();
            this.listadoPacientesPorMedico.ResumeLayout(false);
            this.listadoPacientesPorMedico.PerformLayout();
            this.panelListadoHospital.ResumeLayout(false);
            this.panelListadoHospital.PerformLayout();
            this.panelEliminarPaciente.ResumeLayout(false);
            this.panelEliminarPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnListaHospital;
        private System.Windows.Forms.Button btnBorrarPaciente;
        private System.Windows.Forms.Button btnListaPacientesDeMedico;
        private System.Windows.Forms.Button btnListaMedicos;
        private System.Windows.Forms.Button btnAñadirPacienteConMedico;
        private System.Windows.Forms.Button btnAltaMedico;
        private System.Windows.Forms.Panel registroMedico;
        private System.Windows.Forms.TextBox inputTxtNombre;
        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.TextBox inputTextIdMedico;
        private System.Windows.Forms.TextBox inputTextDni;
        private System.Windows.Forms.TextBox inputTextTelefono;
        private System.Windows.Forms.ComboBox inputComboBoxPuestos;
        private System.Windows.Forms.Panel ListadoMedicos;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Label lblListadoMedico;
        private System.Windows.Forms.Panel registroPaciente;
        private System.Windows.Forms.TextBox dniPaciente;
        private System.Windows.Forms.TextBox telefonoPaciente;
        private System.Windows.Forms.TextBox nombrePaciente;
        private System.Windows.Forms.TextBox idMedicoPaciente;
        private System.Windows.Forms.TextBox numPaciente;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Panel panelBuscarMedicoPorPacienete;
        private System.Windows.Forms.Button btnBuscarPacientesPorMedico;
        private System.Windows.Forms.TextBox inputTextIDMedicoABuscar;
        private System.Windows.Forms.Label labelListaPacientes;
        private System.Windows.Forms.Panel listadoPacientesPorMedico;
        private System.Windows.Forms.Button btnVolverAlMenu;
        private System.Windows.Forms.Label lbllistadoPacientesXMedico;
        private System.Windows.Forms.Panel panelListadoHospital;
        private System.Windows.Forms.Label lblListadoHospital;
        private System.Windows.Forms.Button btnVolverMenuHospital;
        private System.Windows.Forms.Panel panelEliminarPaciente;
        private System.Windows.Forms.TextBox textBoxNumEliminar;
        private System.Windows.Forms.Label labelEliminarPaciente;
        private System.Windows.Forms.Button buttonEliminarPaciente;
        private System.Windows.Forms.Button buttonModificarPaciente;
        private System.Windows.Forms.Button buttonModPaciente;
        private System.Windows.Forms.Button btnModPaciente;
    }
}

