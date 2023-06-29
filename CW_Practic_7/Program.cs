using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Practic_7
{
    internal class MyArray
    {
        private int[][] arr;
        public MyArray(int first, int second)
        {
            arr = new int[first][];
            Random r = new Random();
            for (int i = 0; i < first; i++)
            {
                arr[i] = new int[second];
                for (int y = 0; y < second; y++)
                {
                    arr[i][y] = r.Next(0, 2);
                }
            }
        }
        public MyArray()
        {
            arr = new int[10][];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = new int[5];
                for (int y = 0; y < 5; y++)
                {
                    arr[i][y] = r.Next(0, 2);
                }
            }
        }
        public int this[int indexFirst, int indexSecond]
        {
            get
            {
                if (indexFirst >= 0 && indexFirst < arr.Length)
                {
                    if (indexSecond >= 0 && indexSecond < arr[0].Length)
                    {
                        return arr[indexFirst][indexSecond];
                    }
                }
                throw new Exception("getError");
            }
            set
            {
                if (indexFirst >= 0 && indexFirst < arr.Length)
                {
                    if (indexSecond >= 0 && indexSecond < arr[0].Length)
                    {
                        arr[indexFirst][indexSecond] = value;
                    }
                }
                else
                {
                    throw new Exception("setError");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray test = new MyArray(10, 10);
            Console.WriteLine(test[1, 0]);
            test[1, 1] = 8;
            Console.WriteLine(test[1, 1]);
        }
    }
}
