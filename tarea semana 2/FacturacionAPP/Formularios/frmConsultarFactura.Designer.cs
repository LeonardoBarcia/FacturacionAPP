namespace FacturacionAPP.Formularios
{
    partial class frmConsultaFactura
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
            this.gbfiltros = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechahasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblfechadesde = new System.Windows.Forms.Label();
            this.dgvConsultaFactura = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClinete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbfiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfiltros
            // 
            this.gbfiltros.Controls.Add(this.btnAceptar);
            this.gbfiltros.Controls.Add(this.txtCliente);
            this.gbfiltros.Controls.Add(this.lblCliente);
            this.gbfiltros.Controls.Add(this.dtpFechaHasta);
            this.gbfiltros.Controls.Add(this.lblFechahasta);
            this.gbfiltros.Controls.Add(this.dtpFechaDesde);
            this.gbfiltros.Controls.Add(this.lblfechadesde);
            this.gbfiltros.Location = new System.Drawing.Point(13, 13);
            this.gbfiltros.Name = "gbfiltros";
            this.gbfiltros.Size = new System.Drawing.Size(775, 132);
            this.gbfiltros.TabIndex = 0;
            this.gbfiltros.TabStop = false;
            this.gbfiltros.Text = "Filtros";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(662, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Buscar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(148, 94);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(333, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(103, 99);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(479, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 3;
            // 
            // lblFechahasta
            // 
            this.lblFechahasta.AutoSize = true;
            this.lblFechahasta.Location = new System.Drawing.Point(405, 25);
            this.lblFechahasta.Name = "lblFechahasta";
            this.lblFechahasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechahasta.TabIndex = 2;
            this.lblFechahasta.Text = "Fecha Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(148, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // lblfechadesde
            // 
            this.lblfechadesde.AutoSize = true;
            this.lblfechadesde.Location = new System.Drawing.Point(71, 25);
            this.lblfechadesde.Name = "lblfechadesde";
            this.lblfechadesde.Size = new System.Drawing.Size(71, 13);
            this.lblfechadesde.TabIndex = 0;
            this.lblfechadesde.Text = "Fecha Desde";
            // 
            // dgvConsultaFactura
            // 
            this.dgvConsultaFactura.AllowUserToAddRows = false;
            this.dgvConsultaFactura.AllowUserToDeleteRows = false;
            this.dgvConsultaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.Colfecha,
            this.ColClinete,
            this.ColTotal,
            this.ColAcciones});
            this.dgvConsultaFactura.Location = new System.Drawing.Point(13, 151);
            this.dgvConsultaFactura.Name = "dgvConsultaFactura";
            this.dgvConsultaFactura.ReadOnly = true;
            this.dgvConsultaFactura.Size = new System.Drawing.Size(775, 234);
            this.dgvConsultaFactura.TabIndex = 1;
            this.dgvConsultaFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaFactura_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 33);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(123, 405);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(84, 33);
            this.btnborrar.TabIndex = 8;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Factura Numero";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // Colfecha
            // 
            this.Colfecha.HeaderText = "Fecha";
            this.Colfecha.Name = "Colfecha";
            this.Colfecha.ReadOnly = true;
            this.Colfecha.Width = 150;
            // 
            // ColClinete
            // 
            this.ColClinete.HeaderText = "Cliente";
            this.ColClinete.Name = "ColClinete";
            this.ColClinete.ReadOnly = true;
            this.ColClinete.Width = 250;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 130;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Ver Detalles";
            this.ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // frmConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvConsultaFactura);
            this.Controls.Add(this.gbfiltros);
            this.Name = "frmConsultaFactura";
            this.Text = "Consulta Factura";
            this.Load += new System.EventHandler(this.frmConsultaFactura_Load);
            this.gbfiltros.ResumeLayout(false);
            this.gbfiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfiltros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechahasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblfechadesde;
        private System.Windows.Forms.DataGridView dgvConsultaFactura;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClinete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}