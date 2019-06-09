using Microsoft.EntityFrameworkCore;

namespace AnimalCateringProject.Models
{
    public class DishContext : DbContext
    {
        public DishContext(DbContextOptions<DishContext> options)
            : base(options)
        {
        }

        public DbSet<OrderedDish> OrderedDish { get; set; }
        public DbSet<Dish> Dish { get; set; }
    }
}
