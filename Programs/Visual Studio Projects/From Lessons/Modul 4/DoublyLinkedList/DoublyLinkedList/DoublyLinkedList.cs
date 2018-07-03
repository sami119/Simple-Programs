using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoublyLinkedList
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class ListNode<T>
        {
            public T Value { get; private set; }
            public ListNode<T> PrevNode { get; set; }
            public ListNode<T> NextNode { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }
        }

        private ListNode<T> head;
        private ListNode<T> tail;
        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(item);
            }
            else
            {
                ListNode<T> newHead = new ListNode<T>(item);
                newHead.NextNode = this.head;
                this.head.PrevNode = newHead;
                this.head = newHead;
            }
            this.Count++;
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

        public void AddLast(T item)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(item);
            }
            else
            {
                ListNode<T> newTail = new ListNode<T>(item);
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
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

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            var lastElement = this.tail;
            this.tail = this.tail.PrevNode;
            if (this.tail != null)
            {
                //имаме поне още един елемент в списъка
                this.tail.NextNode = null;
            }
            else
            {
                //премахваме последния елемент в списъка и той остава празен
                this.head = null;
            }
            this.Count--;
            return lastElement.Value;
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
