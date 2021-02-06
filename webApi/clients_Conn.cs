using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Data.Entity;
//using MySqlConnector;

namespace Fim_Insura.webApi
{

    
    class clients_Conn : DbContext
    {
        //public MySqlConnection connect;

        //string server = "";
        //string root = "";
        //string username = "";
        //string password = "";
        //string database = "";
        //string conn = "myServerAddress; Database=myDataBase;Uid=myUsername;Pwd=myPassword;";


        public DbSet<ClientsTB> Clients { get; set; }
    }
}
