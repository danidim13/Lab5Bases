namespace Lab5Bases
{
    partial class ListaEstudiantes
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelEstudiantes = new System.Windows.Forms.Label();
            this.dataGridEstudiantes = new System.Windows.Forms.DataGridView();
            this.linkLabelAgregarEstudiante = new System.Windows.Forms.LinkLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(37, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(117, 65);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(187, 28);
            this.comboBoxNombre.TabIndex = 1;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(408, 68);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(105, 20);
            this.labelFiltro.TabIndex = 2;
            this.labelFiltro.Text = "Filtro general:";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(519, 65);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(165, 26);
            this.textBoxFiltro.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(703, 65);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(79, 28);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelEstudiantes
            // 
            this.labelEstudiantes.AutoSize = true;
            this.labelEstudiantes.Location = new System.Drawing.Point(37, 125);
            this.labelEstudiantes.Name = "labelEstudiantes";
            this.labelEstudiantes.Size = new System.Drawing.Size(94, 20);
            this.labelEstudiantes.TabIndex = 5;
            this.labelEstudiantes.Text = "Estudiantes";
            this.labelEstudiantes.Click += new System.EventHandler(this.labelEstudiantes_Click);
            // 
            // dataGridEstudiantes
            // 
            this.dataGridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstudiantes.Location = new System.Drawing.Point(41, 148);
            this.dataGridEstudiantes.Name = "dataGridEstudiantes";
            this.dataGridEstudiantes.RowTemplate.Height = 28;
            this.dataGridEstudiantes.Size = new System.Drawing.Size(741, 234);
            this.dataGridEstudiantes.TabIndex = 6;
            // 
            // linkLabelAgregarEstudiante
            // 
            this.linkLabelAgregarEstudiante.AutoSize = true;
            this.linkLabelAgregarEstudiante.Location = new System.Drawing.Point(569, 9);
            this.linkLabelAgregarEstudiante.Name = "linkLabelAgregarEstudiante";
            this.linkLabelAgregarEstudiante.Size = new System.Drawing.Size(170, 20);
            this.linkLabelAgregarEstudiante.TabIndex = 7;
            this.linkLabelAgregarEstudiante.TabStop = true;
            this.linkLabelAgregarEstudiante.Text = "Ir a AgregarEstudiante";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTitulo.Location = new System.Drawing.Point(290, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(213, 32);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Laboratorio #3";
            // 
            // ListaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 394);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.linkLabelAgregarEstudiante);
            this.Controls.Add(this.dataGridEstudiantes);
            this.Controls.Add(this.labelEstudiantes);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "ListaEstudiantes";
            this.Text = "ListaEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelEstudiantes;
        private System.Windows.Forms.DataGridView dataGridEstudiantes;
        private System.Windows.Forms.LinkLabel linkLabelAgregarEstudiante;
        private System.Windows.Forms.Label labelTitulo;
    }
}