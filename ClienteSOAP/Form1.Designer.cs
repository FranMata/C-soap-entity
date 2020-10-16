namespace ClienteSOAP
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCedula = new System.Windows.Forms.TextBox();
            this.TBApellido2 = new System.Windows.Forms.TextBox();
            this.TBApellido1 = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBResidencia = new System.Windows.Forms.TextBox();
            this.BTNEnviar = new System.Windows.Forms.Button();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidop1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Residencia";
            // 
            // TBCedula
            // 
            this.TBCedula.Location = new System.Drawing.Point(185, 35);
            this.TBCedula.Name = "TBCedula";
            this.TBCedula.Size = new System.Drawing.Size(238, 20);
            this.TBCedula.TabIndex = 5;
            // 
            // TBApellido2
            // 
            this.TBApellido2.Location = new System.Drawing.Point(185, 135);
            this.TBApellido2.Name = "TBApellido2";
            this.TBApellido2.Size = new System.Drawing.Size(238, 20);
            this.TBApellido2.TabIndex = 6;
            // 
            // TBApellido1
            // 
            this.TBApellido1.Location = new System.Drawing.Point(185, 104);
            this.TBApellido1.Name = "TBApellido1";
            this.TBApellido1.Size = new System.Drawing.Size(238, 20);
            this.TBApellido1.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(185, 71);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(238, 20);
            this.TBNombre.TabIndex = 8;
            // 
            // TBResidencia
            // 
            this.TBResidencia.Location = new System.Drawing.Point(185, 167);
            this.TBResidencia.Name = "TBResidencia";
            this.TBResidencia.Size = new System.Drawing.Size(238, 20);
            this.TBResidencia.TabIndex = 9;
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.Location = new System.Drawing.Point(565, 54);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(138, 94);
            this.BTNEnviar.TabIndex = 10;
            this.BTNEnviar.Text = "Enviar";
            this.BTNEnviar.UseVisualStyleBackColor = true;
            this.BTNEnviar.Click += new System.EventHandler(this.BTNEnviar_Click);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AutoGenerateColumns = false;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellido2DataGridViewTextBoxColumn,
            this.apellidop1DataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.residenciaDataGridViewTextBoxColumn});
            this.DGVUsuarios.DataSource = this.usuarioBindingSource;
            this.DGVUsuarios.Location = new System.Drawing.Point(47, 250);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(763, 246);
            this.DGVUsuarios.TabIndex = 11;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ClienteSOAP.SOAPReference.Usuario);
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            // 
            // apellidop1DataGridViewTextBoxColumn
            // 
            this.apellidop1DataGridViewTextBoxColumn.DataPropertyName = "Apellidop1";
            this.apellidop1DataGridViewTextBoxColumn.HeaderText = "Apellidop1";
            this.apellidop1DataGridViewTextBoxColumn.Name = "apellidop1DataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // residenciaDataGridViewTextBoxColumn
            // 
            this.residenciaDataGridViewTextBoxColumn.DataPropertyName = "Residencia";
            this.residenciaDataGridViewTextBoxColumn.HeaderText = "Residencia";
            this.residenciaDataGridViewTextBoxColumn.Name = "residenciaDataGridViewTextBoxColumn";
            // 
            // BTNCargar
            // 
            this.BTNCargar.Location = new System.Drawing.Point(565, 518);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(138, 57);
            this.BTNCargar.TabIndex = 12;
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = true;
            this.BTNCargar.Click += new System.EventHandler(this.BTNCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 596);
            this.Controls.Add(this.BTNCargar);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.BTNEnviar);
            this.Controls.Add(this.TBResidencia);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBApellido1);
            this.Controls.Add(this.TBApellido2);
            this.Controls.Add(this.TBCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCedula;
        private System.Windows.Forms.TextBox TBApellido2;
        private System.Windows.Forms.TextBox TBApellido1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBResidencia;
        private System.Windows.Forms.Button BTNEnviar;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidop1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button BTNCargar;
    }
}

