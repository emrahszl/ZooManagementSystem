using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Monkey : Animal, IMammal
    {
        private static int _id = 50;

        public Monkey()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Maymun besleniyor.");
        }

        public void Nurse()
        {
            Console.WriteLine("Maymun doğuruyor.");
        }
    }
}
