using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDataBase
{
    public class SingleContact : IContacts
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        public SingleContact(string name, string email, string phone, string city, string state, string zip)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
    }
}
