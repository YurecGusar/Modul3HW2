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
                    LastName = "rty",
                    Phone = "12345"
                },
                new Contact()
                {
                    FirstName = "rty",
                    LastName = "fgh",
                    Phone = "55432"
                },
                new Contact()
                {
                    FirstName = "йцу",
                    LastName = "фыв",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "ячу",
                    LastName = "про",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "123",
                    LastName = "456",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "2чу",
                    LastName = "4ро",
                    Phone = "73841"
                },
                new Contact()
                {
                    FirstName = "qчу",
                    LastName = "4ро",
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
                item.FullName = $"{item.FirstName} {item.LastName}";
            }
        }
    }
}
