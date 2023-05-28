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
        private int _age;

        public abstract int Id { get; }

        public Gender Gender { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Yaş negatif girilemez!");
                }
                else if (value > 150)
                {
                    throw new Exception("Yaş 150'den büyük girilemez!");
                }

                _age = value;
            }
        }

        public abstract void Feeding();
    }
}
