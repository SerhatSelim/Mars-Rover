using MarsRover.Model.Concrete;

namespace MarsRover.Business.Behavior
{
    interface IRoverBusiness
    {
        string Movement(RoverDto rover, string command);

        bool IsMoveAvailable(RoverDto rover);
    }
}
