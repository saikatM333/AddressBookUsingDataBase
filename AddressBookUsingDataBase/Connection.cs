using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class Connection
    {
        private readonly string _connectionString;
        public Connection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection Connect()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
