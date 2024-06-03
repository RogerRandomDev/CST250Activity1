using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Maker
{
    public class SuperHeroList
    {
        public static List<SuperHero> listOfHeroes { get; set; }

        static SuperHeroList()
        {
            listOfHeroes = new List<SuperHero>();
        }
    }
}
