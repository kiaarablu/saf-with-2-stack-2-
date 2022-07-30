using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saf_2_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1(3);

            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);
            a.printnum();
            a.Deqeueu();
            a.Deqeueu();
            a.Deqeueu();
            a.Deqeueu();
            a.Enqueue(6);
            a.Enqueue(8);
            a.Enqueue(11);
            a.Enqueue(50);
            a.Enqueue(40);
            a.Enqueue(98);
            a.printnum();

            Console.WriteLine("-------------------------");
            

            //a.dequeue();
            //a.printnum();
            //a.dequeue();
            //a.dequeue();
            //a.dequeue();

            Console.ReadKey();
        }
    }
}
