using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPart2
{
    internal class BubbleSort
    {
        private int arraySize;
        private int[] array;
        private Graphics graphics;
        private int pointer;
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
                for (int j = 0; j < arraySize - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }

            time.Stop();

            PrintArray("Bubble-Sorted Array", array);

            return time.ElapsedMilliseconds.ToString();
        }

        private void Swap(int index, int nextIndex)
        {
            pointer = array[index];
            array[index] = array[index + 1];
            array[index + 1] = pointer;
            DrawHistogram(index, array[index]);
            DrawHistogram(nextIndex, array[nextIndex]);
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
