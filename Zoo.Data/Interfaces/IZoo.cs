using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Classes;
using Zoo.Data.Collections;

namespace Zoo.Data.Interfaces
{
    public interface IZoo
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public int Capacity { get; set; }

        public TimeSpan OpenningHours { get; set; }

        public Animals Animals { get; set; }

        public Employees Employees { get; set; }

        public Animal GetAnimalById(int id);

        public Employee GetEmployeeById(int id);
    }
}
