namespace Lab5Bases
{
    partial class AgregarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatoEstudiante = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labeNacimiento = new System.Windows.Forms.Label();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasc = new System.Windows.Forms.RadioButton();
            this.textBoxContrasenna = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelContrasenna = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCarne = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCarne = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.linkLabelListaEstudiantes = new System.Windows.Forms.LinkLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.linkLabelEliminarEstudiantes = new System.Windows.Forms.LinkLabel();
            this.DatoEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoEstudiante
            // 
            this.DatoEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatoEstudiante.Controls.Add(this.buttonGuardar);
            this.DatoEstudiante.Controls.Add(this.textBoxDireccion);
            this.DatoEstudiante.Controls.Add(this.fechaNacimientoPicker);
            this.DatoEstudiante.Controls.Add(this.labelDireccion);
            this.DatoEstudiante.Controls.Add(this.labeNacimiento);
            this.DatoEstudiante.Controls.Add(this.radioButtonFemenino);
            this.DatoEstudiante.Controls.Add(this.radioButtonMasc);
            this.DatoEstudiante.Controls.Add(this.textBoxContrasenna);
            this.DatoEstudiante.Controls.Add(this.textBoxUsuario);
            this.DatoEstudiante.Controls.Add(this.textBoxEmail);
            this.DatoEstudiante.Controls.Add(this.textBoxTelefono);
            this.DatoEstudiante.Controls.Add(this.labelContrasenna);
            this.DatoEstudiante.Controls.Add(this.labelUsuario);
            this.DatoEstudiante.Controls.Add(this.labelSexo);
            this.DatoEstudiante.Controls.Add(this.labelEmail);
            this.DatoEstudiante.Controls.Add(this.labelTelefono);
            this.DatoEstudiante.Controls.Add(this.textBoxApellido2);
            this.DatoEstudiante.Controls.Add(this.textBoxApellido1);
            this.DatoEstudiante.Controls.Add(this.textBoxNombre);
            this.DatoEstudiante.Controls.Add(this.textBoxCarne);
            this.DatoEstudiante.Controls.Add(this.textBoxCedula);
            this.DatoEstudiante.Controls.Add(this.labelApellido2);
            this.DatoEstudiante.Controls.Add(this.labelApellido1);
            this.DatoEstudiante.Controls.Add(this.labelNombre);
            this.DatoEstudiante.Controls.Add(this.labelCarne);
            this.DatoEstudiante.Controls.Add(this.labelCedula);
            this.DatoEstudiante.Location = new System.Drawing.Point(12, 80);
            this.DatoEstudiante.Name = "DatoEstudiante";
            this.DatoEstudiante.Size = new System.Drawing.Size(941, 450);
            this.DatoEstudiante.TabIndex = 0;
            this.DatoEstudiante.TabStop = false;
            this.DatoEstudiante.Text = "Datos del estudiante";
            this.DatoEstudiante.Enter += new System.EventHandler(this.datosEstudiante_Enter);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(738, 392);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 32);
            this.buttonGuardar.TabIndex = 24;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(230, 368);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(200, 26);
            this.textBoxDireccion.TabIndex = 23;
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(230, 322);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(200, 26);
            this.fechaNacimientoPicker.TabIndex = 22;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(49, 368);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(75, 20);
            this.labelDireccion.TabIndex = 21;
            this.labelDireccion.Text = "Dirección";
            // 
            // labeNacimiento
            // 
            this.labeNacimiento.AutoSize = true;
            this.labeNacimiento.Location = new System.Drawing.Point(49, 322);
            this.labeNacimiento.Name = "labeNacimiento";
            this.labeNacimiento.Size = new System.Drawing.Size(159, 20);
            this.labeNacimiento.TabIndex = 20;
            this.labeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(643, 221);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(105, 24);
            this.radioButtonFemenino.TabIndex = 19;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasc
            // 
            this.radioButtonMasc.AutoSize = true;
            this.radioButtonMasc.Location = new System.Drawing.Point(643, 180);
            this.radioButtonMasc.Name = "radioButtonMasc";
            this.radioButtonMasc.Size = new System.Drawing.Size(105, 24);
            this.radioButtonMasc.TabIndex = 18;
            this.radioButtonMasc.TabStop = true;
            this.radioButtonMasc.Text = "Masculino";
            this.radioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // textBoxContrasenna
            // 
            this.textBoxContrasenna.Location = new System.Drawing.Point(643, 340);
            this.textBoxContrasenna.Name = "textBoxContrasenna";
            this.textBoxContrasenna.PasswordChar = '*';
            this.textBoxContrasenna.Size = new System.Drawing.Size(203, 26);
            this.textBoxContrasenna.TabIndex = 17;
            this.textBoxContrasenna.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(643, 286);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(203, 26);
            this.textBoxUsuario.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(643, 117);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 26);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(643, 78);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(203, 26);
            this.textBoxTelefono.TabIndex = 14;
            // 
            // labelContrasenna
            // 
            this.labelContrasenna.AutoSize = true;
            this.labelContrasenna.Location = new System.Drawing.Point(479, 340);
            this.labelContrasenna.Name = "labelContrasenna";
            this.labelContrasenna.Size = new System.Drawing.Size(92, 20);
            this.labelContrasenna.TabIndex = 13;
            this.labelContrasenna.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(479, 289);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 12;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(479, 170);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 11;
            this.labelSexo.Text = "Sexo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(479, 118);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(479, 79);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 1;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(230, 263);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(200, 26);
            this.textBoxApellido2.TabIndex = 9;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(230, 214);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(200, 26);
            this.textBoxApellido1.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(230, 163);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxCarne
            // 
            this.textBoxCarne.Location = new System.Drawing.Point(230, 118);
            this.textBoxCarne.Name = "textBoxCarne";
            this.textBoxCarne.Size = new System.Drawing.Size(200, 26);
            this.textBoxCarne.TabIndex = 6;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(230, 79);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(200, 26);
            this.textBoxCedula.TabIndex = 5;
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Location = new System.Drawing.Point(49, 269);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(134, 20);
            this.labelApellido2.TabIndex = 4;
            this.labelApellido2.Text = "Segundo Apellido";
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(49, 221);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(114, 20);
            this.labelApellido1.TabIndex = 3;
            this.labelApellido1.Text = "Primer Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(49, 170);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_click);
            // 
            // labelCarne
            // 
            this.labelCarne.AutoSize = true;
            this.labelCarne.Location = new System.Drawing.Point(49, 118);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(52, 20);
            this.labelCarne.TabIndex = 1;
            this.labelCarne.Text = "Carné";
            this.labelCarne.Click += new System.EventHandler(this.labelCedula_click);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(49, 79);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(59, 20);
            this.labelCedula.TabIndex = 0;
            this.labelCedula.Text = "Cédula";
            this.labelCedula.Click += new System.EventHandler(this.labelCedula_click);
            // 
            // linkLabelListaEstudiantes
            // 
            this.linkLabelListaEstudiantes.AutoSize = true;
            this.linkLabelListaEstudiantes.Location = new System.Drawing.Point(763, 9);
            this.linkLabelListaEstudiantes.Name = "linkLabelListaEstudiantes";
            this.linkLabelListaEstudiantes.Size = new System.Drawing.Size(173, 20);
            this.linkLabelListaEstudiantes.TabIndex = 1;
            this.linkLabelListaEstudiantes.TabStop = true;
            this.linkLabelListaEstudiantes.Text = "Ir a lista de estudiantes";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTitulo.Location = new System.Drawing.Point(394, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(182, 29);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Laboratorio #3";
            // 
            // linkLabelEliminarEstudiantes
            // 
            this.linkLabelEliminarEstudiantes.AutoSize = true;
            this.linkLabelEliminarEstudiantes.Location = new System.Drawing.Point(792, 41);
            this.linkLabelEliminarEstudiantes.Name = "linkLabelEliminarEstudiantes";
            this.linkLabelEliminarEstudiantes.Size = new System.Drawing.Size(144, 20);
            this.linkLabelEliminarEstudiantes.TabIndex = 3;
            this.linkLabelEliminarEstudiantes.TabStop = true;
            this.linkLabelEliminarEstudiantes.Text = "Eliminar estudiante";
            // 
            // AgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 542);
            this.Controls.Add(this.linkLabelEliminarEstudiantes);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.linkLabelListaEstudiantes);
            this.Controls.Add(this.DatoEstudiante);
            this.Name = "AgregarEstudiante";
            this.Text = "Agregar Estudiante";
            this.DatoEstudiante.ResumeLayout(false);
            this.DatoEstudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatoEstudiante;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelCarne;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxCarne;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.Label labelContrasenna;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxContrasenna;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.RadioButton radioButtonMasc;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labeNacimiento;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.LinkLabel linkLabelListaEstudiantes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.LinkLabel linkLabelEliminarEstudiantes;
    }
}

