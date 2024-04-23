using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class UpdateDetails
    {
        private readonly Connection _connection;

        public UpdateDetails(Connection connection)
        {
            _connection = connection;
        }

        public void UpdateContacts(string ColumnName, string value, string name)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                string UpdateQuery = $"update ContactDetails set {ColumnName} = '{value}' where name = '{name}' ;";
                SqlCommand sqlCommand = new SqlCommand(UpdateQuery, connection);
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("updated susscessfully ");
            }
        }
    }
}
