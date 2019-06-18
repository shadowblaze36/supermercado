namespace Super_Mercado
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btProductos = new System.Windows.Forms.Button();
            this.btProveedores = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btEmpleados = new System.Windows.Forms.Button();
            this.btFacturas = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbUsuarioActual = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbUsuarioActualx = new System.Windows.Forms.Label();
            this.lbCargox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btProductos
            // 
            this.btProductos.Image = ((System.Drawing.Image)(resources.GetObject("btProductos.Image")));
            this.btProductos.Location = new System.Drawing.Point(115, 12);
            this.btProductos.Name = "btProductos";
            this.btProductos.Size = new System.Drawing.Size(97, 103);
            this.btProductos.TabIndex = 19;
            this.btProductos.Text = "Productos";
            this.btProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btProductos.UseVisualStyleBackColor = true;
            this.btProductos.Click += new System.EventHandler(this.btProductos_Click);
            // 
            // btProveedores
            // 
            this.btProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btProveedores.Image")));
            this.btProveedores.Location = new System.Drawing.Point(12, 121);
            this.btProveedores.Name = "btProveedores";
            this.btProveedores.Size = new System.Drawing.Size(97, 103);
            this.btProveedores.TabIndex = 18;
            this.btProveedores.Text = "Proveedores";
            this.btProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btProveedores.UseVisualStyleBackColor = true;
            this.btProveedores.Click += new System.EventHandler(this.btProveedores_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btUsuarios.Image")));
            this.btUsuarios.Location = new System.Drawing.Point(218, 12);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(97, 103);
            this.btUsuarios.TabIndex = 16;
            this.btUsuarios.Text = "Usuarios";
            this.btUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btClientes
            // 
            this.btClientes.Image = ((System.Drawing.Image)(resources.GetObject("btClientes.Image")));
            this.btClientes.Location = new System.Drawing.Point(218, 121);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(97, 103);
            this.btClientes.TabIndex = 13;
            this.btClientes.Text = "Clientes";
            this.btClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btEmpleados
            // 
            this.btEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btEmpleados.Image")));
            this.btEmpleados.Location = new System.Drawing.Point(115, 121);
            this.btEmpleados.Name = "btEmpleados";
            this.btEmpleados.Size = new System.Drawing.Size(97, 103);
            this.btEmpleados.TabIndex = 12;
            this.btEmpleados.Text = "Empleados";
            this.btEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmpleados.UseVisualStyleBackColor = true;
            this.btEmpleados.Click += new System.EventHandler(this.btEmpleados_Click);
            // 
            // btFacturas
            // 
            this.btFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btFacturas.Image")));
            this.btFacturas.Location = new System.Drawing.Point(12, 12);
            this.btFacturas.Name = "btFacturas";
            this.btFacturas.Size = new System.Drawing.Size(97, 103);
            this.btFacturas.TabIndex = 10;
            this.btFacturas.Text = "Facturas";
            this.btFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFacturas.UseVisualStyleBackColor = true;
            this.btFacturas.Click += new System.EventHandler(this.btFacturas_Click);
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(321, 12);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(97, 103);
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "Salir";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbUsuarioActual
            // 
            this.lbUsuarioActual.AutoSize = true;
            this.lbUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioActual.Location = new System.Drawing.Point(325, 121);
            this.lbUsuarioActual.Name = "lbUsuarioActual";
            this.lbUsuarioActual.Size = new System.Drawing.Size(93, 13);
            this.lbUsuarioActual.TabIndex = 21;
            this.lbUsuarioActual.Text = "Usuario actual:";
            this.lbUsuarioActual.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.Location = new System.Drawing.Point(325, 167);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(44, 13);
            this.lbCargo.TabIndex = 22;
            this.lbCargo.Text = "Cargo:";
            // 
            // lbUsuarioActualx
            // 
            this.lbUsuarioActualx.AutoSize = true;
            this.lbUsuarioActualx.Location = new System.Drawing.Point(328, 134);
            this.lbUsuarioActualx.Name = "lbUsuarioActualx";
            this.lbUsuarioActualx.Size = new System.Drawing.Size(0, 13);
            this.lbUsuarioActualx.TabIndex = 23;
            // 
            // lbCargox
            // 
            this.lbCargox.AutoSize = true;
            this.lbCargox.Location = new System.Drawing.Point(328, 180);
            this.lbCargox.Name = "lbCargox";
            this.lbCargox.Size = new System.Drawing.Size(0, 13);
            this.lbCargox.TabIndex = 24;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 235);
            this.Controls.Add(this.lbCargox);
            this.Controls.Add(this.lbUsuarioActualx);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbUsuarioActual);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btProductos);
            this.Controls.Add(this.btProveedores);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.btEmpleados);
            this.Controls.Add(this.btFacturas);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProductos;
        private System.Windows.Forms.Button btProveedores;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btEmpleados;
        private System.Windows.Forms.Button btFacturas;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbUsuarioActual;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbUsuarioActualx;
        private System.Windows.Forms.Label lbCargox;
    }
}