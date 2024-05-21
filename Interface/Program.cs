using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace

{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortClass sObj1 = new SortClass();
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 int numbers");
            for (int i=0;i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            sObj1.performOperation(arr);
            Console.ReadKey();
       }
    }
}
