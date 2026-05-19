using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Copilot suggested enabling memory caching
builder.Services.AddMemoryCache();

// Copilot helped configure CORS to allow communication
// between the Blazor front-end and Minimal API back-end.
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.MapGet("/api/productlist", (IMemoryCache cache) =>
{
    // Copilot suggested caching API responses
    // to reduce redundant processing and improve performance.

    const string cacheKey = "productList";

    if (!cache.TryGetValue(cacheKey, out object? products))
    {
        products = new[]
        {
            new
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25,
                Category = new
                {
                    Id = 101,
                    Name = "Electronics"
                }
            },
            new
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00,
                Stock = 100,
                Category = new
                {
                    Id = 102,
                    Name = "Accessories"
                }
            }
        };

        var cacheOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

        cache.Set(cacheKey, products, cacheOptions);
    }

    return products;
});

app.Run();