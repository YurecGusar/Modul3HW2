using Modul3HW2.Models.Abstractions;

namespace Modul3HW2.Models
{
    public class Contact : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
    }
}
