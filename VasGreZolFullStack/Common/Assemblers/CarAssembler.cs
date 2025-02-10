using VasGreZolFullStack.Common.Assemblers.Base;
using VasGreZolFullStack.Common.Dtos;
using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Common.Transforms;

namespace VasGreZolFullStack.Common.Assemblers
{
    public class CarAssembler : BaseAssembler<Car, CarDto>
    {
        public override CarDto ToDto(Car domainEntity)
        {
            return domainEntity.ToCarDto();
        }
        public override Car ToModel(CarDto dto)
        {
            return dto.ToCar();
        }
    }
}
