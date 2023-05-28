using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Lion : Animal, IMammal
    {
        private static int _id = 40;

        public Lion()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Aslan besleniyor.");
        }

        public void Nurse()
        {
            Console.WriteLine("Aslan doğuruyor.");
        }
    }
}
