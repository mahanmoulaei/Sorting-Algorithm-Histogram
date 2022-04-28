using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPart2
{
    public partial class Form1 : Form
    {
        const string BUBBLE_SORTING = "Bubble Sorting";
        const string SELECTION_SORTING = "Selection Sorting";
        const string QUICK_SORTING = "Quick Sorting";
        private static int arraySize = 100;
        private int[] bubbleSortArray = new int[arraySize];
        private int[] selectionSortArray = new int[arraySize];
        private int[] quickSortArray = new int[arraySize];
        private Graphics bubbleSortGraphics, selectionSortGraphics, quickSortGraphics;
        Random random = new Random();
        BubbleSort bubbleSort;
        SelectionSort selectionSort;
        QuickSort quickSort;
        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            panelBubbleSortVisualizer.Size = new Size(arraySize, arraySize);
            panelSelectionSortVisualizer.Size = new Size(arraySize, arraySize);
            panelQuickSortVisualizer.Size = new Size(arraySize, arraySize);
            labelBubbleSortTime.Text = "";
            labelSelectionSortTime.Text = "";
            labelQuickSortTime.Text = "";
            buttonStart.Enabled = false;
        }

        private void buttonGenerateArray_Click(object sender, EventArgs e)
        {
            bubbleSortGraphics = panelBubbleSortVisualizer.CreateGraphics();
            bubbleSortGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, panelBubbleSortVisualizer.Width, panelBubbleSortVisualizer.Height);

            selectionSortGraphics = panelSelectionSortVisualizer.CreateGraphics();
            selectionSortGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, panelSelectionSortVisualizer.Width, panelSelectionSortVisualizer.Height);

            quickSortGraphics = panelQuickSortVisualizer.CreateGraphics();
            quickSortGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, panelQuickSortVisualizer.Width, panelQuickSortVisualizer.Height);

            for (int i = 0; i < arraySize; i++)
            {
                bubbleSortArray[i] = selectionSortArray[i] = quickSortArray[i] = random.Next(0, arraySize);

                bubbleSortGraphics.FillRectangle(new SolidBrush(Color.Black), i, panelBubbleSortVisualizer.Height - bubbleSortArray[i], 1, panelBubbleSortVisualizer.Height);

                selectionSortGraphics.FillRectangle(new SolidBrush(Color.Black), i, panelSelectionSortVisualizer.Height - selectionSortArray[i], 1, panelSelectionSortVisualizer.Height);

                quickSortGraphics.FillRectangle(new SolidBrush(Color.Black), i, panelQuickSortVisualizer.Height - quickSortArray[i], 1, panelQuickSortVisualizer.Height);
            }

            labelBubbleSortTime.Text = "";
            labelSelectionSortTime.Text = "";
            labelQuickSortTime.Text = "";

            buttonStart.Enabled = true;
        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonGenerateArray.Enabled = false;

            PrintArray("Array", bubbleSortArray);

            bubbleSort = new BubbleSort();
            ShowTime(bubbleSort.Sort(bubbleSortArray, bubbleSortGraphics), labelBubbleSortTime);

            selectionSort = new SelectionSort();
            ShowTime(selectionSort.Sort(selectionSortArray, selectionSortGraphics), labelSelectionSortTime);

            quickSort = new QuickSort();
            ShowTime(quickSort.Sort(quickSortArray, quickSortGraphics), labelQuickSortTime);

            buttonGenerateArray.Enabled = true;
        }

        private void ShowTime(string time, Label label)
        {
            label.Text = time + " milliseconds";
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
