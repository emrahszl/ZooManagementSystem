using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.Enums;

namespace Zoo.Data.AbstractClasses
{
    public abstract class Animal
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public abstract void Feeding();
        public abstract void MakeSound();
    }
}
