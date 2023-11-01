using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AnimalPlace> animalPlace1 = new List<AnimalPlace>();
            AnimalPlace animalPlace2 = new AnimalPlace();
            
            
            AnimalFeedProcessor animalFeedProcessor1 = new AnimalFeedProcessor();
            

            animalFeedProcessor1.AddNewAnimalPlace(animalPlace1);

            animalPlace2.FoodFinishedz += AnimalPlace2_FoodFinishedz;

            
            
        }

        private static void AnimalPlace2_FoodFinishedz(string name, AnimalPlace.FoodFinished a)
        {
            Console.WriteLine("Animal was feed");
        }

       
    }
}
