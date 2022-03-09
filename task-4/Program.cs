using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Modul(-4, 9, -7, 1, -4);

            // task 2
            //Console.WriteLine(Reverse("Nurlan"));
        }
        #region task 1
        static int[] Modul(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= (-1);
                }
                Console.Write(arr[i] + " ");
            }
            return arr;
            #endregion

            #region task 2

            //static string Reverse(string word)
            //{
            //    string result = string.Empty;
            //    for (int i = word.Length -1; i>=0; i--)
            //    {
            //       result += word[i];
            //    }
            //    return result;
            //}
            #endregion

        }

    }
}
