
namespace VasGreZolFullStack.Common.Models
{
    public class Car : IDbEntity<Car>
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int YearOut { get; set; }
        public int PowerLe {  get; set; }
        public int EngineSize { get; set; }
        public bool HasId => Id != Guid.Empty;
        public override string ToString()
        {
            return $"{Id} {Brand} {Name} ({YearOut}) / {EngineSize}ccm, {PowerLe}Hp";
        }
    }
}
