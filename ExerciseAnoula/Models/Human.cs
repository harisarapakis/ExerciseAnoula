using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseAnoula.Interfaces;

namespace ExerciseAnoula.Models
{
    class Human : CountryHouse,IHuman
    {
        private string _gianakis;

        public string Gianakis
        {
            get { return _gianakis; }
            set { _gianakis = value; }
        }

        public Human()
        {
        }

        public Human(string name)
        {
            this._gianakis = name;
            Console.Write(Gianakis+" ");
        }

        public void  gianakis()
        {
            Console.WriteLine("Poios einai");
        }
        public void anoula(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("Egw eimai gianni mou!");
            }
            else
            {
                Console.WriteLine(" kai pianei tin anoula apo to xeri kai pane volta");
            }
        }
        public void gianakis1()
        {
            Console.WriteLine("Anoula eeeeeeeerxxxxxxxxomaiiiii!!!");
        }
    }
}
