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
    public partial class frmEmpleados : Form
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
            string sqlSelectAll = "SELECT * from empleado";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvEmpleados.DataSource = bSource;
        }

        public void clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtBono.Clear();
            txtDescanso.Clear();
            txtComision.Clear();
            txtHorario.Clear();
            filldgv();
        }

        public void modovisible()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtId.Enabled = true;
            txtHorario.Enabled = true;
            txtBono.Enabled = true;
            txtDescanso.Enabled = true;
            txtComision.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Visible = true;
        }

        public void modonovisible()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtId.Enabled = false;
            txtHorario.Enabled = false;
            txtBono.Enabled = false;
            txtDescanso.Enabled = false;
            txtComision.Enabled = false;
            btAceptar.Visible = false;
            btCancelar.Visible = false;
        }
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void txtPuntos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvEmpleados.DataSource = null;
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from empleado where ID=" + Convert.ToInt32(txtBuscar.Text);
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conectar);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dgvEmpleados.DataSource = bSource;
            }
            else
            {
                dgvEmpleados.DataSource = null;
                filldgv();
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
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el empleado " + txtNombre.Text + "?", "Eliminar Empleado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("DELETE FROM empleado WHERE ID = '" + txtId.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();
                MessageBox.Show("Empleado " + txtNombre.Text + " eliminado con exito");
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

                codigo.CommandText = ("select *from empleado where ID = '" + txtId.Text + "'");

                MySqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Error, el empleado con ID " + txtId.Text + " ya existe, intente con otro ID");
                }
                else
                {
                    MySqlConnection conectar2 = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar2.Open();
                    MySqlCommand codigo2 = new MySqlCommand();
                    codigo2.Connection = conectar2;
                    codigo2.CommandText = ("insert into empleado values(" + txtId.Text + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" +txtHorario.Text + "', '"+txtDescanso.Text+"', " +txtComision.Text+", "+txtBono.Text+");");
                    MySqlDataReader leer2 = codigo2.ExecuteReader();

                    MessageBox.Show("Empleado agregado con exito");
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

                codigo.CommandText = ("update empleado set ID=" + txtId.Text + ", Nombre ='" + txtNombre.Text + "', Apellido= '" + txtApellido.Text + "', Horario= '" + txtHorario.Text + "', Descanso= '" + txtDescanso.Text + "', Comision= " + txtComision.Text + ", Bono= " + txtBono.Text + " where ID='" + txtId.Text + "'");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();

                MessageBox.Show("Empleado modificado con exito");
                modonovisible();
            }
            filldgv();
            agregarclick = false;
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtHorario.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtDescanso.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtComision.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtBono.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
