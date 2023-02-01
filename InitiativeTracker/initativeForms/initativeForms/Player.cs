using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initativeForms
{
    public class Player
    {
        public int Initiative { get; set; }
        public string Name { get; set; }
        public Player(string name, int initiative) 
        { 
            Initiative = initiative;
            Name = name;
        }

    }
}
