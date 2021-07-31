using System;
using Modul3HW2.Providers.Abstractions;

namespace Modul3HW2
{
    public class Starter
    {
        private IContactProvider _contacts;
        public Starter(IContactProvider contactProvider)
        {
            _contacts = contactProvider;
        }

        public void Run()
        {
            foreach (var item in _contacts.Contacts)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
