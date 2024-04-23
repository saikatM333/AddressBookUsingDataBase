using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class DeleteDetails
    {
        private readonly Connection _connection;

        public DeleteDetails(Connection connection)
        {
            _connection = connection;
        }

        public void DeleteContacts(string name)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                string UpdateQuery = $"delete ContactDetails where name  = '{name}' ;";
                SqlCommand sqlCommand = new SqlCommand(UpdateQuery, connection);
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("deleted susscessfully ");
            }
        }
    
}
}
