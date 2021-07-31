using Modul3HW2.Models;
using Modul3HW2.Providers.Abstractions;

namespace Modul3HW2.Providers
{
    public class ContactProvider : IContactProvider
    {
        public ContactProvider()
        {
            Contacts = GetContacts();
        }

        public Contact[] Contacts { get; set; }

        private Contact[] GetContacts()
        {
            var contacts = new Contact[]
            {
                new Contact()
                {
                    FirstName = "qwe",
                    LustName = "rty",
                    Phone = "12345"
                },
                new Contact()
                {
                    FirstName = "rty",
                    LustName = "fgh",
                    Phone = "55432"
                },
                new Contact()
                {
                    FirstName = "йцу",
                    LustName = "фыв",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "ячу",
                    LustName = "про",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "123",
                    LustName = "456",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "2чу",
                    LustName = "4ро",
                    Phone = "73841"
                }
            };

            GetFullName(contacts);
            return contacts;
        }

        private void GetFullName(Contact[] contacts)
        {
            foreach (var item in contacts)
            {
                item.FullName = $"{item.FirstName} {item.LustName}";
            }
        }
    }
}
