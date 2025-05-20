using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data;

public class CatalogContextSeed
{
    public static void SeedData(IMongoCollection<Product> productCollection)
    {
        bool existProduct = productCollection.Find(p => true).Any();
        if (!existProduct)
        {
            productCollection.InsertManyAsync(GetMyProducts());
        }
    }

    private static IEnumerable<Product> GetMyProducts()
    {
        return new List<Product>()
        {
            new Product()
            {
                Id = "602d2149e773f2a3990b47f5",
                Name = "Iphone X",
                Description = "Lorem ipsum dolor sit amet. Ea eaque voluptatum sit dolorem ratione sit vitae velit et corrupti rerum et esse iusto. Est molestias perferendis est temporibus aspernatur qui galisum facilis ea doloribus omnis id labore voluptatem qui cumque excepturi.",
                Image = "product1.png",
                Price = 950.00M,
                Category = "Smartphone"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47f6",
                Name = "Samsung Galaxy S21",
                Description = "A high-end smartphone with a sleek design, powerful performance, and advanced camera features.",
                Image = "product2.png",
                Price = 850.00M,
                Category = "Smartphone"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47f7",
                Name = "MacBook Pro 16",
                Description = "A powerful laptop designed for professionals, featuring a stunning Retina display and M1 chip.",
                Image = "product3.png",
                Price = 2500.00M,
                Category = "Laptop"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47f8",
                Name = "Sony WH-1000XM4",
                Description = "Industry-leading noise-canceling headphones with exceptional sound quality and comfort.",
                Image = "product4.png",
                Price = 350.00M,
                Category = "Headphones"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47f9",
                Name = "Apple Watch Series 7",
                Description = "A smartwatch with advanced health tracking features and a larger, more durable display.",
                Image = "product5.png",
                Price = 400.00M,
                Category = "Wearable"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47fa",
                Name = "Dell XPS 13",
                Description = "An ultra-portable laptop with a stunning InfinityEdge display and excellent performance.",
                Image = "product6.png",
                Price = 1200.00M,
                Category = "Laptop"
            }
        };
    }
}
