using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSorts.Sorters
{
    class InsertSorter : Sorter
    {
        public InsertSorter(int itemCount) : base(itemCount)
        {
        }

        public InsertSorter(int itemCount, Random randomizer) : base(itemCount, randomizer)
        {
        }

        public InsertSorter(int itemCount, ListBox listBox) : base(itemCount, listBox)
        {
        }

        public InsertSorter(int itemCount, Random randomizer, ListBox listBox) : base(itemCount, randomizer, listBox)
        {
        }

        public override void Sort()
        {
            for (int i = 1; i < itemCount; i++)
            {
                int nowItem = items[i];
                int index = i;
                while (index > 0 && nowItem < items[index-1])
                {
                    items[index] = items[index - 1];
                    items[index - 1] = nowItem;
                    index--;
                }
            }
            base.Sort();
        }
    }
}
