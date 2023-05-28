using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Elephant : Animal, IMammal
    {
        private static int _id = 30;

        public Elephant()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Fil besleniyor.");
        }

        public void Nurse()
        {
            Console.WriteLine("Fil doğuruyor.");
        }
    }
}
