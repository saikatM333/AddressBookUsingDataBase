using AddressBookUsingDataBase;

public  class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Address Book");

        string connectionString = "server=(localdb)\\MSSQLLOCALDB; Initial Catalog = addressBook; Integrated Security = SSPI";
        Connection connection = new Connection(connectionString);

        CreateContactDeatils createContactDeatils = new CreateContactDeatils(connection);
        CreateAddressBook createAddressBook = new CreateAddressBook(connection);
        AddData addData = new AddData(connection);
        FetchData fetchData = new FetchData(connection);
        UpdateDetails updateDetails = new UpdateDetails(connection);
        DeleteDetails deleteDetails = new DeleteDetails(connection);

        AddressBookClient client = new AddressBookClient(createContactDeatils, createAddressBook, addData, fetchData, updateDetails, deleteDetails);
        client.Run(); Console.WriteLine("Hello, World!");
    }
}