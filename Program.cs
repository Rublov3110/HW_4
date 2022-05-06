using System;

namespace HW_4
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                ChangingArray changingArray = new ChangingArray();

                Console.Write("Array length:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[n];

                Random random = new Random();
                Console.WriteLine("Main array");
                for (int i = 0; i < mainArray.Length; i++)
                {
                    mainArray[i] = random.Next(1, 26);
                    Console.Write($"{mainArray[i]} ");
                }

                int[] evvenArray = new int[n];
                int[] oddArray = new int[n];

                for (int i = 0; i < mainArray.Length; i++)
                {
                    if (mainArray[i] % 2 == 0)
                    {
                        evvenArray[i] = mainArray[i];
                    }
                    else
                    {
                        oddArray[i] = mainArray[i];
                    }
                }

                evvenArray = evvenArray.Where(s => s != 0).ToArray();
                oddArray = oddArray.Where(s => s != 0).ToArray();

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Array of even numbers");

                foreach (int i in evvenArray)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Array of odd numbers");

                foreach (int i in oddArray)
                {
                    Console.Write($"{i} ");
                }

                int indexEvven = changingArray.LetterArray(evvenArray, 2);
                int indexOdd = changingArray.LetterArray(oddArray, 1);

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));

                if (indexEvven > indexOdd)
                {
                    Console.WriteLine($"In an array of even numbers of uppercase letters over: {indexEvven} vs {indexOdd}");
                }
                else
                {
                    Console.WriteLine($"In an array of odd numbers of uppercase letters over: {indexOdd} vs: {indexOdd}");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}