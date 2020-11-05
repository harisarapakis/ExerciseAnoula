using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseAnoula.Models;

namespace ExerciseAnoula
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("O Gianakis");
            human.House();

            CountryHouse countryHouse = new CountryHouse();
            countryHouse.BigDOr();

            //countryHouse.Anna();
            //CountryHouse countryHouse1 = new CountryHouse("Gianakis: Anoula eeeeeeeeeeeerxoooooomaiiii!!!!!!!!!");
            Human human1 = new Human("O Gianakis");
            human1.Mesa();
            human1.KnockDoor();

            human1.gianakis();
            human1.anoula(0);
            human1.gianakis1();

            Human human2 = new Human("O Gianakis");

            human2.OpenDoor();
            human2.Eksw();
            Human human3 = new Human("O Gianakis");

            human3.CloseDoor();
            human3.anoula(35);


        }
    }
}
