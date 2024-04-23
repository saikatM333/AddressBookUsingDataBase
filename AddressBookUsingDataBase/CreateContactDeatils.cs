using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class CreateContactDeatils : MakeTable
    {
        private readonly Connection _connection;

        public CreateContactDeatils(Connection connection)
        {
            _connection = connection;
        }

        public void CreateTables(string tableName)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                //name, email, phone, city, state, zip , AddressBookId
                string query = $"CREATE TABLE {tableName} (id INT PRIMARY KEY IDENTITY(1,1), name VARCHAR(100), email VARCHAR(30), phone VARCHAR(20), city VARCHAR(20), state VARCHAR(20), zip VARCHAR(20), AddressBookId INT, FOREIGN KEY (AddressBookId) REFERENCES AddressBooks(id));";
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
