using MarsRover.Model.Enum;

namespace MarsRover.Model.Concrete
{
    public class RoverDto
    {
        public CoorditaneDto Coorditane { get; set; }

        public PlateauDto Plateau { get; set; }

        public DirectionType DirectionType { get; set; }
    }
}
