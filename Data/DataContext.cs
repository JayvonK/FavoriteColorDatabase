using FavoriteColorDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace FavoriteColorDatabase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<FavoriteColor> Color { get; set; } 
    }
