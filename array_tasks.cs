using System;

namespace array_itro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1
            #region
            int[] arr = { 3, 4, 5, 8 };
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine(avg);
            #endregion
            //TASK-2

            #region
            int[] arr = { 17, -2, 3, 4, 6 };
            int positivnum = 0;
            int negativnum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positivnum++;

                }
                else if (arr[i] < 0)
                {
                    negativnum++;
                }
            }

            Console.WriteLine(positivnum);

            Console.WriteLine(negativnum);

            #endregion
            #region
            //TASK3
            int[] arr = { 700, 3, 89, 6 };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                   max= arr[i];
                }

            }
            Console.WriteLine(max);


            #endregion

        }
    }
}
