using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class AnimalDAO
    {
        private static AnimalDAO instance = null;
        private static object lockObject = new object();

        private AnimalDAO() { }

        public static AnimalDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimalDAO();
                }
                return instance;
            }
        }
        public List<Animal> GetAnimals()
        {
            using var db = new ZooManagementContext();
            return db.Animals.ToList();
        }
        public void SaveAnimal(Animal animal)
        {
            using var db = new ZooManagementContext();
            db.Animals.Add(animal);
            db.SaveChanges();
        }
        public void UpdateAnimal(Animal animal)
        {
            using var db = new ZooManagementContext();
            {
                var existingAnimal = db.Animals.Find(animal.Id);
                if (existingAnimal != null)
                {
                    // Update properties of the existing user
                    existingAnimal.Name = animal.Name;
                    existingAnimal.Species = animal.Species;
                    existingAnimal.Location = animal.Location;
                    existingAnimal.Class = animal.Class;
                    existingAnimal.Status = animal.Status;
                    db.SaveChanges();
                }
                else
                {
                    // User not found, handle accordingly (e.g., throw an exception or log a message)
                }
            }
        }

        public void DeleteAnimal(int id)
        {
            using var db = new ZooManagementContext();
            Animal animal = db.Animals.Find(id);
            if (animal != null)
            {
                db.Animals.Remove(animal);
                db.SaveChanges();
            }
        }
    }
}
