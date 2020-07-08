using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P01ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;

        public ListyIterator(List<T> elements)
        {
            this.Elements = elements;
            this.index = 0;
        }

        public List<T> Elements { get; set; }

        public bool Move()
        {
            if (this.Elements.Count - 1 > this.index)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.Elements.Count - 1 > this.index)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Elements.Count > 0)
            {
                Console.WriteLine(this.Elements[this.index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public void PrintAll()
        {
            if (this.Elements.Count > 0)
            {
                foreach (var item in this.Elements)
                {

                }
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.Elements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
