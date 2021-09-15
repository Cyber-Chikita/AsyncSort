using System;
using System.Windows.Forms;

namespace AsyncSorts.Sorters
{
    class BubbleSorter : Sorter
    {
        public BubbleSorter(int itemCount) : base(itemCount)
        {
        }

        public BubbleSorter(int itemCount, Random randomizer) : base(itemCount, randomizer)
        {
        }

        public BubbleSorter(int itemCount, ListBox listBox) : base(itemCount, listBox)
        {
        }

        public BubbleSorter(int itemCount, Random randomizer, ListBox listBox) : base(itemCount, randomizer, listBox)
        {
        }

        public override void Sort()
        {
            for (int i = 0; i < itemCount; i++)
            {
                for (int j = 0; j < itemCount - i - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        int tmp = items[j];
                        items[j] = items[j+1];
                        items[j+1] = tmp;

                    }
                }
            }
            base.Sort();
        }
    }
}

