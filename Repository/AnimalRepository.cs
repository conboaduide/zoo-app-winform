using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        public void DeleteAnimal(int id)
        => AnimalDAO.Instance.DeleteAnimal(id);

        public List<Animal> GetAnimals()
        => AnimalDAO.Instance.GetAnimals();

        public void SaveAnimal(Animal animal)
        => AnimalDAO.Instance.SaveAnimal(animal);

        public void UpdateAnimal(Animal animal)
        => AnimalDAO.Instance.UpdateAnimal(animal);
    }
}
