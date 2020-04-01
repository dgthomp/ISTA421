using System.Collections.Generic;
using System.Linq;
namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> 
        {
            new Product { Name = "Football", Description ="Inflatable Leather", Price = 25 },
            new Product { Name = "Surf board",Description = " Ride Waves", Price = 179 },
            new Product { Name = "Running shoes",Description = "Size 11 tires for my feet", Price = 95 }
        }.AsQueryable<Product>();
    }
}