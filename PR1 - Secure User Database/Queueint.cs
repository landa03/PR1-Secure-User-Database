using System;
using System.Collections.Generic;

namespace PR1___Secure_User_Database
{
    class Queueint
    {
        private List<int> elements = new List<int>();

        //Enqueue
        public void Enqueue(int elementToEnqueue)
        {
            elements.Add(elementToEnqueue);
            System.Console.WriteLine($"Enqueue({elementToEnqueue})");
        }

        //Dequeue
        public int Dequeue()
        {
            int firstElement = elements[0];

            elements.RemoveAt(0);

            return firstElement;
        }

        //Front
        public int? Front()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int firstElement = elements[0];

            return firstElement;
        }

        //Rear
        public int? Rear()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int lastPosition = elements.Count - 1;

            return elements[lastPosition];
        }

        //print queue
        public void Print()
        {
            foreach (int truk in elements)
            {
                System.Console.Write($"{truk},");
            }
        }
        public void DequeueAll()
        {
            foreach (int truk in elements)
            {
                Dequeue();
            }
        }
        

        public override string ToString()
        {
            string queueAsString = "";
            queueAsString += "---------------------\n";
            foreach (var item in elements)
            {
                queueAsString += $"{item} | ";

            }
            queueAsString += "\n---------------------\n";

            return queueAsString;
        }
    }
}
