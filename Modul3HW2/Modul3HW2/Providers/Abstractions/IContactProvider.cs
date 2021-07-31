using Modul3HW2.Models;

namespace Modul3HW2.Providers.Abstractions
{
    public interface IContactProvider
    {
        public Contact[] Contacts { get; set; }
    }
}
