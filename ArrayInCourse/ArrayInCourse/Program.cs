using System;

namespace ArrayInCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = new int[3];
            myInts[0] = 4;
            myInts[2] = 10;
            //myInts = new int[4]; // toate pozitiile vor fi 0, valoarea default a int-ului

            int[] biggerArray = new int[4];
            for (int i = 0; i < myInts.Length; i++)
            {
                biggerArray[i] = myInts[i];
            }

            int[] clonedArray;
            clonedArray = (int[])myInts.Clone();

            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }

            string[] days = { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };
            string[] secondDays = days; // the changes on days will be reflected in secondDays
            string[] thirdDays = (string[])days.Clone();


            int joi = Array.IndexOf(days, "Joi");
            int lastJoi = Array.LastIndexOf(days, "Joi");
            Array.Clear(days, 2, 2);
            Array.Reverse(days);
            Array.Reverse(days, 3, 2);
           

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            foreach (string day in days)
            {
                Console.WriteLine(day);
            }

            for (int i = myInts.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myInts[i]);
            }

            //Matrix

            int[,] matrix = new int[2, 3]; // 2 randuri si 3 coloane
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;

            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = 2;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.Write("\n");
            }

        }
    }
}
