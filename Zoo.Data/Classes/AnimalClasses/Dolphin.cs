using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Dolphin : Animal, IMammal, IAquaticAnimal
    {
        private static int _id = 10;

        public Dolphin()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Yunus besleniyor.");
        }

        public void Nurse()
        {
            Console.WriteLine("{Yunus doğuruyor.");
        }

        public void Swim()
        {
            Console.WriteLine("Yunus yüzüyor.");
        }
    }
}
