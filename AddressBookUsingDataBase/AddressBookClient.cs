using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class AddressBookClient
    {
        private readonly CreateContactDeatils _CreateContactDeatils;
        private readonly CreateAddressBook _CreateAddressBook;
        private readonly AddData _addData;
        private readonly FetchData _fetchData;
        private readonly UpdateDetails _updateDetails;
        private readonly DeleteDetails _deleteDetails;
        public AddressBookClient(CreateContactDeatils createContactDeatils, CreateAddressBook createAddressBook, AddData addData, FetchData fetchData, UpdateDetails updateDetails, DeleteDetails deleteDetails)
        {
            _CreateContactDeatils = createContactDeatils;
            _CreateAddressBook = createAddressBook;
            _addData = addData;
            _fetchData = fetchData;
            _updateDetails = updateDetails;
            _deleteDetails = deleteDetails;
        }

        public void Run()
        {
            //_CreateAddressBook.CreateTables("AddressBooks");
            //_CreateContactDeatils.CreateTables("ContactDetails");

            //// Add address books
            //_addData.AddAddressBook("Personal"); 
            //_addData.AddAddressBook("Work");

            //// Add contacts
            //var contact1 = new SingleContact("John Doe", "john@example.com", "1234567890", "New York", "NY", "10001" );
            //var contact2 = new SingleContact("Jane Smith", "jane@example.com", "9876543210", "Los Angeles", "CA", "90001" );
            //_addData.AddContact(contact1 , 1);
            // _addData.AddContact(contact2,1);

            // Display address books and contacts
            Console.WriteLine("Address Books:");
            //_fetchData.DisplayAddressBooks();

            // update details 
            //_updateDetails.UpdateContacts("name", "saikat", "John Doe");

            _fetchData.DisplayAddressBooks();
            //_deleteDetails.DeleteContacts("Jane Smith");
            // _fetchData.DisplayAddressBooks();
            //Console.WriteLine("\nContacts:");
            //_fetchData.DisplayContacts();
        }
    }
}
