using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Crocodile : Animal, IReptile, IAquaticAnimal
    {
        private static int _id;

        public Crocodile()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Timsah besleniyor.");
        }

        public void LayEggs()
        {
            Console.WriteLine("Timsah yumurtluyor.");
        }

        public void Swim()
        {
            Console.WriteLine("Timsah yüzüyor.");
        }
    }
}
