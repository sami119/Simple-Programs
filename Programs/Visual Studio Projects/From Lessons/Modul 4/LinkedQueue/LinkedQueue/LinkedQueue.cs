using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    class LinkedQueue<T> : IEnumerable<T>
        {
            private class QueueNode<T>
            {
                public T Value { get; private set; }
                public QueueNode<T> PrevNode { get; set; }
                public QueueNode<T> NextNode { get; set; }

                public QueueNode(T value)
                {
                    this.Value = value;
                }
            }

            private QueueNode<T> head;
            private QueueNode<T> tail;
            public int Count { get; private set; }

            public void Enqueue(T item)
            {
                if (this.Count == 0)
                {
                    this.head = this.tail = new QueueNode<T>(item);
                }
                else
                {
                    QueueNode<T> newTail = new QueueNode<T>(item);
                    newTail.PrevNode = this.tail;
                    this.tail.NextNode = newTail;
                    this.tail = newTail;
                }
                this.Count++;
            }

            public T Dequeue()
            {
                if (this.Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty!");
                }

                var firstElement = this.head;
                this.head = this.head.NextNode;
                if (this.head != null)
                {
                    //имаме поне още един елемент в списъка
                    this.head.PrevNode = null;
                }
                else
                {
                    //премахваме последния елемент в списъка и той остава празен
                    this.tail = null;
                }
                this.Count--;
                return firstElement.Value;
            }

            public void ForEach(Action<T> action)
            {
                var currentNode = this.head;
                while (currentNode != null)
                {
                    action(currentNode.Value);
                    currentNode = currentNode.NextNode;
                }
            }
            public T[] ToArray()
            {
                T[] resultArr = new T[this.Count];
                int index = 0;
                var currentNode = this.head;
                while (currentNode != null)
                {
                    resultArr[index++] = currentNode.Value;
                    currentNode = currentNode.NextNode;
                }

                return resultArr;
            }

            public IEnumerator<T> GetEnumerator()
            {
                var currentNode = this.head;
                while (currentNode != null)
                {
                    yield return currentNode.Value;
                    currentNode = currentNode.NextNode;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
}
