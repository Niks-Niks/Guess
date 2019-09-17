using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberC
{
    class GuessNumber
    {
        private Player firstPlayer;
        private Player secondPlayer;
        private int computerNumber;
        private bool isWin;
        private int round = 1;

        public GuessNumber(Player playerOne, Player playerTwo, int computeNumber)
        {
            firstPlayer = playerOne;
            secondPlayer = playerTwo;
            this.computerNumber = computeNumber;
        }

        public void startGame()
        {
            
            Console.WriteLine(computerNumber);
            do
            {
                Console.WriteLine($"{round} round!");

                if (round == 10)
                {
                    Console.WriteLine("This is last round!");
                }

                inputNumber(firstPlayer);
                isWin = checkNumber(firstPlayer);
                if (isWin == false)
                {
                    inputNumber(secondPlayer);
                    isWin = checkNumber(secondPlayer);
                }
                

                
                round++;
            } while (isWin != true &&  round != 11);
        }

        private void inputNumber(Player player)
        {
            Console.Write($"{player.getName()} write you number:");
            player.setNumber(Convert.ToInt32(Console.ReadLine()));
        }

        private bool checkNumber(Player player)
        {
            if (player.getNumber() > computerNumber)
            {
                Console.WriteLine($"{player.getName()} you number must be less.");
            } else if (player.getNumber() < computerNumber)
            {
                Console.WriteLine($"{player.getName()} you number must be greater.");
            } else
            {
                Console.WriteLine($"Congratulation! {player.getName()} win!!!");
                return true;
            }
            return false;
        }
    }
}
