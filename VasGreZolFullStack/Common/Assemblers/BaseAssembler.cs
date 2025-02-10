namespace VasGreZolFullStack.Common.Assemblers
{
    public abstract class BaseAssembler<TModel, TDto>
    {
        public abstract TModel ToModel(TDto dto);
        public abstract TDto ToDto(TModel domainEntity);
    }
}
