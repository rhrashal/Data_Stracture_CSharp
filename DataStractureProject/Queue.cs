using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStractureProject
{
    public class QueueTest
    {
        //Fast in Fast out
        public static void MainQueue()
        {

            // Creating a Queue 
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue
            myQueue.Enqueue("Geeks");
            myQueue.Enqueue("Geeks Classes");
            myQueue.Enqueue("Noida");
            myQueue.Enqueue("Data Structures");
            myQueue.Enqueue("GeeksforGeeks");

            Console.WriteLine(myQueue.Count);
            // Converting the Queue
            // into object array
            Object[] arr = myQueue.ToArray();

            // Displaying the elements in array
            foreach (Object obj in arr)
            {
                Console.WriteLine(obj);
            }



            Queue sq = Queue.Synchronized(myQueue);

            // Displays the synchronization
            // status of both Queue
            Console.WriteLine("myQueue is {0}.", myQueue.IsSynchronized ?
                                    "Synchronized" : "Not Synchronized");

            Console.WriteLine("sq is {0}.", sq.IsSynchronized ?
                           "Synchronized" : "Not Synchronized");







            Queue q1 = new Queue();

            // Adding elements to Queue
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
        

            // Using the SyncRoot property
            lock (q1.SyncRoot)
            {
                // foreach loop to display
                // the elements in q1
                foreach (Object i in q1)
                    Console.WriteLine(i);
            }

            q1.Dequeue();
            q1.Clear();



         
            // Creating copy using Clone() method.
            Queue myQueue2 = (Queue)myQueue.Clone();
            myQueue2.Dequeue();

            Console.WriteLine(myQueue.Contains(7));



            // Creating an Queue
            Queue myq = new Queue();

            // Adding elements to Queue
            myq.Enqueue("A");
            myq.Enqueue("B");


            String[] arrq = new String[6];

            // adding elements to Array
            arrq[0] = "HTML";
            arrq[1] = "PHP";
            arrq[2] = "Java";


            myq.CopyTo(arr, 2);


        }
    }

}

