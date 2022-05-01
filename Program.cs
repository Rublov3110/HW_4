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

                Console.Write("Длинна массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[n];

                Random random = new Random();
                Console.WriteLine("Основной масив");
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
                Console.WriteLine("Масив четных чисел");

                foreach (int i in evvenArray)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Масив не четных чисел");

                foreach (int i in oddArray)
                {
                    Console.Write($"{i} ");
                }

                int indexEvven = changingArray.LetterArray(evvenArray, "evvenArray");
                int indexOdd = changingArray.LetterArray(oddArray, "oddArray");

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));

                if (indexEvven > indexOdd)
                {
                    Console.WriteLine($"В масиве четных чисел букв в верхнем регистре болеше: {indexEvven} против {indexOdd}");
                }
                else
                {
                    Console.WriteLine($"В масиве не четных чисел букв в верхнем регистре болеше: {indexOdd} против {indexEvven}");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}