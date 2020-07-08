using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P04Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        public Lake(List<T> numbers)
        {
            this.Numbers = numbers;
            Count = 0;
        }

        public int Count { get; set; }

        public List<T> Numbers { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var number in this.Numbers)
            {
                Count++;
                if (Count % 2 != 0)
                {
                    yield return number;
                }
            }

            for (int i = this.Numbers.Count - 1; i >= 0; i--)
            {
                Count++;
                if (Count % 2 != 0)
                {
                    yield return this.Numbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
