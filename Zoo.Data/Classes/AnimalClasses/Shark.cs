using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Shark : Animal, IAquaticAnimal
    {
        private static int _id = 70;

        public Shark()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Köpek balığı besleniyor.");
        }

        public void Swim()
        {
            Console.WriteLine("Köpek balığı yüzüyor.");
        }
    }
}
