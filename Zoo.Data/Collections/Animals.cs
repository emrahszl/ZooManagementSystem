using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;

namespace Zoo.Data.Collections
{
    public class Animals : ICollection<Animal>
    {
        private List<Animal> animals;

        public Animals()
        {
            animals = new List<Animal>();
        }

        public int Count => animals.Count;

        public bool IsReadOnly => false;

        public void Add(Animal item)
        {
            animals.Add(item);
        }

        public void Clear()
        {
            animals.Clear();
        }

        public bool Contains(Animal item)
        {
            return animals.Contains(item);
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            animals.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        public bool Remove(Animal item)
        {
            return animals.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
