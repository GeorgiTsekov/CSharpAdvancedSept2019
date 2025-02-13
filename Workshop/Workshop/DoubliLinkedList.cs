﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class DoubliLinkedList
    {
        public class LinkNode
        {
            public int Value { get; set; }

            public LinkNode NextNode { get; set; }

            public LinkNode PreviousNode { get; set; }

            public LinkNode(int value)
            {
                this.Value = value;
            }
        }
        private LinkNode head;
        private LinkNode tail;

        public int Count { get; private set; }

        public void AddFirst(int value)
        {
            LinkNode newHead = new LinkNode(value);

            if (this.Count == 0)
            {
                this.tail = this.head = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }

        public void AddLast(int value)
        {
            LinkNode newTail = new LinkNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public int RemoveFirst()
        {
            CheckIfEmptyThrowExeption();

            int firstElement = this.head.Value;

            this.head = this.head.NextNode;

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
            }

            this.Count--;

            return firstElement;
        }

        public int RemoveLast()
        {
            CheckIfEmptyThrowExeption();

            int lastElement = this.tail.Value;

            this.tail = this.tail.PreviousNode;

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            this.Count--;

            return lastElement;
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];

            var currentNode = this.head;
            int counter = 0;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public bool Contains(int value)
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        private void CheckIfEmptyThrowExeption()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException(message: "DoublyLinkedList is empty!");
            }
        }

        public void Print(Action<int> action)
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }
    }
}
