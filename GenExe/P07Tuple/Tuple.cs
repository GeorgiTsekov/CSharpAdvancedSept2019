using System;
using System.Collections.Generic;
using System.Text;

namespace P07Tuple
{
    public class Tuple<T, D, E>
    {
        private T item1;
        private D item2;
        private E item3;

        public Tuple(T item1, D item2, E item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public string GetInfo()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
