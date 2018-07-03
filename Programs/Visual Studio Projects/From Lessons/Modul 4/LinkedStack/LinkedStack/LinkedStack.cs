using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    class LinkedStack<T>
    {
        private class Node<T> {
            public T Value;
            public Node<T> NextNode;
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }
        }

        private Node<T> firstNode;
        public int Count { get; private set; }
        public void Push(T item)
        {
            this.firstNode = new Node<T>(item, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }
            T element = this.firstNode.Value;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] resultArr = new T[this.Count];
            var currentNode = this.firstNode;
            int index = 0;
            while (currentNode != null)
            {
                resultArr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }
            return resultArr;
        }
    }
}
