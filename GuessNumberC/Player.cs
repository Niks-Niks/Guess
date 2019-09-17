using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberC
{
    class Player
    {
        private String name;
        private int number;
        
        public Player(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }
    }
}
