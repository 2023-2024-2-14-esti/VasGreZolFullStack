using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Backend.Repos.Base;

namespace VasGreZolFullStack.Backend.Repos
{
    public interface ICarRepo : IBaseRepo<Car>
    {
        public Task<Car> GetCarByName(string brand, string name);
        public Task<List<Car>> GetCarByColor(string brand, string name, string color);
        Task<int> GetNumberOfColorAsync();
        Task<int> GetNumberOfBrandAsync();
        Task<int> GetNumberOfCarsAsync();
    }
}
