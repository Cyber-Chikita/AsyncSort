using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncSorts
{

    delegate void OnTerminate();

    class Sorter
    {
        public int itemCount;
        public int[] items;
        public OnTerminate onTerminate;
        public Random randomizer;
        public ListBox listBox;

        public Sorter(int itemCount)
        {
            this.itemCount = itemCount;
            fillArray();
        }

        public Sorter(int itemCount, ListBox listBox)
        {
            this.itemCount = itemCount;
            this.listBox = listBox;
            fillArray();
            fillListBox();
        }

        public Sorter(int itemCount, Random randomizer)
        {
            this.itemCount = itemCount;
            this.randomizer = randomizer;
            fillArray();
        }

        public Sorter(int itemCount, Random randomizer, ListBox listBox)
        {
            this.itemCount = itemCount;
            this.randomizer = randomizer;
            this.listBox = listBox;
            fillArray();
            fillListBox();
        }

        private void fillArray()
        {
            if (randomizer == null)
                randomizer = new Random();
            items = new int[itemCount];
            for (int i = 0; i < itemCount; i++)
            {

                if (i > 1)
                {
                    int index = randomizer.Next(0, i);
                    items[i] = items[index];
                    items[index] = i + 1;
                }
                else
                    items[i] = i + 1;
            }
        }

        protected void fillListBox()
        {
            if (listBox != null)
            {
                listBox.Invoke(new Action(() => listBox.Items.Clear()));
                foreach (int item in items)
                {
                    listBox.Invoke(new Action(() => listBox.Items.Add(item)));
                }
            }
        }

        public virtual void Sort()
        {
            fillListBox();
        }
    }
}
