using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSorts.Sorters
{
    class MergeSorter : Sorter
    {
        public MergeSorter(int itemCount) : base(itemCount)
        {
        }

        public MergeSorter(int itemCount, Random randomizer) : base(itemCount, randomizer)
        {
        }

        public MergeSorter(int itemCount, ListBox listBox) : base(itemCount, listBox)
        {
        }

        public MergeSorter(int itemCount, Random randomizer, ListBox listBox) : base(itemCount, randomizer, listBox)
        {
        }

        public override void Sort()
        {
            MergeSort();
            base.Sort();
        }

        void Merge(int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (items[left] < items[right])
                {
                    tempArray[index] = items[left];
                    left++;
                }
                else
                {
                    tempArray[index] = items[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = items[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = items[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                items[lowIndex + i] = tempArray[i];
            }
        }

        int[] MergeSort(int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(lowIndex, middleIndex);
                MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }

            return items;
        }

        int[] MergeSort()
        {
            return MergeSort(0, itemCount-1);
        }
    }
}
