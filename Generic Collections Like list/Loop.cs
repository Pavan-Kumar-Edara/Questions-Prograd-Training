using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Like_list
{
    public class Loop<T>
    {
        public void RotateLeft(int[] arr, int size)
        {
            for (int iterator = 0; iterator < 2; iterator++)
            {
                int temp = arr[0];

                for (int iteratorTwo = 0; iteratorTwo < arr.Length - 1; iteratorTwo++)
                {
                    arr[iteratorTwo] = arr[iteratorTwo + 1];
                }

                arr[arr.Length - 1] = temp;
            }

        }
        public void RotateRight(int[] arr, int size)
        {
            for (int iterator = 0; iterator < 1; iterator++)
            {
                int lastElement = arr[arr.Length - 1];
                for (int iteratorTwo = arr.Length - 1; iteratorTwo > 0; iteratorTwo--)
                {
                    arr[iteratorTwo] = arr[iteratorTwo - 1];
                }
                arr[0] = lastElement;
            }

        }
        public void display(int[] arr)
        {
            for (int iterator = 0; iterator < arr.Length; iterator++)
            {
                Console.WriteLine(arr[iterator]);
            }
        }

        public void Showfirst(int[] arr)
        {
            Console.WriteLine(arr[0]);
        }
        public void PopFirst(int[] arr)
        {
            Console.WriteLine(arr[0]);
            for (int iterator = 1; iterator < arr.Length - 1; iterator++)
            {
                arr[iterator] = arr[iterator + 1];
            }
            arr[0] = default(int);

        }
    }
}
