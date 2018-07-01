using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class DynamicList
    {
        //реализираме класа за възел
        private class Node
        {
            private object element;
            private Node next;
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
            //този конструктор се вика, когато вече има поне 1 елемент в списъка
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this; //записваме, че на даден родител му принадлежи новосъздаденото дете-възел
            }

            //този конструктор се вика, когато създаваме първия елемент в списъка
            public Node(object element)
            {
                this.element = element;
                this.next = null;
            }

        }

        private Node head; //първи елемент от списъка
        private Node tail; //последен елемент от списъка
        private int count = 0;

        public DynamicList()
        {
            //създаваме празен списък
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (this.head == null) //добавяме първия елемент, ако този if e true
            {
                //ако добавяме първи елемент, то викаме конструктора с 1 параметър
                this.head = new Node(item);
                this.tail = this.head; //единственият елемент и начало и край
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }

        public object Remove(int index)
        {
            //проверяваме дали индекса НЕ е невалиден
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            //намиране на елемента
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            //Реално премахване на елемента
            count--;
            if (count == 0)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            //намираме последния елемент
            Node lastElement = null;
            if (this.head != null)
            {
                //все още имаме елементи в списъка!
                lastElement = this.head;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;

            return currentNode.Element;
        }

        public int Remove(object item)
        {
            //намираме елемента
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentNode != null)
            {
                if( (currentNode.Element!=null &&
                    currentNode.Element.Equals(item))
                    || 
                    (currentNode.Element==null &&
                    (item==null))
                    )
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            //ако сме намерили елемента, който търсим
            if (currentNode != null)
            {
                count--;
                if (count == 0)
                {
                    head = null;
                }
                else if (prevNode == null)
                {
                    head = currentNode.Next;
                }
                else
                {
                    prevNode.Next = currentNode.Next;
                }

                //намираме последния елемент
                Node lastElement = null;
                if (this.head != null)
                {
                    lastElement = this.head;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }
                tail = lastElement;

                return currentIndex;
            }
            else
            {
                //елементът не е намерен
                return -1;
            }
        }

        public int IndexOf(object item)
        {
            int index = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                if ((currentNode.Element != null &&
                    currentNode.Element==item)
                    ||
                    (currentNode.Element == null &&
                    (item == null))
                    )
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;                
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
