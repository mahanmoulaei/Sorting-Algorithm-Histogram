using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPart2
{
    internal class SelectionSort
    {
        private int arraySize;
        private int[] array;
        private Graphics graphics;
        Brush WhiteBrush = new SolidBrush(Color.White);
        Brush GreenBrush = new SolidBrush(Color.Green);

        public string Sort(int[] arr, Graphics g)
        {
            array = arr;
            graphics = g;
            arraySize = arr.Length;

            var time = new System.Diagnostics.Stopwatch();

            time.Start();

            for (int i = 0; i < arraySize - 1; i++)
            {
                int indexWithSmallestValue = i;
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (arr[j] < arr[indexWithSmallestValue])
                    {
                        indexWithSmallestValue = j;
                    }                      
                }
                Swap(i, indexWithSmallestValue);
            }

            time.Stop();

            PrintArray("Selection-Sorted Array", array);

            return time.ElapsedMilliseconds.ToString();
        }

        private void Swap(int index, int indexWithSmallestValue)
        {
            int min = array[indexWithSmallestValue];
            array[indexWithSmallestValue] = array[index];
            array[index] = min;
            DrawHistogram(index, array[min]);
            DrawHistogram(min, array[min]);
        }

        private void DrawHistogram(int position, int height)
        {
            graphics.FillRectangle(WhiteBrush, position, 0, 1, arraySize);
            graphics.FillRectangle(GreenBrush, position, arraySize - array[position], 1, arraySize);
        }

        private void PrintArray(string str, int[] array)
        {
            Console.WriteLine("\n### " + str + " ################################################################# " + str + " ################################################################# " + str + " ################################################################# " + str + " ################################################################# ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n### " + str + " ################################################################# " + str + " ################################################################# " + str + " ################################################################# " + str + " ################################################################# ");
        }
    }
}
