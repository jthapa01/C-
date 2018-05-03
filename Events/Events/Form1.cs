using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.OnPropertyChanged += new EventHandler(mc_OnPropertyChanged);
            mc.Name = "Adam";
        }
        void mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The property has changed");
        }
    }
}
