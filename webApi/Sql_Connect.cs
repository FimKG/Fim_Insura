using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySqlConnector;

namespace Fim_Insura.webApi
{

    
    class Sql_Connect
    {
        public MySqlConnection connect;

        string server = "";
        string root = "";
        string username = "";
        string password = "";
        string database = "";
        string conn = "myServerAddress; Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
    }
}
