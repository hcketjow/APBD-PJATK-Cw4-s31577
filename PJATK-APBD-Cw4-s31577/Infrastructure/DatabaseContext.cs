using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s31577.Models;

namespace PJATK_APBD_Cw4_s31577.Infrastructure;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<ComponentManifacturers>  ComponentManifacturers { get; set; }
    public DbSet<ComponentTypes>  ComponentTypes { get; set; }
    public DbSet<Components> Components { get; set; }
    public DbSet<PCComponents> PCComponents { get; set; }
    public DbSet<PCs> PCs { get; set; }
}
