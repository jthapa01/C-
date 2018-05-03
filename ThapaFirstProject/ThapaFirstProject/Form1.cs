using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThapaFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello","Mytitle");
            int number = 66;
            MessageBox.Show(number.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*List<int> Numbers = new List<int>();//List Example
            Numbers.Add(5);
            Numbers.Add(667);
            MessageBox.Show(Numbers[0].ToString());

            string[] names = { "Adam", "Bob", "Joe" };
            foreach (string sjee in names)
           
            {
                MessageBox.Show(sjee);
            }
            int i = 0;
            do
            {
                textBox1.Text += i.ToString();
                i++;
            }
            while (true);*/
            try
            {


                string[] names = new string[2];
                string s = names[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Your code is done");
            }

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        /*private void button1_MouseHover(object sender, EventArgs e)
        {
            // MessageBox.Show("Your are hovering your mouse over the button");
            string name = "Adam";
            MessageBox.Show(name);
        }*/
    }
}
