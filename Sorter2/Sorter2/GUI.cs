using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter2
{
    public partial class GUI : Form
    {
        private int MinValue;
        private int MaxValue;
        long timer = 0;
        string SortingMethod = "";
        static Random r = new Random();
        public GUI()
        {
            InitializeComponent();
            CreateSorts();
        }

        private void CreateSorts()
        {
            List<Sorts> sorts = new List<Sorts>();
            sorts.Add(new Sorts(0, "Bubble Sort") {});
            sorts[0].sortEvent += BubbleSort;
            sorts.Add(new Sorts(1, "Introspective Sort"));
            sorts.Add(new Sorts(2, "Insertion Sort"));

            foreach (var item in sorts)
            {
                CBoxSorts.Items.Add(item);
            }
            CBoxSorts.SelectedIndex = 0;
        }

        private void CreateTXT(int[] SortedArr)
        {
            string path = @"c:\SortedArrays\" + SortingMethod + SortedArr.Length + ".txt";
            SortedArr.Reverse();
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Array sorted using the " + SortingMethod);
                sw.WriteLine("Time to sort array: " + timer + " ms");
                sw.WriteLine("The length of the array is: " + SortedArr.Length);
                for (int i = 0; i < SortedArr.Length; i++)
                {
                    sw.WriteLine("[" + i + "] " + SortedArr[i]);
                }
            }
            try {
                System.Diagnostics.Process.Start(path);
            }
            catch(Exception ex)
            {
                throw new Exception(""+ex);
            }
        }

        private static int[] CreateArray(long ArrayLength)
        {
            int[] MyArray = new int[ArrayLength];
            for (long i = 0; i < ArrayLength; i++)
            {
                MyArray[i] = r.Next();
            }

            return MyArray;

        }
        #region Sorting algorithms
        private int[] InsertionSort(int[] ArrayToSort)
        {
            Stopwatch SW = Stopwatch.StartNew();
            SortingMethod = "Insertion sort";
            int x;
            int j;
            for (int i = 0; i < ArrayToSort.Length; i++)
            {
                x = ArrayToSort[i];
                j = i;
                while(j > 0 && ArrayToSort[j-1] > x)
                {
                    ArrayToSort[j] = ArrayToSort[j - 1];
                    j = j - 1;
                }
                ArrayToSort[j] = x;
            }
            SW.Stop();
            timer = SW.ElapsedMilliseconds;
            return ArrayToSort;
        }
        private int[] IntrospectiveSort(int[] ArrayToSort)
        {
            SortingMethod = "Introspective sort";
            Stopwatch SW = Stopwatch.StartNew();
            Array.Sort(ArrayToSort);
            SW.Stop();
            timer = SW.ElapsedMilliseconds;
            return ArrayToSort;
        }

        private int[] BubbleSort(int[] unsortedarr)
        {
            Stopwatch SW = Stopwatch.StartNew();
            SortingMethod = "Bubble sort";
            bool notDone = false;
            int j;
            while (!notDone)
            {
                notDone = true;
                for (int i = 0; i < (unsortedarr.Length - 1); i++)
                {
                    if (unsortedarr[i] < unsortedarr[i + 1])
                    {
                        j = unsortedarr[i];
                        unsortedarr[i] = unsortedarr[i + 1];
                        unsortedarr[i + 1] = unsortedarr[i];
                        notDone = false;
                    }
                }
            }
            SW.Stop();
            timer = SW.ElapsedMilliseconds;
            return unsortedarr;
        }

        #endregion

        private void Sortbtn_Click(object sender, EventArgs e)
        {
            //long ArrayLength = Int64.Parse(Lengthtxt.Text);
            //if (RadioBubble.Checked)
            //    CreateTXT(BubbleSort(CreateArray(ArrayLength)));
            //else if (RadioInsertion.Checked)
            //    CreateTXT(InsertionSort(CreateArray(ArrayLength)));
            //else if (RadioIntro.Checked)
            //    CreateTXT(IntrospectiveSort(CreateArray(ArrayLength)));
        }
    }
}
