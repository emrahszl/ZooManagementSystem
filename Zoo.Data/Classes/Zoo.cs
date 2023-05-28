using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Collections;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes
{
    public class Zoo : IZoo
    {
        private string _name;

        private string _location;

        private int _capacity;

        private TimeSpan _openingHours;

        private TimeSpan _closingHours;

        public Zoo(string name, string location, int capacity, TimeSpan openingHours, TimeSpan closingHours)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            OpenningHours = openingHours;
            ClosingHours = closingHours;
        }

        public string Name { get => _name; set => _name = value; }

        public string Location { get => _location; set => _location = value; }

        public int Capacity { get => _capacity; set => _capacity = value; }

        public TimeSpan OpenningHours { get => _openingHours; set => _openingHours = value; }

        public TimeSpan ClosingHours { get => _closingHours; set => _closingHours = value; }

        public Animals Animals { get; set; } = new();

        public Employees Employees { get; set; } = new();

        public Animal GetAnimalById(int id)
        {
            return Animals.First(x => x.Id == id);
        }

        public Employee GetEmployeeById(int id)
        {
            return Employees.First(x => x.Id == id);
        }
    }
}
