using VasGreZolFullStack.Common.Dtos;
using VasGreZolFullStack.Common.Models;

namespace VasGreZolFullStack.Common.Transforms
{
    public static class CarTransform
    {
        public static Dtos.CarDto ToCarDto(this Car car)
        {
            return new Dtos.CarDto
            {
                Id = car.Id,
                Brand = car.Brand,
                Name = car.Name,
                YearOut = car.YearOut,
                PowerLe = car.PowerLe,
                EngineSize = car.EngineSize,
                Color = car.Color
            };
        }
        public static Models.Car ToCar(this CarDto carDto)
        {
            return new Models.Car
            {
                Id = carDto.Id,
                Brand = carDto.Brand,
                Name = carDto.Name,
                YearOut = carDto.YearOut,
                PowerLe = carDto.PowerLe,
                EngineSize = carDto.EngineSize,
                Color = carDto.Color
            };
        }
    }
}
