using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;

namespace Zoo.Data.Collections
{
    public class Employees : ICollection<Employee>
    {
        private List<Employee> employees;

        public Employees()
        {
            employees = new List<Employee>();
        }

        public int Count => employees.Count;

        public bool IsReadOnly => false;

        public void Add(Employee item)
        {
            employees.Add(item);
        }

        public void Clear()
        {
            employees.Clear();
        }

        public bool Contains(Employee item)
        {
            return employees.Contains(item);
        }

        public void CopyTo(Employee[] array, int arrayIndex)
        {
            employees.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        public bool Remove(Employee item)
        {
            return employees.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
