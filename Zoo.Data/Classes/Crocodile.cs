using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;

namespace Zoo.Data.Classes
{
    public class Crocodile : Animal
    {
        private static int _id = 000;

        public Crocodile()
        {
            _id++;
            Id = _id;
        }

        public override int Id { get; }

        public override void Feeding()
        {

        }

        public override void MakeSound()
        {

        }
    }
}
