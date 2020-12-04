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
            numbers.CopyTo(array2, numbers.Count);  //We copied the array numbers to the array2



            foreach (var num in array2)
            {
                Console.WriteLine(num);
            }
            // Queues and stacks are usefuel when  You need a temporalily storage of information  !
            //Objects stored in queue are inserted in one end and removed form the other End;
            //Use Generic Queue <T> class , dont use Queue class- > use Generic Queue <T> class ! 
            // non Generic collections shouldnt be used ! 
            //use queue if You want to access the information in the same order that is stored in the collection
            // Concept First In First Out !!

            // Use stack if You need to access the informnaton in Reverse way .
            //LIFO --concept-Last in First Out access of information !
            // Method Enqueue () --adds element on the end of the Queue
            // Dequeue()-removes the elemtne form the start of the queue-oldest element 
            // Peek() -> returns the opldest element form the start of the Queue//
            //-but does not remove it from the queue
            // the capacity of the queue is the number of teh elements that it can hold !
            // as the elements are addesd - the size of the queue is extended 
            // TrimToSize();
            // Queue  accepts null as a value, and can accept duoplicate elements !
            // Queue.Count --gets teh numebr of the elements of teh Queue


            //there is a class Queue and class Queue <T> , use class Queue<T>
            //Queue stores the elements in FIFO style -first in first out! 
            // it is used when you need fierst in forst out access of the info,
        }

    }
}
