using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "protective",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer ball",
                        Description = "FIFA approved ball",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner flags",
                        Description = "Marking a pitch",
                        Category = "Soccer",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Thinking cap",
                        Description = "3Better for your brian",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Gaming chair",
                        Description = "A chair for the player",
                        Category = "Chess",
                        Price = 28.95m
                    },
                    new Product
                    {
                        Name = "Human chess board",
                        Description = "A board for chess",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Chess notebook",
                        Description = "A note book for chess notes with boards schemas",
                        Category = "Chess",
                        Price = 9.99m
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
