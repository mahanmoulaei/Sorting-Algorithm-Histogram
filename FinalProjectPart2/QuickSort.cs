using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPart2
{
    internal class QuickSort
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

            quickSort(array, 0, arraySize - 1);

            time.Stop();

            PrintArray("Selection-Sorted Array", array);

            return time.ElapsedMilliseconds.ToString();
        }

        private void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = partition(arr, low, high);

                quickSort(arr, low, partitionIndex - 1);

                quickSort(arr, partitionIndex + 1, high);
            }
        }

        private int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1; 

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, high);
            return (i + 1);
        }

        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            DrawHistogram(i, array[i]);
            DrawHistogram(j, array[j]);
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
