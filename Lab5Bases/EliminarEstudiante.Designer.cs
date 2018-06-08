namespace Lab5Bases
{
    partial class EliminarEstudiante
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.linkLabelAgregarEstudiante = new System.Windows.Forms.LinkLabel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelEstudiantes = new System.Windows.Forms.Label();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Teal;
            this.labelTitulo.Location = new System.Drawing.Point(266, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(213, 32);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Laboratorio #3";
            // 
            // linkLabelAgregarEstudiante
            // 
            this.linkLabelAgregarEstudiante.AutoSize = true;
            this.linkLabelAgregarEstudiante.Location = new System.Drawing.Point(580, 9);
            this.linkLabelAgregarEstudiante.Name = "linkLabelAgregarEstudiante";
            this.linkLabelAgregarEstudiante.Size = new System.Drawing.Size(174, 20);
            this.linkLabelAgregarEstudiante.TabIndex = 1;
            this.linkLabelAgregarEstudiante.TabStop = true;
            this.linkLabelAgregarEstudiante.Text = "Ir a Agregar Estudiante";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(33, 67);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(108, 63);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(189, 28);
            this.comboBoxNombre.TabIndex = 3;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(319, 63);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(84, 28);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // labelEstudiantes
            // 
            this.labelEstudiantes.AutoSize = true;
            this.labelEstudiantes.Location = new System.Drawing.Point(8, 105);
            this.labelEstudiantes.Name = "labelEstudiantes";
            this.labelEstudiantes.Size = new System.Drawing.Size(94, 20);
            this.labelEstudiantes.TabIndex = 5;
            this.labelEstudiantes.Text = "Estudiantes";
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.RowTemplate.Height = 28;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(742, 228);
            this.dataGridViewEstudiantes.TabIndex = 6;
            // 
            // EliminarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 379);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.labelEstudiantes);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.linkLabelAgregarEstudiante);
            this.Controls.Add(this.labelTitulo);
            this.Name = "EliminarEstudiante";
            this.Text = "EliminarEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.LinkLabel linkLabelAgregarEstudiante;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelEstudiantes;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
    }
}