using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Backend.Context;
using VasGreZolFullStack.Backend.Repos.Base;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace VasGreZolFullStack.Backend.Repos
{
    public class CarRepo<TDbContext> : BaseRepo<TDbContext, Car>, ICarRepo where TDbContext : FullStackContext
    {
        public CarRepo(TDbContext? dbContext) : base(dbContext) { }

        public async Task<List<Car>> GetCarByColorAsync(string color)
        {
            return await _dbSet!.FindByCondition<Car>(c => c.Color == color).ToListAsync();
        }

        public async Task<Car> GetCarByNameAsync(string brand, string name)
        {
            return await _dbSet!.FindByCondition<Car>(c => c.Brand == brand && c.Name == name).FirstOrDefaultAsync() ?? new Car();
        }

        public async Task<int> GetNumberOfBrandAsync(string brand)
        {
            return await _dbSet.CountAsync(c => c.Brand == brand);
        }

        public async Task<int> GetNumberOfCarsAsync()
        {
            return await _dbSet.CountAsync();
        }

        public async Task<int> GetNumberOfColorAsync(string color)
        {
            return await _dbSet.CountAsync(c => c.Color == color);
        }
    }
}
