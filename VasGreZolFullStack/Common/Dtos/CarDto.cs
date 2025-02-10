namespace VasGreZolFullStack.Common.Dtos
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int YearOut { get; set; }
        public int PowerLe { get; set; }
        public int EngineSize { get; set; }
        public string Color { get; set; }

        public CarDto(Guid id, string brand, string name, int year, int powerLe, int engineSize, string color)
        {
            Id = id;
            Brand = brand;
            Name = name;
            YearOut = year;
            PowerLe = powerLe;
            EngineSize = engineSize;
            Color = color;
        }
        public CarDto()
        {
            Id = Guid.NewGuid();
            Brand = string.Empty;
            Name = string.Empty;
            YearOut = 0;
            PowerLe = 0;
            EngineSize = 0;
            Color = string.Empty;
        }
    }
}
