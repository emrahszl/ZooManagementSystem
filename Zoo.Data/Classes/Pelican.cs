using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;

namespace Zoo.Data.Classes
{
    public class Pelican : Animal
    {
        private static int _id = 600;

        public Pelican()
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
