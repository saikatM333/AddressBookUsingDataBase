using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class AddData
    {
        private readonly Connection _connection;

        public AddData(Connection connection)
        {
            _connection = connection;
        }

        public void AddAddressBook(string name)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();

                string query = $"INSERT INTO AddressBooks (name) VALUES (@Name);";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddContact(SingleContact contact, int addressBookId)
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                string query = @"INSERT INTO ContactDetails (name, email, phone, city, state, zip , AddressBookId) 
                            VALUES (@Name, @Email, @Phone, @City, @State, @Zip , @AddressBookId);";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", contact.name);
                    command.Parameters.AddWithValue("@Email", contact.email);
                    command.Parameters.AddWithValue("@Phone", contact.phone);
                    command.Parameters.AddWithValue("@City", contact.city);
                    command.Parameters.AddWithValue("@State", contact.state);
                    command.Parameters.AddWithValue("@Zip", contact.zip);
                    command.Parameters.AddWithValue("@AddressBookId", addressBookId);
                    command.ExecuteNonQuery();
                    Console.WriteLine("inserted susscessfully ");
                }
            }
        }
    }
}
