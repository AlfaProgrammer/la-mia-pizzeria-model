using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Models
{
    public class PizzasContext : DbContext
    {
        public DbSet<PizzaModel> Pizzas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Pizzeria;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaModel>().HasData(
                new PizzaModel { Id = 1, Name = "Margherita", Price = 12, Description = "PizzaFantastica" },
                new PizzaModel { Id = 2, Name = "Diavola", Price = 5, Description = "PizzaFantastica" },
                new PizzaModel { Id = 3, Name = "Funghi", Price = 6, Description = "PizzaFantastica" },
                new PizzaModel { Id = 4, Name = "Tonno", Price = 23, Description = "PizzaFantastica" },
                new PizzaModel { Id = 5, Name = "Melanzane", Price = 4, Description = "PizzaFantastica" },
                new PizzaModel { Id = 6, Name = "Capricciosa", Price = 32, Description = "PizzaFantastica" });
        }
    }

}
