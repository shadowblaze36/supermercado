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
    public partial class frmFacturas : Form
    {
        public string _usuario = "";
        public int cantidad = 1;
        public double subtotal;
        public double total;
        public double isv;
        public int ID;
        public int maxID;
        public bool addactivo;

        public void filldgv()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT detalle.ID, producto.Descripcion, producto.Precio FROM detalle,producto WHERE detalle.ID = producto.ID AND detalle.fact_id ="+txtIDFactura.Text;
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvDetalle.DataSource = bSource;
            calculartotales();
        }

        public void xFecha()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select fact_fecha from factura where fact_id=" + txtIDFactura.Text);
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    dateTimePicker1.Value = leer.GetDateTime(0);
                }
            }
            conectar.Close();
        }

        public void xUsuario()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select usua_id from factura where fact_id=" + txtIDFactura.Text);
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    lbUsuariox.Text = leer.GetString(0);
                }
            }
            conectar.Close();
        }

        public void xNombreCLiente()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select Nombre from cliente where ID=" + txtIDCLiente.Text);
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    txtNombre.Text = leer.GetString(0);
                }
            }
            conectar.Close();
        }

        public void xIdCLiente()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select clie_id from factura where fact_id="+txtIDFactura.Text);
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    txtIDCLiente.Text = leer.GetString(0);
                }
            }
            conectar.Close();
        }

        public void llenartextboxs()
        {
            xIdCLiente();
            xNombreCLiente();
            xFecha();
            xUsuario();
            filldgv();
            calculartotales();
        }

        public void modoenabled()
        {
            txtIDCLiente.Enabled = true;
            txtNombre.Enabled = true;
            btAgregar.Enabled = true;
            btEliminar.Enabled = true;
        }

        public void mododisabled()
        {
            txtIDCLiente.Enabled = false;
            txtNombre.Enabled = false;
            btAgregar.Enabled = false;
            btEliminar.Enabled = false;
        }

        public void calculartotales()
        {
            subtotal = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["Precio"].Value != null)
                    subtotal += (Int32)row.Cells["Precio"].Value;
            }
            isv = subtotal * 0.15;
            total = subtotal + isv;
            lbISVx.Text = isv.ToString();
            lbSubtotalx.Text = subtotal.ToString();
            lbTotalx.Text = total.ToString();
            
        }

        public void idMayor()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select max(fact_id) from factura");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    maxID = Convert.ToInt32(leer.GetString(0));
                }
            }
            conectar.Close();
        }

        public void fullclear()
        {
            dateTimePicker1.Value = System.DateTime.Now;
            txtIDFactura.Text = maxID.ToString();
            dgvDetalle.DataSource = null;
            txtIDCLiente.Clear();
            txtNombre.Clear();
            lbSubtotalx.Text = "";
            lbTotalx.Text = "";
            lbISVx.Text = "";
            lbUsuariox.Text = _usuario;
        }

        public void productovisible()
        {
            btMas.Visible = true;
            btMenos.Visible = true;
            txtCantidad.Visible = true;
            btCancelar.Visible = true;
            lbCantidad.Visible = true;
            btAceptar.Visible = true;
            cbProducto.Visible = true;
        }
        public void productonovisible()
        {
            btMas.Visible = false;
            btMenos.Visible = false;
            txtCantidad.Visible = false;
            btCancelar.Visible = false;
            lbCantidad.Visible = false;
            btAceptar.Visible = false;
            cbProducto.Visible = false;
        }

        public void fillProductos()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36"))
            {
                string query = "SELECT ID, Descripcion from Producto";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                cbProducto.ValueMember = "ID";
                cbProducto.DisplayMember = "Descripcion";
                cbProducto.DataSource = dt;
            }
        }

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            idMayor();
            ID = 1;
            txtIDFactura.Text = ID.ToString();
            fillProductos();
            _usuario = frmLogin._usuario;
            lbUsuariox.Text = _usuario;
            llenartextboxs();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string producto = cbProducto.SelectedValue.ToString();
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            for (int i = 0; i < cantidad; i++)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;
                string fecha = dateTimePicker1.Value.ToShortDateString();
                codigo.CommandText = ("insert into detalle values(" + txtIDFactura.Text + ", " + producto +");");
                MySqlDataReader leer = codigo.ExecuteReader();

            }

            filldgv();
            productonovisible();
            cantidad = 1;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            productonovisible();
            cantidad = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modoenabled();
            fullclear();
            addactivo = true;
            maxID++;
            txtIDFactura.Text = maxID.ToString();
            btAgregarx.Enabled = false;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            productovisible();
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            cantidad++;
            txtCantidad.Text = cantidad.ToString();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            if(cantidad==1)
            {

            }
            else
            {
                cantidad--;
            }
            txtCantidad.Text = cantidad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maxID==ID)
            {

            }
            else
            {
                ID++;
            }
            txtIDFactura.Text = ID.ToString();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            if (ID == 1)
            {

            }
            else
            {
                ID--;
            }
            txtIDFactura.Text = ID.ToString();
        }

        private void btCancelarx_Click(object sender, EventArgs e)
        {
            if(addactivo)
            {
                maxID--;
            }
            mododisabled();
            addactivo = false;
            productonovisible();
            cantidad = 1;
            btAgregarx.Enabled = true;
            txtIDFactura.Text = maxID.ToString();

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void txtIDFactura_TextChanged(object sender, EventArgs e)
        {
            if (!addactivo)
            {
                llenartextboxs();
            }
            
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            string fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            codigo.CommandText = ("insert into factura values(" + txtIDFactura.Text + ", " + txtIDCLiente.Text + ",'" + lbUsuariox.Text + "', '" + fecha + "'," + lbSubtotalx.Text + "," + lbTotalx.Text + "," + lbISVx.Text + ");");
            MySqlDataReader leer = codigo.ExecuteReader();
            MessageBox.Show("Factura generada con exito");
            addactivo = false;
            mododisabled();
            btAgregarx.Enabled = true;
            idMayor();
        }

        private void btEliminarx_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la factura " + txtIDFactura.Text + "?", "Eliminar Factura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("DELETE FROM factura WHERE fact_id = " + txtIDFactura.Text + " ; DELETE FROM detalle where fact_id = " + txtIDFactura.Text);
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();
                MessageBox.Show("Factura " + txtIDFactura.Text + " eliminada con exito");
                filldgv();
            }
            else if (dialogResult == DialogResult.No)
            {
                filldgv();
            }
            idMayor();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
