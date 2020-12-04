using System;
using System.Collections.Generic;

namespace _01.DataStructures
{
    public class SampleQueue
    {
        public static void Main(string[] args)
        {
            // queue--data structure
            // here the concept is FIFO -first in first out ! 
            // the frist element entered gets out first
            //  queue ordered data structure 
            //queue - printint data on printers, when  we  have many computers, 
            // when we write on the keyboard.
            //one element is added in one side -rear, the othes is coming ouy in the other rear, 

            // the concept here is FiFo-first in first out! 
            // queue represents first in first out object! 
            // it is used when  You need first in first out data access, access of items 
            // when You add an item on the list it is called enqueue, 
            // when Yuo remove an item from the list it is called dequeue, 
            //Queue represent a list of items in lisrt with concept first in first out 
            // the elements od teh Queue are enumerted ! 

            Queue<string> numbers = new Queue<string>();  // creating an object Queue of type string
            numbers.Enqueue("one");  //adding an element to the queue
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
           // numbers.Dequeue(); //removes the first element on the queue
            //numbers.Peek(); --shows the next top elements withput removing it

            foreach (string item in numbers)  //enumerating teh queue ;iterating with foreaech  loop
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n Dequeueing '{0}'", numbers.Dequeue()); //removing the first element

            // create as copy of the queue numbers

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            Console.WriteLine("\nContents of teh first copy");
            foreach (string item in queueCopy)
            {
                Console.WriteLine(item);
            }

            // create an  array twice the  size of the queue and copy the elements of the queue, 
            // statring at the middle

            string[] array2 = new string[numbers.Count * 2]; // create an array twice the size of numners Queue
            numbers.CopyTo(array2, numbers.Count );  //We copied the array numbers to the array2

            

            foreach (var num in array2)
            {
                Console.WriteLine(num);
            }
        }

    }
}
