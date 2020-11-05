using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseAnoula.Interfaces;

namespace ExerciseAnoula.Models
{
    class CountryHouse : Door , ICountryHouse
    {

     

        public CountryHouse()
        {   

            
        }
     
        public void House()
        {
            Console.WriteLine("exei ena spiti stin eksoxi");
        }

        public void Mesa()
        {
            Console.Write("einai mesa sto spiti");
        }

        public void Eksw()
        {
            Console.WriteLine(" kai bgainei apo to spiti");
        }



        }
    }

