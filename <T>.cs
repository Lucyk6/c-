using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ллл
{
   class Array <T>
    {
        private T[] array;
        private int count;

        public Array (int size)
        {
            array = new T[size];
        }

        public void Add(T value )
        {
            array[count++]=value;
        }

    }
    internal class Program
    {
        static void Test <t> (t text)
        {
            Console.WriteLine (text);
        }
        static void Main(string[] args)
        {
            Action a = () => Console.WriteLine(1);
            
            Array <int> b= new Array<int>(3);

            Array <bool> k= new Array<bool>(2);

        }
    }
}
