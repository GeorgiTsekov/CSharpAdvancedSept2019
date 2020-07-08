using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P01GenericBoxOfString
{
    public class Box<T> 
        where T : IComparable<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void Add(T item)
        {
            boxCollection.Add(item);
        }

        // -1 is smaller/ 0 is equall / +1 is bigger//
        public void CountBiggerThenBoxColl(T input)
        {
            boxCollection = boxCollection.Where(x => x.CompareTo(input) == 1).ToList();
        }

        public override string ToString()
        {
            return boxCollection.Count.ToString().TrimEnd();
        }
    }
}
