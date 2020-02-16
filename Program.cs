using System;
using System.Linq;

namespace Test_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<string> myArray = new MyArray<string>();
            myArray.AddFirst("Owner");
            myArray.Add("Hello");
            myArray.Add("World");
            myArray.Add("!");
            
            Console.WriteLine("Количество элементов:" + myArray.Count());
            
            foreach (var item in myArray)
            {
                Console.Write(item + ' ');
            }
            Console.WriteLine();

            myArray.Remove("Owner");

            foreach (var item in myArray.BackEnumerator())
            {
                Console.Write(item + ' ');
            }

            var items = from i in myArray
                  where i.Contains("Hello")
                  select i;
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

}
