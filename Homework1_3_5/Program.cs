using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] array = new int[arrayLength];
            Random random = new Random();
            int randomNumberMin = 0;
            int randomNumberMax = 9;
            int maxIteration=0;
            int iteration = 1;
            int maxIterationIndexMin=0;
            int maxIterationIndexMax = 0;

            for (int arrayIndex=0; arrayIndex<array.Length; arrayIndex++)
            {
                array[arrayIndex]=random.Next(randomNumberMin, randomNumberMax+1);
            }

            for (int arrayIndex = 0; arrayIndex < array.Length-1; arrayIndex++)
            {
                if (array[arrayIndex]== array[arrayIndex+1])
                {
                    iteration++;

                    if (iteration> maxIteration)
                    {
                        maxIteration=iteration;
                        maxIterationIndexMin = arrayIndex - iteration + 1 + 1;
                    }
                }
                else
                {
                    iteration = 1;
                }
            }

            Console.Write("В массиве {");

            for (int arrayIndex = 0; arrayIndex < array.Length-1; arrayIndex++)
            {
                Console.Write(array[arrayIndex] + ",");
            }

            Console.Write(array[array.Length - 1] + "}");
            Console.Write(" число " + array[maxIterationIndexMin] + " повторяется большее число раз (" + maxIteration + " раз) в подмассиве {");
            maxIterationIndexMax = maxIterationIndexMin + maxIteration;

            for (int arrayIndex = maxIterationIndexMin; arrayIndex < maxIterationIndexMax-1; arrayIndex++)
            {
                Console.Write(array[arrayIndex] + ",");
            }

            Console.Write(array[maxIterationIndexMax - 1] + "}");
        }
    }
}