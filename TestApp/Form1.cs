using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void generation_Array(object sender, EventArgs e)
        {
            textArrayOrigin.Text = null;
            textResult.Text = null;
            var array = Enumerable.Range(1, 6).ToArray();
            var rand = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
            foreach (var numeral in array)
            textArrayOrigin.Text += " " + numeral;       
            start_Sort(array);           
        }
        private void start_Sort(int[] array)
        {  
            textIteration.Text = null;
            int count = 0;
            bool ch = true;
            while (ch & count < 3)
            {   
                ch = false;
                count = count+1;
                for (int i = 0; i < 3; i++)
                {
                    if (array[i] > array[i + 3])
                    {
                        textResult.Text = null;
                        ch = true;
                        int[] mass = new int[2];
                        mass[0] = array[i];
                        mass[1] = array[i + 1];
                        array[i] = array[i + 2];
                        array[i + 1] = array[i + 3];
                        array[i + 2] = mass[0];
                        array[i + 3] = mass[1];
                        foreach (int r in array)
                        {
                            textResult.Text += r.ToString();
                        }
                        String textIter = String.Format("{0}{1} <-> {2}{3}", array[i], array[i + 1], array[i + 2], array[i + 3]);
                        textIteration.Text += textIter + " - " + textResult.Text + "\n";
                    } 
                }
            }
            int[] mas = new int[]{1,2,3,4,5,6};
            if (array.SequenceEqual(mas))
            {
                MessageBox.Show("Массив отсортирован!");
            }
            else
            {
                textResult.Text = null;
                textResult.Text = "Массив не сортируется";           
            }
        } 
    }
}
