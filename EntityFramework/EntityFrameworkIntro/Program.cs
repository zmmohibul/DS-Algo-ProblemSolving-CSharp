using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var factory = new CookbookContextFactory();
using var context = factory.CreateDbContext(args);

Console.WriteLine("Add Porridge for breakfast");
var porridge = new Dish {Title = "Breakfast Porridge", Notes = "This is really good.", Stars = 4};
context.Dishes.Add(porridge);
await context.SaveChangesAsync();
Console.WriteLine($"Added Porridge (id = {porridge.Id}) successfully");

System.Console.WriteLine("Checking stars for Porridge");
var dishes = await context.Dishes
                .Where(d => d.Title.Contains("Porridge"))
                .ToListAsync();
if (dishes.Count != 1) System.Console.WriteLine("No Porridge found.......");
System.Console.WriteLine($"Porridge has {dishes[0].Stars} stars.");

Console.WriteLine("Change Porridge stars to 5");
porridge.Stars = 5;
await context.SaveChangesAsync();
System.Console.WriteLine("Changed Porridge stars to 5");

Console.WriteLine("Removing porridge from database");
context.Dishes.Remove(porridge);
await context.SaveChangesAsync();
Console.WriteLine("Porridge removed");

class Dish
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Notes { get; set; }
    
    public int? Stars { get; set; }

    public List<DishIngredient> Ingredients { get; set; } = new();
}

class DishIngredient
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;

    [MaxLength(50)]
    public string UnitOfMeasure { get; set; } = string.Empty;
    
    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }

    public int DishId { get; set; }

    public Dish? Dish { get; set; }
}


class CookbookContext : DbContext
{
    // DbSet represents a table in the database
    // it works an entry point for adding, updating, and query data in Dishes table
    public DbSet<Dish> Dishes { get; set; }

    public DbSet<DishIngredient> Ingredients { get; set; }
    
    public CookbookContext(DbContextOptions<CookbookContext> options) : base(options){ }
}

class CookbookContextFactory : IDesignTimeDbContextFactory<CookbookContext>
{
    public CookbookContext CreateDbContext(string[]? args = null)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<CookbookContext>();
        optionsBuilder
            // Uncomment the following line if you want to print generated
            // SQL statements on the console.
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        return new CookbookContext(optionsBuilder.Options);
    }
}