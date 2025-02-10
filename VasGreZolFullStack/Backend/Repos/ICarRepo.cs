using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Backend.Repos.Base;

namespace VasGreZolFullStack.Backend.Repos
{
    public interface ICarRepo : IBaseRepo<Car>
    {
        public Task<Car> GetCarByNameAsync(string brand, string name);
        public Task<List<Car>> GetCarByColorAsync(string color);
        Task<int> GetNumberOfColorAsync(string color);
        Task<int> GetNumberOfBrandAsync(string brand);
        Task<int> GetNumberOfCarsAsync();
    }
}
