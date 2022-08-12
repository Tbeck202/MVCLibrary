using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if(context.Book.Any())
                {
                    return;
                }
                context.AddRange(
                    new Book { Title = "Lord of the Rings: Fellowship of the Ring", CallNumber = "LOR 123" },
                    new Book { Title = "Fight Club", CallNumber = "FIG 123" },
                    new Book { Title = "Learning C#", CallNumber = "LEA 123" }
                    );
                context.SaveChanges();
            }
        }
    }
}

