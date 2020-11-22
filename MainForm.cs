using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ListViewRepro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //listView.ListViewItemSorter = new ListViewItemSorter();

            listView.BeginUpdate();

            for (int i = 0; i < 50; i++)
            {
                AddFruit();
            }

            listView.EndUpdate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listView.BeginUpdate();

            for (int i = 0; i < 50; i++)
            {
                AddFruit();
            }

            listView.EndUpdate();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            listView.BeginUpdate();

            for (int i = 0; i < 50; i++)
            {
                AddFruit();
            }

            listView.EndUpdate();
        }

        Random random = new Random();

        void AddFruit()
        {
            var fruits = new string[]
            {
                "apple",
                "pear",
                "raspberry",
                "blueberry",
                "strawberry",
                "watermelon",
                "lemon",
                "banana",
                "orange",
                "plum",
                "cherry",
                "peach",
                "pineapple",
                "grape",
                "kiwi",
                "coconut",
                "mango",
                "grapefruit",
                "apricot"
            };

            var item = new ListViewItem();

            item.Text = fruits[random.Next(0, fruits.Length)];

            var key = $"{item.Text}{random.Next()}";

            listView.SmallImageList.Images.Add(key, this.Icon);
            item.ImageKey = key;

            listView.Items.Add(item);
        }
    }
}
