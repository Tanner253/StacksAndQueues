using StacksAndQueues.classes;
using System;
using System.Collections.Generic;
using System.Collections;
namespace StacksAndQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            //StackClass<int> input = 10;
            
            
        }

        public static void RunPushMethod()
        {
            StackClass<int> stack = new StackClass<int>();
            
            Console.WriteLine("Choose a number to push to stack");
            int input1 = Convert.ToInt32(Console.ReadLine());



            stack.Push(input1);


            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
