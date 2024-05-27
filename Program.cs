using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Algoritmer
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] data = { 3, 5, 2, 8, 11, 16, 9, 1 };

            Console.WriteLine("Lucas-nummer för n= 10 är:" + LucasNummer(10));

        }

        static void BubbleSort(int[] data)
        {
            for (int j = 0; j < data.Length - 1; j++)
            {


                bool isSorted = true;
                for (int i = 0; i < data.Length - 1 - j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        isSorted = false;
                        int tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                    }
                }
                PrintArray(data);
                if (isSorted)
                {
                    break;
                }

            }
        }
        static void PrintArray(int[] data)
        {
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        static void SelectionSort(int[] data)
        {
            for (int j = 0; j < data.Length; j++)
            {
                int minIndex = j;

                for (int i = j; i < data.Length; i++)
                {
                    if (data[minIndex] > data[i])
                    {
                        minIndex = i;
                    }
                }

                int tmp = data[j];
                data[j] = data[minIndex];
                data[minIndex] = tmp;
            }


        }
        static void ValidateSubsequenceStart()
        {
            int[] sequence = { -5, 1, 13, -7, 9, 2 };
            int[] subsequence = { 3, 0, 8 };

            var isValid = ValidateSubsequence1(sequence, subsequence);

            Console.WriteLine("isValid: " + isValid);

            foreach (int i in sequence)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n\n");
            foreach (int i in subsequence)
            {
                Console.Write(i + ", ");
            }
        }

        static bool ValidateSubsequence1(int[] data, int[] subData)
        {
            int dataIndex = 0;
            int subDataIndex = 0;

            while (dataIndex < data.Length && subDataIndex < subData.Length)
            {
                if (data[dataIndex] == subData[subDataIndex])
                    subDataIndex++;

                dataIndex++;
            }



            return subDataIndex == subData.Length;
        }

        static bool ValidateSubsequence2(int[] data, int[] subData)
        {
            int subDataIndex = 0;

            foreach (int value in data)
            {
                if (subData[subDataIndex] == value)
                    subDataIndex++;

                if (subDataIndex == subData.Length)
                    return true;
            }

            return false;
        }
        static void TestarSortedSquaredArray()
        {
            Console.WriteLine("Testar SortedSquaredArray\n");

            int[] input = { -5, -2, 1, 3, 6, 8 };
            var result = SortedSquaredArray2(input);

            Console.WriteLine("Input: ");
            foreach (int i in input)
                Console.Write(i + ", ");

            Console.WriteLine("\n\nOutput: ");
            foreach (int i in result)
                Console.Write(i + ", ");

            Console.WriteLine("\n");


            Console.ReadKey();
        }
        static int[] SortedSquaredArray1(int[] input)
        {
            int[] newArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {

                newArray[i] = input[i] * input[i];

            }

            Array.Sort(newArray);

            return newArray;

        }
        static int[] SortedSquaredArray2(int[] input)
        {
            int[] res = new int[input.Length];
            int left = 0;
            int right = (input.Length - 1);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int smallerValue = input[left];
                int largerValue = input[right];

                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    res[i] = smallerValue * smallerValue;
                    left++;
                }
                else
                {
                    res[i] = largerValue * largerValue;
                    right--;
                }
            }


            return res;

        }
        static void QuickSort(int[] data, int left, int right)
        {
            int pivot = data[(left + right) / 2];
            int leftHold = left;
            int rightHold = right;

            Console.WriteLine($"pivot är: {pivot}");
            Console.WriteLine($"leftHold är: {data[leftHold]}");
            Console.WriteLine($"rightHold är: {data[rightHold]}");

            /* while(leftHold < rightHold)
            {
                    while ( (data[leftHold] < pivot) && (leftHold <= rightHold) ) 
                        leftHold++;
                    while ( (data[rightHold] > pivot) && (data[rightHold] >= leftHold) )
                        rightHold--;
            } */
        }
        static void SkrivUtTalBaknlänges(int start = 1, int stop = 20)
        {
            if (start < stop)
                return;
            Console.Write(start + " ");
            SkrivUtTal(start - 1);

        }
        static void SkrivUtTal(int start = 1, int stop = 20)
        {
            if (start > stop)
                return;
            Console.Write(start + " ");
            SkrivUtTal(start + 1);

        }

        static int KaninÖron(int antalKaniner)
        {
            int KaninÖron =
            antalKaniner * 2;

            return KaninÖron;
        }

        static int Factorial(int n)
        {
            // Basfall: Fakulteten av 0 är 1
            if (n == 0)
            {
                return 1;
            }
            // Rekursivt fall: Fakulteten av n är n multiplicerat med fakulteten av (n-1)
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static int LucasNummer(int n)
        {
          if (n == 0)
              return 2;
          if (n == 1)
              return 1;

        
            return LucasNummer(n - 1) + LucasNummer(n -2);
        }

        
    }
}