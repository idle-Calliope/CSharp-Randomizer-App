using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerApp
{
    internal class RandomizerClass
    {
        Random rd = new Random();
        string[] wrds = { "Pizza", "Lasagna", "Noodles","Burger","Sandwhich"};
        
        public string randomizer()
        {
            return wrds[rd.Next(0,wrds.Length)];
        }
    }
}
