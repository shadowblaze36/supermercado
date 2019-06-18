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
    public partial class frmUsuarios : Form
    {
        public bool agregar = true;

        
        public void loadlist()
        {
            lboxUsuarios.Items.Clear();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select *from usuario");
            MySqlDataReader leer = codigo.ExecuteReader();
            
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    lboxUsuarios.Items.Add(leer.GetString(0));
                }
            }

            conectar.Close();
        }

        public void clear()
        {
            txtContrasena.Clear();
            txtCargo.Clear();
            txtUsuario.Clear();
            txtBuscar.Clear();
            loadlist();
        }

        public void modovisible()
        {
            btAceptar.Visible = true;
            btCancelar.Visible = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtContrasena.Visible = true;
            txtCargo.Enabled = true;
            lbContrasena.Visible = true;
        }
        public void modonovisible()
        {
            btAceptar.Visible = false;
            btCancelar.Visible = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtContrasena.Visible = false;
            txtCargo.Enabled = false;
            lbContrasena.Visible = false;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void lboxUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboxUsuarios.SelectedItem.ToString()!=null)
            {
                txtUsuario.Text = lboxUsuarios.SelectedItem.ToString();
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select * from usuario where usua_id = '" + txtUsuario.Text + "' ");
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        txtCargo.Text = leer.GetString(2);
                        txtContrasena.Text = leer.GetString(1);
                    }
                }
                else
                {
                    txtCargo.Text = "";
                    txtContrasena.Text = "";
                }
                conectar.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            lboxUsuarios.Items.Clear();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("select *from usuario where usua_id like '"+txtBuscar.Text+"%'");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    lboxUsuarios.Items.Add(leer.GetString(0));
                }
            }

            conectar.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            clear();
            agregar = true;
            modovisible();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            agregar = false;
            modovisible();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select *from usuario where usua_id = '" + txtUsuario.Text + "'");

                MySqlDataReader leer = codigo.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Error, el usuario "+txtUsuario.Text+" ya existe, intente con otro usuario");
                }
                else
                {
                    MySqlConnection conectar2 = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar2.Open();
                    MySqlCommand codigo2 = new MySqlCommand();
                    codigo2.Connection = conectar2;
                    codigo2.CommandText = ("insert into usuario values('" + txtUsuario.Text + "', '" + txtContrasena.Text + "', '" + txtCargo.Text + "');");
                    MySqlDataReader leer2 = codigo2.ExecuteReader();

                    MessageBox.Show("Usuario agregado con exito");
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

                codigo.CommandText = ("update usuario set usua_id='" + txtUsuario.Text + "', usua_contra ='" + txtContrasena.Text + "', usua_cargo ='" + txtCargo.Text + "' where usua_id='" + txtUsuario.Text + "'");
                MySqlDataReader leer = codigo.ExecuteReader();
                conectar.Close();

                MessageBox.Show("Usuario modificado con exito");
                modonovisible();
            }
            loadlist();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            modonovisible();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (lboxUsuarios.SelectedItem!=null)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el usuario " + lboxUsuarios.SelectedItem.ToString() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    codigo.Connection = conectar;

                    codigo.CommandText = ("DELETE FROM usuario WHERE usua_id = '" + lboxUsuarios.SelectedItem.ToString() + "' ");
                    MySqlDataReader leer = codigo.ExecuteReader();
                    conectar.Close();
                    MessageBox.Show("Usuario " + lboxUsuarios.SelectedItem.ToString() + " eliminado con exito");
                    loadlist();
                }
                else if (dialogResult == DialogResult.No)
                {
                    loadlist();
                }
            }

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();

        }
    }
}
