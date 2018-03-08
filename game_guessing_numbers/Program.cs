using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_guessing_numbers
{
    class Program
    {
        static int _winNumber;

        static void Main(string[] args)
        {
            var random = new Random();
            _winNumber = random.Next(0, 100);

            string command = string.Empty;
            string gameResult = string.Empty;
            while (command != "end")
            {
                int inputNumber;
                command = Console.ReadLine();
                if (int.TryParse(command, out inputNumber))
                {
                    if (inputNumber == _winNumber)
                    {
                        gameResult = "win";
                        break;
                    }
                    else if (inputNumber > _winNumber)
                    {
                        Console.WriteLine("Podana liczba jest za duza.");
                    }
                    else if (inputNumber < _winNumber)
                    {
                        Console.WriteLine("Podana liczba jest za mala.");
                    }
                }
            }

            if (gameResult == "win")
            {
                Console.WriteLine("Gratulajce wygrałeś!");
                Console.WriteLine(
                    string.Format("To była liczba {0}", _winNumber));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Przykro mi przegrałeś.");
                Console.ReadLine();
            }
        }
    }
}
