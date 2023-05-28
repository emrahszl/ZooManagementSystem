using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.Enums;

namespace Zoo.Data.AbstractClasses
{
    public abstract class Employee
    {
        public abstract int Id { get; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public Department Department { get; set; }

        public decimal Salary { get; set; }

        public abstract void Work();
    }
}
