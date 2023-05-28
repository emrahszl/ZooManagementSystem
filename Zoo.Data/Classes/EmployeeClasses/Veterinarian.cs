using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.EmployeeClasses
{
    public class Veterinarian : Employee, IWhiteCollar
    {
        private static int _id = 200;

        public Veterinarian()
        {
            Id = _id;
            _id++;
        }

        public override int Id { get; }

        public void AttendMeetings()
        {
            Console.WriteLine($"{GetType()} toplantıya katıldı.");
        }

        public override void Work()
        {
            Console.WriteLine($"{GetType()} klinikte çalışıyor.");
        }

        public void TreatAnimal(Animal animal)
        {
            Console.WriteLine($"{animal} klinikte tedavi ediliyor.");
        }
    }
}
