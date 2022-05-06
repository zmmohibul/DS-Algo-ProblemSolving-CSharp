using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var factory = new BrickContextFactory();
using var context = factory.CreateDbContext(args);

await AddData();

#region Adding data with relations
async Task AddData()
{
    Vendor brickKing, bunteSteine, heldDerSteine, brickHeaven;
    await context.AddRangeAsync(new[]
    {
        brickKing = new Vendor { VendorName = "Brick King" },
        bunteSteine = new Vendor { VendorName = "Bunte Steine" },
        heldDerSteine = new Vendor { VendorName = "Held der Steine" },
        brickHeaven = new Vendor { VendorName = "Brick Heaven" },
    });
    await context.SaveChangesAsync();

    Tag rare, ninjago, minecraft;
    await context.AddRangeAsync(new[]
    {
    rare = new Tag { Title = "Rare" },
    ninjago = new Tag { Title = "Ninjago" },
    minecraft = new Tag { Title = "Mincraft" },
});
    await context.SaveChangesAsync();

    await context.AddAsync(new BasePlate
    {
        Title = "Baseplate 16 x 16 with Island on Blue Water Pattern",
        Color = Color.Green,
        Tags = new() { rare, minecraft },
        Length = 16,
        Width = 16,
        BrickAvailability = new List<BrickAvailability>
    {
       new() { Vendor = bunteSteine, AvailableAmount = 5, Price = 6.6m },
       new() { Vendor = heldDerSteine, AvailableAmount = 10, Price = 5.9m },
    }
    });
    await context.AddAsync(new Brick
    {
        Title = "Brick 1 x 2 x 1",
        Color = Color.Orange
    });
    await context.AddAsync(new MinifigHead
    {
        Title = "Minifigure, Head Dual Sided Black Eyebrows, Wide Open Mouth / Lopsided Grin",
        Color = Color.Yellow
    });
    await context.SaveChangesAsync();
}
#endregion

#region Model
enum Color
{
    Black,
    White,
    Yellow,
    Orange,
    Green,
    Red
}

class Brick
{
    public int Id { get; set; }

    public Color? Color { get; set; }

    [MaxLength(250)]
    public string? Title { get; set; } = string.Empty;

    public List<Tag> Tags { get; set; } = new();
    
    public List<BrickAvailability> BrickAvailability { get; set; } = new();
}

class BasePlate : Brick
{
    public int Length { get; set; }
    public int Width { get; set; }
}

class MinifigHead : Brick
{
    public bool IsDualSided { get; set; }
}

class Tag
{
    public int Id { get; set; }
    
    [MaxLength(250)]
    public string? Title { get; set; } = string.Empty;
    
    public List<Brick> Bricks { get; set; } = new();
}

class Vendor
{
    public int Id { get; set; }

    [MaxLength(250)]
    public string? VendorName { get; set; } = string.Empty;

    public List<BrickAvailability> BrickAvailability { get; set; } = new();
}

class BrickAvailability
{
    public int Id { get; set; }

    public int VendorId { get; set; }

    public Vendor? Vendor { get; set; }

    public int BrickId { get; set; }

    public Brick? Brick { get; set; }

    public int AvailableAmount { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }
}
#endregion

#region Data Context
class BrickContext : DbContext
{
    public BrickContext(DbContextOptions<BrickContext> options) : base(options){ }

    public DbSet<Brick> Bricks { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<BrickAvailability> BrickAvailability { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasePlate>().HasBaseType<Brick>();
        modelBuilder.Entity<MinifigHead>().HasBaseType<Brick>();
        base.OnModelCreating(modelBuilder);
    }
}

class BrickContextFactory : IDesignTimeDbContextFactory<BrickContext>
{
    public BrickContext CreateDbContext(string[]? args = null)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<BrickContext>();
        optionsBuilder
            // Uncomment the following line if you want to print generated
            // SQL statements on the console.
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        return new BrickContext(optionsBuilder.Options);
    }
}
#endregion