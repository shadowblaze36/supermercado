using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Super_Mercado
{
    public partial class frmMenu : Form
    {
        public string _cargo = "";
        public string _usuario = "";
        

        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            _cargo = frmLogin._cargo;
            _usuario = frmLogin._usuario;
            if (_cargo=="Administrador")
            {
                btClientes.Enabled = true;
                btEmpleados.Enabled = true;
                btFacturas.Enabled = true;
                btProductos.Enabled = true;
                btProveedores.Enabled = true;
                btUsuarios.Enabled = true;
            }
            else if (_cargo == "Cajero")
            {
                btClientes.Enabled = true;
                btEmpleados.Enabled = true;
                btFacturas.Enabled = true;
                btProductos.Enabled = true;
                btProveedores.Enabled = true;
                btUsuarios.Enabled = false;
            }
            else if (_cargo == "Empleado")
            {
                btClientes.Enabled = true;
                btEmpleados.Enabled = true;
                btFacturas.Enabled = false;
                btProductos.Enabled = true;
                btProveedores.Enabled = true;
                btUsuarios.Enabled = false;
            }
            lbCargox.Text = _cargo;
            lbUsuarioActualx.Text = _usuario;

        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
            this.Hide();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.Show();
            this.Hide();
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            var frmProductos = new frmProductos();
            frmProductos.Show();
            this.Hide();
        }

        private void btFacturas_Click(object sender, EventArgs e)
        {
            var frmFacturas = new frmFacturas();
            frmFacturas.Show();
            this.Hide();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            var frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
            this.Hide();
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            var frmProveedores = new frmProveedores();
            frmProveedores.Show();
            this.Hide();
        }
    }
}
