using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public class ConnectionModel
    {

        public MySqlConnection Con;
        public MySqlDataAdapter Da { get; set; }
        public DataTable Dt { get; set; }
        public MySqlCommand Query { get; set; }

        public ConnectionModel()
        {
            Con = new MySqlConnection("server=localhost;database=latihan_pos;Uid=root;Pwd=");
            Dt = new DataTable();
        }
    }
}
