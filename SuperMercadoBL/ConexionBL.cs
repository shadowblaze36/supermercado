using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SuperMercadoBL
{
    public class ConexionBL
    {
        MySqlConnection _con;

        string str = "Server=localhost;Database=supermercado;Uid=root;Pwd=Sasuke36";

        public ConexionBL()
        {
            _con = new MySqlConnection(str);
            _con.Open();
        }

    }

}
