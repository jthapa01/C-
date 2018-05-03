using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNamespace;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*for(int i=0; i<10; i++)
            {
                if (i == 2) continue;
                textBox1.Text += i.ToString();
            }*/

            //MyClass mc = new MyClass("Thapa");//instance of a class; compiler looks for a class, if there's no constructor compiler creates a default one
            MyClass.ShowMessage(4);
           

        }
    }
}
