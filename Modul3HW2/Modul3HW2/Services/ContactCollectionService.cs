using System.Collections.Generic;
using Modul3HW2.Models;

namespace Modul3HW2.Services
{
    public class ContactCollectionService
    {
        public void Add(Contact contact)
        {
            var contacts = new List<KeyValuePair<string, Contact>>();
            contacts.Add(new KeyValuePair<string, Contact>(contact.FirstName[0].ToString(), contact));
        }
    }
}
