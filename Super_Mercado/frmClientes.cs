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
    public partial class frmClientes : Form
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
            string sqlSelectAll = "SELECT * from cliente";
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
            txtApellido.Clear();
            txtPuntos.Clear();
            filldgv();
        }

        public void modovisible()
        {
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtPuntos.Enabled = true;
            txtId.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Visible = true;
        }

        public void modonovisible()
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtPuntos.Enabled = false;
            txtId.Enabled = false;
            btAceptar.Visible = false;
            btCancelar.Visible = false;
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (agregarclick == false)
            {
                txtId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtPuntos.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            }
                
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
                    string sqlSelectAll = "SELECT * from cliente where ID=" + Convert.ToInt32(txtBuscar.Text);
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            agregarclick = false;
            modovisible();
            agregar = false;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el cliente " + txtNombre.Text + "?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("DELETE FROM cliente WHERE ID = '" + txtId.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();
                MessageBox.Show("Usuario " + txtNombre.Text + " eliminado con exito");
                filldgv();
            }
            else if (dialogResult == DialogResult.No)
            {
                filldgv();
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select *from cliente where ID = '" + txtId.Text + "'");

                MySqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Error, el cliente con ID " + txtId.Text + " ya existe, intente con otro ID");
                }
                else
                {
                    MySqlConnection conectar2 = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar2.Open();
                    MySqlCommand codigo2 = new MySqlCommand();
                    codigo2.Connection = conectar2;
                    codigo2.CommandText = ("insert into cliente values(" + txtId.Text + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', "+ txtPuntos.Text +");");
                    MySqlDataReader leer2 = codigo2.ExecuteReader();

                    MessageBox.Show("Cliente agregado con exito");
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

                codigo.CommandText = ("update cliente set ID=" + txtId.Text + ", Nombre ='" + txtNombre.Text + "', Apellido ='" + txtApellido.Text + "', Puntos= " + txtPuntos.Text + " where ID='" + txtId.Text + "'");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();

                MessageBox.Show("Cliente modificado con exito");
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

        private void btVolver_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}
