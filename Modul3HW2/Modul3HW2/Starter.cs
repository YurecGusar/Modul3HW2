using System;
using System.Collections;
using System.Collections.Generic;
using Modul3HW2.Collections;
using Modul3HW2.Models;
using Modul3HW2.Providers.Abstractions;
using Modul3HW2.Services;

namespace Modul3HW2
{
    public class Starter
    {
        private IContactProvider _contacts;
        public Starter(
            IContactProvider contactProvider)
        {
            _contacts = contactProvider;
        }

        public void Run()
        {
            /*var contacts = new ContactCollectionService<KeyValuePair<string, Contact>>();*/
            var contacts = new ContactCollection<Contact>();
            foreach (var item in _contacts.Contacts)
            {
                contacts.Add(item);
            }

            var test = contacts.GetByKey("q");

            foreach (var item in test)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
