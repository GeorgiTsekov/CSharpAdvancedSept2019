using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03Stack
{
    public class CustumStack<T> : IEnumerable<T>
    {
        public CustumStack()
        {
            this.Elements = new Stack<T>();
        }

        public CustumStack(T element) : this()
        {
            this.Elements.Push(element);
        }

        public Stack<T> Elements { get; set; }

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
