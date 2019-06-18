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
    public partial class frmProductos : Form
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
            string sqlSelectAll = "SELECT * from producto";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvProductos.DataSource = bSource;
        }

        public void clear()
        {
            txtId.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            filldgv();
        }

        public void modovisible()
        {
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtId.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Visible = true;
        }

        public void modonovisible()
        {
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtId.Enabled = false;
            btAceptar.Visible = false;
            btCancelar.Visible = false;
        }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void lbPuntos_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "")
                {
                    dgvProductos.DataSource = null;
                    MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    codigo.Connection = conectar;

                    MySqlDataAdapter MyDA = new MySqlDataAdapter();
                    string sqlSelectAll = "SELECT * from producto where ID=" + Convert.ToInt32(txtBuscar.Text);
                    MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

                    DataTable table = new DataTable();
                    MyDA.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;

                    dgvProductos.DataSource = bSource;
                }
                else
                {
                    dgvProductos.DataSource = null;
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
            agregarclick = true;
            modovisible();
            clear();
            agregar = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el producto " + txtDescripcion.Text + "?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("DELETE FROM producto WHERE ID = '" + txtId.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();
                MessageBox.Show("Producto " + txtDescripcion.Text + " eliminado con exito");
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            modonovisible();
            agregarclick = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select *from producto where ID = '" + txtId.Text + "'");

                MySqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Error, el producto con ID " + txtId.Text + " ya existe, intente con otro ID");
                }
                else
                {
                    MySqlConnection conectar2 = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar2.Open();
                    MySqlCommand codigo2 = new MySqlCommand();
                    codigo2.Connection = conectar2;
                    codigo2.CommandText = ("insert into producto values(" + txtId.Text + ", '" + txtDescripcion.Text + "', " + txtPrecio.Text + ");");
                    MySqlDataReader leer2 = codigo2.ExecuteReader();

                    MessageBox.Show("Producto agregado con exito");
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

                codigo.CommandText = ("update producto set ID=" + txtId.Text + ", Descripcion ='" + txtDescripcion.Text + "', Precio= " + txtPrecio.Text + " where ID='" + txtId.Text + "'");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();

                MessageBox.Show("Producto modificado con exito");
                modonovisible();
            }
            filldgv();
            agregarclick = false;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (agregarclick == false)
            {
                txtId.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
