using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    public class ChangingArray
    {
        public int LetterArray(int[] array, byte veribal)
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            string infoArray = veribal == 1 ? "Array of odd numbers in letters" : "Array of non-odd numbers in letters";
            Console.WriteLine(infoArray);

            string[] arrChar = new string[25];
            for (int i = 0; i < 25; i++)
            {
                arrChar[i] = i + "a";
            }

            string[] arrChar2 = new string[array.Length];

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string stNamber = array[i].ToString();

                for (int j = 0; j < arrChar.Length; j++)
                {
                    if (arrChar[j] == stNamber)
                    {
                        arrChar2[k] = arrChar[j];
                        Console.Write(arrChar2[k] + " ");
                        k++;
                    }
                }
            }

            // string[] arrayA = new string[array.Length];
            // int index = 0;
            // for (int i = 0; i < array.Length; i++)
            // {
            //    switch (array[i])
            //    {
            //        case 1:
            //            arrayA[i] = "A";
            //            index++;
            //            break;
            //        case 2:
            //            arrayA[i] = "b";
            //            break;
            //        case 3:
            //            arrayA[i] = "c";
            //            break;
            //        case 4:
            //            arrayA[i] = "D";
            //            index++;
            //            break;
            //        case 5:
            //            arrayA[i] = "E";
            //            index++;
            //            break;
            //        case 6:
            //            arrayA[i] = "f";
            //            break;
            //        case 7:
            //            arrayA[i] = "g";
            //            break;
            //        case 8:
            //            arrayA[i] = "H";
            //            index++;
            //            break;
            //        case 9:
            //            arrayA[i] = "I";
            //            index++;
            //            break;
            //        case 10:
            //            arrayA[i] = "J";
            //            index++;
            //            break;
            //        case 11:
            //            arrayA[i] = "k";
            //            break;
            //        case 12:
            //            arrayA[i] = "l";
            //            break;
            //        case 13:
            //            arrayA[i] = "m";
            //            break;
            //        case 14:
            //            arrayA[i] = "n";
            //            break;
            //        case 15:
            //            arrayA[i] = "o";
            //            break;
            //        case 16:
            //            arrayA[i] = "p";
            //            break;
            //        case 17:
            //            arrayA[i] = "q";
            //            break;
            //        case 18:
            //            arrayA[i] = "r";
            //            break;
            //        case 19:
            //            arrayA[i] = "s";
            //            break;
            //        case 20:
            //            arrayA[i] = "t";
            //            break;
            //        case 21:
            //            arrayA[i] = "u";
            //            break;
            //        case 22:
            //            arrayA[i] = "v";
            //            break;
            //        case 23:
            //            arrayA[i] = "w";
            //            break;
            //        case 24:
            //            arrayA[i] = "x";
            //            break;
            //        case 25:
            //            arrayA[i] = "y";
            //            break;
            //        case 26:
            //            arrayA[i] = "z";
            //            break;
            //    }

            // Console.Write($"{arrayA[i]} ");
            // }
            int index = 0;
            Console.WriteLine();
            Console.Write($"Number of letters in uppercase: {index}.");

            return index;
        }
    }
}
