using AsyncSorts.Sorters;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncSorts
{
    public partial class Form1 : Form
    {
        MergeSorter mergeSorter;
        InsertSorter insertSorter;
        BubbleSorter bubbleSorter;

        Thread mergeSorterThread;
        Thread insertSorterThread;
        Thread bubbleSorterThread;

        public Form1()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            mergeSorterThread.Start();
            insertSorterThread.Start();
            bubbleSorterThread.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mergeSorter = new MergeSorter(100, new Random(1), mergeSortListBox);
            insertSorter = new InsertSorter(100, new Random(2), insertSortListBox);
            bubbleSorter = new BubbleSorter(100, new Random(3), bubbleSortListBox);
            mergeSorterThread = new Thread(mergeSorter.Sort);
            insertSorterThread = new Thread(insertSorter.Sort);
            bubbleSorterThread = new Thread(bubbleSorter.Sort);
        }
    }
}
