using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    internal class AnimalPlace
    {
        private string _name { get; set; }
        private string _nameOfFeed { get; set; }
        
        public delegate void FoodFinished(string name, FoodFinished a);
        public event FoodFinished FoodFinishedz;


        public void Feed(int amount)
        {

        }
    }
}
