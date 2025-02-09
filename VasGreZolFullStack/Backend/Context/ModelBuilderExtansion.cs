using Microsoft.EntityFrameworkCore;
using VasGreZolFullStack.Common.Models;

namespace VasGreZolFullStack.Backend.Context
{
    public static class ModelBuilderExtansion
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Ford",
                    Name = "Mustang",
                    YearOut = 1967,
                    PowerLe = 322,
                    EngineSize = 3185
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Ford",
                    Name = "Mustang GT",
                    YearOut = 2018,
                    PowerLe = 480,
                    EngineSize = 5492
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Ford",
                    Name = "Gt",
                    YearOut = 2000,
                    PowerLe = 550,
                    EngineSize = 4825
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Alfa Romao",
                    Name = "Giulia Quadrifoglio",
                    YearOut = 2024,
                    PowerLe = 388,
                    EngineSize = 2810
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Honda",
                    Name = "Civic Type R",
                    YearOut = 2006,
                    PowerLe = 263,
                    EngineSize = 2125
                }
            };
            modelBuilder.Entity<Car>().HasData(cars);
        }
    }
}
