using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class FetchData
    {
        private readonly Connection _connection;

        public FetchData(Connection connection)
        {
            _connection = connection;
        }

        public void DisplayAddressBooks()
        {
            using (var connection = _connection.Connect())
            {
                connection.Open();
                string query = @"SELECT a.name AS AddressBookName, c.id AS ContactId, c.name AS ContactName, c.email, c.phone, c.city, c.state, c.zip FROM AddressBooks a inner JOIN ContactDetails c ON a.id = c.AddressBookId;";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"AddressBookName: {reader["AddressBookName"]}");
                            Console.WriteLine($"\tContactId: {reader["ContactId"]}, \n\tName: {reader["ContactName"]}, \n\tEmail: {reader["email"]}, \n\tPhone: {reader["phone"]}, \n\tCity: {reader["city"]}, \n\tState: {reader["state"]}, \n\tZip: {reader["zip"]}");

                        }
                    }
                }

            }
        }
    }
    }
