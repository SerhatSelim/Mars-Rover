using MarsRover.Business.Behavior;
using MarsRover.Model.Concrete;
using MarsRover.Model.Enum;

namespace MarsRover.Business.Concrete
{
    public class RoverBusiness : IRoverBusiness
    {
        public bool IsMoveAvailable(RoverDto rover) => rover.Plateau.MinWidth <= rover.Coorditane.X && rover.Coorditane.X <= rover.Plateau.Width && rover.Plateau.MinHeight <= rover.Coorditane.Y && rover.Coorditane.Y <= rover.Plateau.Height;

        public string Movement(RoverDto rover, string command)
        {

            if (this.IsMoveAvailable(rover))
            {

                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i].ToString() == "L")
                    {
                        rover.DirectionType = ((int)rover.DirectionType - 1) < (int)DirectionType.N ? DirectionType.W : (DirectionType)((int)rover.DirectionType - 1);
                    }
                    else if (command[i].ToString() == "R")
                    {
                        rover.DirectionType = ((int)rover.DirectionType + 1) > (int)DirectionType.W ? DirectionType.N : (DirectionType)((int)rover.DirectionType + 1);
                    }
                    else if (command[i].ToString() == "M")
                    {
                        switch (rover.DirectionType)
                        {
                            case DirectionType.N:
                                rover.Coorditane.Y += 1;
                                break;
                            case DirectionType.E:
                                rover.Coorditane.X += 1;
                                break;
                            case DirectionType.S:
                                rover.Coorditane.Y -= 1;
                                break;
                            case DirectionType.W:
                                rover.Coorditane.X -= 1;
                                break;
                        }
                    }
                }

                return rover.Coorditane.X + " " + rover.Coorditane.Y + " " + rover.DirectionType; ;

            }
            else
            {
                return "Move dose not available!";
            }

        }


    }
}
