using MarsRover.Business.Concrete;
using MarsRover.Model.Concrete;
using MarsRover.Model.Enum;
using System;

namespace MarsRover.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var plateau = new PlateauDto();
            plateau.MinHeight = 0;
            plateau.MinWidth = 0;
            plateau.Width= 5;
            plateau.Height = 5;

            var operatingRover1 = new RoverDto()
            {
                Coorditane = new CoorditaneDto
                {
                    X = 1,
                    Y = 2,
                },
                DirectionType = DirectionType.N,
                Plateau = plateau
            };

            var operatingRover2 = new RoverDto()
            {
                Coorditane = new CoorditaneDto
                {
                    X = 3,
                    Y = 3,
                },
                DirectionType = DirectionType.E,
                Plateau = plateau
            };

            var roverBusiness = new RoverBusiness();
            var response1 = roverBusiness.Movement(operatingRover1, "LMLMLMLMM");
            var response2 = roverBusiness.Movement(operatingRover2, "MMRMMRMRRM");

            Console.WriteLine("OUTPUT:");
            Console.WriteLine(response1);
            Console.WriteLine(response2);

        }
    }
}
