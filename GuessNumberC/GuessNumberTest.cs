using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberC
{
    class GuessNumberTest
    {
        static void Main(string[] args)
        {
            String answer = null;
            Random random = new Random();

            do
            {
                Console.Write("Player one - write you name: ");
                Player playerOne = new Player(Console.ReadLine());

                Console.Write("Player two - write you name: ");
                Player playerTwo = new Player(Console.ReadLine());

                int computerNumber = random.Next(100);

                GuessNumber guessNum = new GuessNumber(playerOne, playerTwo, computerNumber);

                guessNum.startGame();

                do
                {
                    Console.WriteLine("Do you want to continue? [Yes/No]");
                    answer = Console.ReadLine();
                    if (answer != "Yes" && answer != "No")
                    {
                        Console.WriteLine("Answer should be only Yes or No!");
                    }
                } while (answer != "Yes" && answer != "No");
            } while (answer == "Yes");
        }
    }
}
