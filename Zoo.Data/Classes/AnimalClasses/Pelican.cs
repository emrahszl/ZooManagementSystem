using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.AnimalClasses
{
    public class Pelican : Animal, IBird
    {
        private static int _id = 60;

        public Pelican()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {
            Console.WriteLine("Pelikan besleniyor.");

        }

        public void Fly()
        {
            Console.WriteLine("Pelikan uçuyor.");
        }
    }
}
