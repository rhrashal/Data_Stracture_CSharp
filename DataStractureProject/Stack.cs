using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStractureProject
{
    public class StackTest
    {
        /// <summary>
        /// Last in First out
        /// </summary>
        public static void MainStack()
        {
            Stack<string> stack1 = new Stack<string>();
            string[] str = { "MCA", "BCA", "BBA", "MBA", "MTech" };
            Stack<string> stack2 = new Stack<string>(str);
            Stack<string> stack3 = new Stack<string>(10);
            Console.WriteLine("The elements in the stack1 are:" + stack1.Count());
            Console.WriteLine("The elements in the stack2 are:" + stack2.Count());
            Console.WriteLine("The elements in the stack3 are:" + stack3.Count());

        }


    } 
}
       
        


