using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s31577.Models;

namespace PJATK_APBD_Cw4_s31577;

public class DatabaseContext : DbContext
{
    public DbSet<PCs> PCs { get; set; }
    public DbSet<Components> Components { get; set; }
    public DbSet<ComponentTypes> ComponentTypes { get; set; }
    public DbSet<ComponentManifacturers> ComponentManifacturers { get; set; }
    public DbSet<PCComponents> PCComponents { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ComponentTypes>().HasData(
            new ComponentTypes { Id = 1, Abbreviation = "CPU", Name = "Procesor" },
            new ComponentTypes { Id = 2, Abbreviation = "GPU", Name = "Karta graficzna" },
            new ComponentTypes { Id = 3, Abbreviation = "RAM", Name = "Pamięć operacyjna" }
        );

        modelBuilder.Entity<ComponentManifacturers>().HasData(
            new ComponentManifacturers
            {
                Id = 1,
                Abbreviation = "INTC",
                FullName = "Intel Corporation",
                FoundationDate = new DateTime(1968, 7, 18)
            },
            new ComponentManifacturers
            {
                Id = 2,
                Abbreviation = "AMD",
                FullName = "Advanced Micro Devices",
                FoundationDate = new DateTime(1969, 5, 1)
            },
            new ComponentManifacturers
            {
                Id = 3,
                Abbreviation = "NV",
                FullName = "NVIDIA Corporation",
                FoundationDate = new DateTime(1993, 4, 5)
            }
        );

        modelBuilder.Entity<Components>().HasData(
            new Components
            {
                Code = "CPU0000001",
                Name = "Intel Core i7-13700K",
                Description = "Procesor 16-rdzeniowy, taktowanie do 5.4 GHz",
                ComponentManufacturersId = 1,
                ComponentTypesId = 1
            },
            new Components
            {
                Code = "CPU0000002",
                Name = "AMD Ryzen 7 7800X3D",
                Description = "Procesor 8-rdzeniowy z pamięcią 3D V-Cache",
                ComponentManufacturersId = 2,
                ComponentTypesId = 1
            },
            new Components
            {
                Code = "GPU0000001",
                Name = "NVIDIA GeForce RTX 4070",
                Description = "Karta graficzna 12 GB GDDR6X",
                ComponentManufacturersId = 3,
                ComponentTypesId = 2
            }
        );

        modelBuilder.Entity<PCs>().HasData(
            new PCs
            {
                Id = 1,
                Name = "Gamer Pro X",
                Weight = 12.5f,
                Warranty = 24,
                CreatedAt = new DateTime(2024, 1, 15),
                Stock = 10
            },
            new PCs
            {
                Id = 2,
                Name = "Office Basic",
                Weight = 8.2f,
                Warranty = 12,
                CreatedAt = new DateTime(2024, 3, 20),
                Stock = 25
            }
        );

        modelBuilder.Entity<PCComponents>().HasData(
            new PCComponents { PCId = 1, ComponentCode = "CPU0000001", Amount = 1 },
            new PCComponents { PCId = 1, ComponentCode = "GPU0000001", Amount = 1 },
            new PCComponents { PCId = 2, ComponentCode = "CPU0000002", Amount = 1 }
        );
    }
}
