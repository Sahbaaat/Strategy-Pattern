using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Sorter s;
        public  int[] array1;
        public  int[] array2;
        public Random rndm;
        public  Stopwatch sw = new Stopwatch();
        BubbleSort bs = new BubbleSort();
        InsertionSort ss = new InsertionSort();
        
        public Form1()
        {
            InitializeComponent();
            
        }
        public void startstopwatch()
        {
            sw = new Stopwatch();
            sw.Start();
        }
        private void createarray_Click(object sender, EventArgs e)
        {
            rndm = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            array1 = new int[n];
            array2 = new int[n];
            for (int i = 0; i < n; i++)
                array1[i] = rndm.Next(0, 100);
            richTextBox1.Clear();
            for (int j = 0; j < n; j++)
            {
                array2[j] = array1[j];
                richTextBox1.Text += array1[j].ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           s = new Sorter(bs);
           sw.Start();
            s.sort(array1);
            sw.Stop();
            
            richTextBox2.Clear();
            for (int i = 0; i < array1.Length; i++)
                richTextBox2.Text += array1[i].ToString() + Environment.NewLine;
            textBox2.Text = (sw.ElapsedMilliseconds*1000).ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = new Sorter(ss);
            sw.Start(); 
            s.sort(array2);
            sw.Stop();
            richTextBox2.Clear();
           for (int i = 0; i < array2.Length; i++)
                richTextBox2.Text += array2[i].ToString() + Environment.NewLine;
            textBox2.Text = (sw.ElapsedMilliseconds*1000).ToString();
        }


    }
}
