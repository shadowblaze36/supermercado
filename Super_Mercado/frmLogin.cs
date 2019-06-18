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
    public partial class frmLogin : Form
    {
        public static string _cargo = "";
        public static string _usuario = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = ("select *from usuario where usua_id = '" + txtUsuario.Text + "' and usua_contra ='" + txtContrasena.Text + "'  ");

                MySqlDataReader leer = codigo.ExecuteReader();
                
                if (leer.Read())
                {
                    _usuario = leer.GetString(0);
                    var frmMenu = new frmMenu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no validos");
                }

                conectar.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Supermercado;Uid=root;pwd=Sasuke36");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;

            codigo.CommandText = ("select usua_cargo from usuario where usua_id = '" + txtUsuario.Text + "' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    lbCargox.Text = leer.GetString(0);
                    _cargo = leer.GetString(0);
                }
            }
            else
            {
                lbCargox.Text = "";
            }
            conectar.Close();

        }
    }
}
