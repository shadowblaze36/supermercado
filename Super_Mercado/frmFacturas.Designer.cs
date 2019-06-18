namespace Super_Mercado
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.lbIDFactura = new System.Windows.Forms.Label();
            this.txtIDFactura = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btMas = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtIDCLiente = new System.Windows.Forms.TextBox();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbISV = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbSubtotalx = new System.Windows.Forms.Label();
            this.lbISVx = new System.Windows.Forms.Label();
            this.lbTotalx = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btAgregarx = new System.Windows.Forms.Button();
            this.btEliminarx = new System.Windows.Forms.Button();
            this.btCancelarx = new System.Windows.Forms.Button();
            this.lbUsuariox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIDFactura
            // 
            this.lbIDFactura.AutoSize = true;
            this.lbIDFactura.Location = new System.Drawing.Point(52, 15);
            this.lbIDFactura.Name = "lbIDFactura";
            this.lbIDFactura.Size = new System.Drawing.Size(60, 13);
            this.lbIDFactura.TabIndex = 0;
            this.lbIDFactura.Text = "ID Factura:";
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.Enabled = false;
            this.txtIDFactura.Location = new System.Drawing.Point(115, 12);
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.Size = new System.Drawing.Size(52, 20);
            this.txtIDFactura.TabIndex = 1;
            this.txtIDFactura.TextChanged += new System.EventHandler(this.txtIDFactura_TextChanged);
            // 
            // btVolver
            // 
            this.btVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btVolver.Image = ((System.Drawing.Image)(resources.GetObject("btVolver.Image")));
            this.btVolver.Location = new System.Drawing.Point(12, 416);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(32, 32);
            this.btVolver.TabIndex = 50;
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Enabled = false;
            this.dgvDetalle.Location = new System.Drawing.Point(18, 129);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(266, 179);
            this.dgvDetalle.TabIndex = 49;
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.Location = new System.Drawing.Point(44, 19);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(32, 32);
            this.btEliminar.TabIndex = 45;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Enabled = false;
            this.btAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btAgregar.Image")));
            this.btAgregar.Location = new System.Drawing.Point(6, 19);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(32, 32);
            this.btAgregar.TabIndex = 44;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(41, 81);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 51;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(55, 97);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(19, 20);
            this.txtCantidad.TabIndex = 52;
            this.txtCantidad.Text = "1";
            this.txtCantidad.Visible = false;
            // 
            // btMas
            // 
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMas.Location = new System.Drawing.Point(80, 97);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(20, 20);
            this.btMas.TabIndex = 53;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Visible = false;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btMenos
            // 
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.Location = new System.Drawing.Point(29, 97);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(20, 20);
            this.btMenos.TabIndex = 54;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Visible = false;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(6, 57);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(108, 21);
            this.cbProducto.TabIndex = 55;
            this.cbProducto.Visible = false;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btCancelar);
            this.gbDetalle.Controls.Add(this.btAgregar);
            this.gbDetalle.Controls.Add(this.btAceptar);
            this.gbDetalle.Controls.Add(this.cbProducto);
            this.gbDetalle.Controls.Add(this.btEliminar);
            this.gbDetalle.Controls.Add(this.btMenos);
            this.gbDetalle.Controls.Add(this.lbCantidad);
            this.gbDetalle.Controls.Add(this.btMas);
            this.gbDetalle.Controls.Add(this.txtCantidad);
            this.gbDetalle.Location = new System.Drawing.Point(290, 129);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(140, 179);
            this.gbDetalle.TabIndex = 56;
            this.gbDetalle.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(6, 123);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(61, 23);
            this.btCancelar.TabIndex = 58;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(73, 123);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(61, 23);
            this.btAceptar.TabIndex = 57;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Visible = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtIDCLiente
            // 
            this.txtIDCLiente.Enabled = false;
            this.txtIDCLiente.Location = new System.Drawing.Point(234, 58);
            this.txtIDCLiente.Name = "txtIDCLiente";
            this.txtIDCLiente.Size = new System.Drawing.Size(52, 20);
            this.txtIDCLiente.TabIndex = 58;
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Location = new System.Drawing.Point(171, 61);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(56, 13);
            this.lbIDCliente.TabIndex = 57;
            this.lbIDCliente.Text = "ID Cliente:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(234, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 62;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(181, 87);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 61;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(15, 113);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(43, 13);
            this.lbDetalle.TabIndex = 63;
            this.lbDetalle.Text = "Detalle:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(12, 86);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 64;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(168, 324);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(53, 13);
            this.lbSubtotal.TabIndex = 66;
            this.lbSubtotal.Text = "SubTotal:";
            // 
            // lbISV
            // 
            this.lbISV.AutoSize = true;
            this.lbISV.Location = new System.Drawing.Point(194, 351);
            this.lbISV.Name = "lbISV";
            this.lbISV.Size = new System.Drawing.Size(27, 13);
            this.lbISV.TabIndex = 67;
            this.lbISV.Text = "ISV:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(181, 381);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 13);
            this.lbTotal.TabIndex = 68;
            this.lbTotal.Text = "Total:";
            // 
            // lbSubtotalx
            // 
            this.lbSubtotalx.AutoSize = true;
            this.lbSubtotalx.Location = new System.Drawing.Point(256, 324);
            this.lbSubtotalx.Name = "lbSubtotalx";
            this.lbSubtotalx.Size = new System.Drawing.Size(28, 13);
            this.lbSubtotalx.TabIndex = 69;
            this.lbSubtotalx.Text = "0.00";
            this.lbSubtotalx.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbISVx
            // 
            this.lbISVx.AutoSize = true;
            this.lbISVx.Location = new System.Drawing.Point(256, 351);
            this.lbISVx.Name = "lbISVx";
            this.lbISVx.Size = new System.Drawing.Size(28, 13);
            this.lbISVx.TabIndex = 70;
            this.lbISVx.Text = "0.00";
            // 
            // lbTotalx
            // 
            this.lbTotalx.AutoSize = true;
            this.lbTotalx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalx.Location = new System.Drawing.Point(256, 381);
            this.lbTotalx.Name = "lbTotalx";
            this.lbTotalx.Size = new System.Drawing.Size(32, 13);
            this.lbTotalx.TabIndex = 71;
            this.lbTotalx.Text = "0.00";
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(213, 425);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 72;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btAtras
            // 
            this.btAtras.Image = ((System.Drawing.Image)(resources.GetObject("btAtras.Image")));
            this.btAtras.Location = new System.Drawing.Point(12, 12);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(32, 32);
            this.btAtras.TabIndex = 73;
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 74;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAgregarx
            // 
            this.btAgregarx.Image = ((System.Drawing.Image)(resources.GetObject("btAgregarx.Image")));
            this.btAgregarx.Location = new System.Drawing.Point(209, 12);
            this.btAgregarx.Name = "btAgregarx";
            this.btAgregarx.Size = new System.Drawing.Size(32, 32);
            this.btAgregarx.TabIndex = 75;
            this.btAgregarx.UseVisualStyleBackColor = true;
            this.btAgregarx.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEliminarx
            // 
            this.btEliminarx.Image = ((System.Drawing.Image)(resources.GetObject("btEliminarx.Image")));
            this.btEliminarx.Location = new System.Drawing.Point(247, 12);
            this.btEliminarx.Name = "btEliminarx";
            this.btEliminarx.Size = new System.Drawing.Size(32, 32);
            this.btEliminarx.TabIndex = 76;
            this.btEliminarx.UseVisualStyleBackColor = true;
            this.btEliminarx.Click += new System.EventHandler(this.btEliminarx_Click);
            // 
            // btCancelarx
            // 
            this.btCancelarx.Location = new System.Drawing.Point(132, 425);
            this.btCancelarx.Name = "btCancelarx";
            this.btCancelarx.Size = new System.Drawing.Size(75, 23);
            this.btCancelarx.TabIndex = 77;
            this.btCancelarx.Text = "Cancelar";
            this.btCancelarx.UseVisualStyleBackColor = true;
            this.btCancelarx.Click += new System.EventHandler(this.btCancelarx_Click);
            // 
            // lbUsuariox
            // 
            this.lbUsuariox.AutoSize = true;
            this.lbUsuariox.Location = new System.Drawing.Point(64, 86);
            this.lbUsuariox.Name = "lbUsuariox";
            this.lbUsuariox.Size = new System.Drawing.Size(0, 13);
            this.lbUsuariox.TabIndex = 78;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 460);
            this.Controls.Add(this.lbUsuariox);
            this.Controls.Add(this.btCancelarx);
            this.Controls.Add(this.btEliminarx);
            this.Controls.Add(this.btAgregarx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.lbTotalx);
            this.Controls.Add(this.lbISVx);
            this.Controls.Add(this.lbSubtotalx);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbISV);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtIDCLiente);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtIDFactura);
            this.Controls.Add(this.lbIDFactura);
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDFactura;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtIDCLiente;
        private System.Windows.Forms.Label lbIDCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbISV;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbSubtotalx;
        private System.Windows.Forms.Label lbISVx;
        private System.Windows.Forms.Label lbTotalx;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAgregarx;
        private System.Windows.Forms.Button btEliminarx;
        private System.Windows.Forms.Button btCancelarx;
        private System.Windows.Forms.Label lbUsuariox;
    }
}