using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAnimalRepository
    {
        public void SaveAnimal(Animal animal);
        public void DeleteAnimal(int id);
        public void UpdateAnimal(Animal animal);
        public List<Animal> GetAnimals();
    }
}
