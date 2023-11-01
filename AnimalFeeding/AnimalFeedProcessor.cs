using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFeeding
{
    internal class AnimalFeedProcessor : IDisposable
    {
        private List<AnimalPlace> _animalPlaces { get; set; }

        public void AddNewAnimalPlace(List<AnimalPlace> animals)
        {
            foreach(var animal in animals)
            {
                animal.FoodFinishedz += Animal_FoodFinishedz; 
            }
        }

        private void Animal_FoodFinishedz(string name, AnimalPlace.FoodFinished a)
        {
            throw new NotImplementedException();
        }

        public void FeedAll()
        {
            Console.WriteLine("The animals is feeding");
        }

        public void Dispose()
        {
            foreach(var animal in _animalPlaces)
            {
                animal.FoodFinishedz -= Animal_FoodFinishedz;
            }
        }

        
    }
}
