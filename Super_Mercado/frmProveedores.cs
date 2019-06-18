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
    public partial class frmProveedores : Form
    {
        public bool agregar = true;
        public bool agregarclick = false;
        public void filldgv()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from proveedor";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvClientes.DataSource = bSource;
        }

        public void clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            filldgv();
        }

        public void modovisible()
        {
            txtNombre.Enabled = true;
            txtId.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Visible = true;
        }

        public void modonovisible()
        {
            txtNombre.Enabled = false;
            txtId.Enabled = false;
            btAceptar.Visible = false;
            btCancelar.Visible = false;
        }
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (agregarclick == false)
            {
                txtId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    dgvClientes.DataSource = null;
                    MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    codigo.Connection = conectar;

                    MySqlDataAdapter MyDA = new MySqlDataAdapter();
                    string sqlSelectAll = "SELECT * from proveedor where ID=" + Convert.ToInt32(txtBuscar.Text);
                    MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

                    DataTable table = new DataTable();
                    MyDA.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;

                    dgvClientes.DataSource = bSource;
                }
                else
                {
                    dgvClientes.DataSource = null;
                    filldgv();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            modovisible();
            clear();
            agregar = true;
            agregarclick = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el proveedor " + txtNombre.Text + "?", "Eliminar Proveedor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("DELETE FROM proveedor WHERE ID = '" + txtId.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();
                MessageBox.Show("Proveedor " + txtNombre.Text + " eliminado con exito");
                filldgv();
            }
            else if (dialogResult == DialogResult.No)
            {
                filldgv();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            agregarclick = false;
            modovisible();
            agregar = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select *from proveedor where ID = '" + txtId.Text + "'");

                MySqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Error, el proveedor con ID " + txtId.Text + " ya existe, intente con otro ID");
                }
                else
                {
                    MySqlConnection conectar2 = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar2.Open();
                    MySqlCommand codigo2 = new MySqlCommand();
                    codigo2.Connection = conectar2;
                    codigo2.CommandText = ("insert into proveedor values(" + txtId.Text + ", '" + txtNombre.Text + "');");
                    MySqlDataReader leer2 = codigo2.ExecuteReader();

                    MessageBox.Show("Proveedor agregado con exito");
                    modonovisible();
                    clear();
                }

                conectar.Close();
            }
            else if (!agregar)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("update proveedor set ID=" + txtId.Text + ", Nombre ='" + txtNombre.Text + "' where ID='" + txtId.Text + "'");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();

                MessageBox.Show("Proveedor modificado con exito");
                modonovisible();
            }
            filldgv();
            agregarclick = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            modonovisible();
            agregarclick = false;
        }
    }
}
