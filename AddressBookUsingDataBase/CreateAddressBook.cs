using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class CreateAddressBook : MakeTable
    {
        private readonly Connection _connection;

        public CreateAddressBook(Connection connection)
        {
            _connection = connection;
        }

        public void CreateTables(string tableName)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                string query = $"CREATE TABLE  {tableName} (id INT PRIMARY KEY IDENTITY(1,1), name VARCHAR(100));";
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
