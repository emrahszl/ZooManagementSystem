using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Enums;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.EmployeeClasses
{
    public class SecurityStaff : Employee, IBlueCollar
    {
        private static int _id = 300;

        public SecurityStaff()
        {
            Id = _id;
            _id++;
        }

        public override int Id { get; }

        public Equipment Equipment { get; set; }

        public void OperateEquipment(Equipment equipment)
        {
            Console.WriteLine($"{GetType()} {equipment} kullanıyor.");
        }

        public override void Work()
        {
            Console.WriteLine($"{GetType()} sahada geziyor.");
        }
    }
}
