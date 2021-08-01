using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Modul3HW2.Models;
using Modul3HW2.Providers;
using Modul3HW2.Providers.Abstractions;

namespace Modul3HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .AddTransient<IContactProvider, ContactProvider>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
