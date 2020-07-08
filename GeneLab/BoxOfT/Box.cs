using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxes;
        private int count;

        public Box()
        {
            this.boxes = new List<T>();
        }

        public List<T> Boxes
        {
            get { return this.boxes; }
            set { this.boxes = value; }
        }

        public int Count => count = boxes.Count;

        public void Add(T element)
        {
            boxes.Add(element);
        }

        public T Remove()
        {
            if (boxes.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty box");
            }

            var element = this.boxes[boxes.Count - 1];
            this.boxes.RemoveAt(boxes.Count - 1);

            return element;
        }


    }
}
