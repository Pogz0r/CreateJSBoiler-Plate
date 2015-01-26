using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SortedList
    {
        static void Main()
        {
            // ::: Declare two integer arrays with five elements each
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };

            // ::: Loop through the two arrays and print them
            foreach (int element in array1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------------");
            foreach (int element in array2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------------------------");

            // ::: Create new List of integers and call AddRange twice
            var list = new List<int>();
            list.AddRange(array1);
            list.AddRange(array2);

            // ::: Call ToArray to convert List to array
            int[] array3 = list.ToArray();

            // ::: Loop through array elements of combined array and print them
            foreach (int element in array3)
            {
                Console.WriteLine(element);
            }
        }

    }
}
