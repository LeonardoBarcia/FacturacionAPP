namespace FacturacionAPP
{
    partial class FrmNuevaFactura
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
            this.lblNrofactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.LblimporteTotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.lblarticulos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrofactura
            // 
            this.lblNrofactura.AutoSize = true;
            this.lblNrofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrofactura.Location = new System.Drawing.Point(13, 13);
            this.lblNrofactura.Name = "lblNrofactura";
            this.lblNrofactura.Size = new System.Drawing.Size(196, 20);
            this.lblNrofactura.TabIndex = 0;
            this.lblNrofactura.Text = "Numero de factura N°:  ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(125, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(178, 45);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(204, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(127, 85);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(83, 13);
            this.lblFormaPago.TabIndex = 3;
            this.lblFormaPago.Text = "Formas de pago";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(214, 82);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(151, 21);
            this.cboFormaPago.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(128, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(214, 117);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(151, 20);
            this.txtcliente.TabIndex = 6;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNomArticulo,
            this.ColPrecioUnitario,
            this.Colcantidad,
            this.ColAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(70, 189);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(654, 177);
            this.dgvDetalles.TabIndex = 7;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColNomArticulo
            // 
            this.ColNomArticulo.HeaderText = "Nombre articulo";
            this.ColNomArticulo.Name = "ColNomArticulo";
            this.ColNomArticulo.ReadOnly = true;
            this.ColNomArticulo.Width = 310;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.HeaderText = "Precio unitario";
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.ReadOnly = true;
            // 
            // Colcantidad
            // 
            this.Colcantidad.HeaderText = "Cantidad";
            this.Colcantidad.Name = "Colcantidad";
            this.Colcantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(465, 154);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad de articulos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(577, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // LblimporteTotal
            // 
            this.LblimporteTotal.AutoSize = true;
            this.LblimporteTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblimporteTotal.Location = new System.Drawing.Point(497, 374);
            this.LblimporteTotal.Name = "LblimporteTotal";
            this.LblimporteTotal.Size = new System.Drawing.Size(93, 19);
            this.LblimporteTotal.TabIndex = 10;
            this.LblimporteTotal.Text = "Importe total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(623, 373);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(670, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(501, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(214, 146);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(245, 21);
            this.cboArticulos.TabIndex = 14;
            // 
            // lblarticulos
            // 
            this.lblarticulos.AutoSize = true;
            this.lblarticulos.Location = new System.Drawing.Point(128, 154);
            this.lblarticulos.Name = "lblarticulos";
            this.lblarticulos.Size = new System.Drawing.Size(47, 13);
            this.lblarticulos.TabIndex = 15;
            this.lblarticulos.Text = "Articulos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(696, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblarticulos);
            this.Controls.Add(this.cboArticulos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.LblimporteTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNrofactura);
            this.Name = "FrmNuevaFactura";
            this.Text = "Facturacion de articulos";
            this.Load += new System.EventHandler(this.FrmNuevaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrofactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label LblimporteTotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.Label lblarticulos;
        private System.Windows.Forms.Button btnAgregar;
    }
}