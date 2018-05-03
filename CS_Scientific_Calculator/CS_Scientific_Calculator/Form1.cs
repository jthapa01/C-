using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Scientific_Calculator
{
    public partial class Form1 : Form
    {

        Double results = 0;
        String operation = "";
        bool enter_value = false;
        Double tempConverTo=0;
        Double convertedVal = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 324;
            txtDisplay.Width = 285;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 630;
            txtDisplay.Width = 592;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 324;
            txtDisplay.Width = 285;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1077;
            txtDisplay.Width = 285;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
        private void aPFTCalcuatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.Width = 1110;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox2.Location = new Point(630, 90);
                groupBox2.Width = 445;
                groupBox2.Height = 380;
            }
        }



        private void button_Click(object sender, EventArgs e)//sender is an object, sender.Text does not compile
        {
            //enter_value = true;
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";

            //MessageBox.Show(enter_value.ToString(), "Value Entered");
            enter_value = false;
            Button num = (Button)sender;//explicit casting
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            results = 0;
            //lblShowOp.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
            results = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            txtDisplay.Focus();
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (results != 0)
            {
                button19.PerformClick();
                operation = b.Text;
                results = Double.Parse(txtDisplay.Text);
                lblShowOp.Text += txtDisplay.Text + " " + operation;
                enter_value = true;
           
            }
            else
            {
                operation = b.Text;
                results = Double.Parse(txtDisplay.Text);
                lblShowOp.Text += System.Convert.ToString(results) + " " + operation;
                enter_value = true;
                lblShowOp.Text = "";
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    
                    break;

                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Exp":
                    double expon = Double.Parse(txtDisplay.Text);
                    MessageBox.Show(expon.ToString(),"expon");
                    double ex;
                    ex = (results);
                   // MessageBox.Show(ex.ToString(), "ex");
                    //txtDisplay.Text = Math.Exp(expon*Math.Log(ex*4)).ToString();
                    txtDisplay.Text=(ex* System.Math.Pow(10, expon)).ToString();
                    break;
                default:
                    break;
            }
            operation = "";
            enter_value = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text) * (-1);
            txtDisplay.Text = results.ToString();

            //Double signChange = Double.Parse(txtDisplay.Text)*-1;
           // txtDisplay.Text = signChange.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
           // results = Double.Parse(txtDisplay.Text);
            results = 3.1415926535897932384626433832;
            txtDisplay.Text = results.ToString();
        }

        //private void button37_Click(object sender, EventArgs e)
        //{

        //}

        private void button23_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Math.Sqrt(results).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Math.Pow(results,2).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Math.Pow(results, 3).ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (results * 0.01).ToString();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (1/results).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
            lblShowOp.Text += System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Log10(results).ToString();
            //MessageBox.Show(txtDisplay.Text); 
        }

        private void button36_Click(object sender, EventArgs e)
        {
            results = Double.Parse(txtDisplay.Text);
         
            txtDisplay.Text = System.Math.Log(results).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double hyperbolicSin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Sinh(hyperbolicSin).ToString();
            //MessageBox.Show(txtDisplay.Text); 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double sinValue = Double.Parse(txtDisplay.Text);
            double angle = Math.PI * sinValue / 180.0;
            lblShowOp.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Sin(angle).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double hyperbolicCos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Cosh(hyperbolicCos).ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
                double cosValue = Double.Parse(txtDisplay.Text);
                double cosAngle = Math.PI * cosValue / 180.0;
                lblShowOp.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
                txtDisplay.Text = System.Math.Cos(cosAngle).ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double hyperbolicTan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Tanh(hyperbolicTan).ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double TanValue = Double.Parse(txtDisplay.Text);
            double TanAngle = Math.PI * TanValue / 180.0;
            lblShowOp.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Tan(TanAngle).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int decConvert = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(decConvert);
            enter_value = true;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            int decConvert = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(decConvert, 2);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int decConvert = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(decConvert, 16);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int decConvert = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(decConvert, 8);
        }

        private void button43_Click(object sender, EventArgs e)
        {

            int numFactorial = int.Parse(txtDisplay.Text);
            int result = numFactorial;
            lblShowOp.Text = System.Convert.ToString("(" + (txtDisplay.Text) +"!"+ ")");
            if (numFactorial>0)
            {
                for (int i = 1; i < numFactorial; i++)
                {
                    result = result * i;
                }
                txtDisplay.Text = result.ToString();
            }
            else if (numFactorial ==0)
            {
                result = 1;
                txtDisplay.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Entry, Enter the positive number only");
            }
            
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double cubicRoot = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("(" + "∛"+(txtDisplay.Text) + ")");
            txtDisplay.Text = System.Math.Pow(cubicRoot,(double)1/3 ).ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            double eulersNumber = 2.7182818284590452353602874713;
            results = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("(" + "e^" + (txtDisplay.Text) + ")");
            double expo = System.Math.Pow(eulersNumber, results);
            txtDisplay.Text = expo.ToString();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MenuItemList.SelectedIndex == 0)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("Square kilometer");
                ConvertFrom.Items.Add("Square meter");
                ConvertFrom.Items.Add("Square mile");
                ConvertFrom.Items.Add("Square yard");
                ConvertFrom.Items.Add("Square foot");
                ConvertFrom.Items.Add("Square inch");
                ConvertFrom.Items.Add("Square Hectare");
                ConvertFrom.Items.Add("Square Acre");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("Square kilometer");
                ConvertTo.Items.Add("Square meter");
                ConvertTo.Items.Add("Square mile");
                ConvertTo.Items.Add("Square yard");
                ConvertTo.Items.Add("Square foot");
                ConvertTo.Items.Add("Square inch");
                ConvertTo.Items.Add("Square Hectare");
                ConvertTo.Items.Add("Square Acre");
            }
            else if (MenuItemList.SelectedIndex == 6)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("Kilometer");
                ConvertFrom.Items.Add("Meter");
                ConvertFrom.Items.Add("Centimeter");
                ConvertFrom.Items.Add("Milimeter");
                ConvertFrom.Items.Add("Micrometer");
                ConvertFrom.Items.Add("Nanometer");
                ConvertFrom.Items.Add("Mile");
                ConvertFrom.Items.Add("Yard");
                ConvertFrom.Items.Add("Foot");
                ConvertFrom.Items.Add("Inch");
                ConvertFrom.Items.Add("Nautical mile");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("Kilometer");
                ConvertTo.Items.Add("Meter");
                ConvertTo.Items.Add("Centimeter");
                ConvertTo.Items.Add("Milimeter");
                ConvertTo.Items.Add("Micrometer");
                ConvertTo.Items.Add("Nanometer");
                ConvertTo.Items.Add("Mile");
                ConvertTo.Items.Add("Yard");
                ConvertTo.Items.Add("Foot");
                ConvertTo.Items.Add("Inch");
                ConvertTo.Items.Add("Nautical mile");
            }
            else if (MenuItemList.SelectedIndex == 7)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("Metric ton");
                ConvertFrom.Items.Add("Kilogram");
                ConvertFrom.Items.Add("Gram");
                ConvertFrom.Items.Add("Milligram");
                ConvertFrom.Items.Add("Microgram");
                ConvertFrom.Items.Add("Imperial ton");
                ConvertFrom.Items.Add("US ton");
                ConvertFrom.Items.Add("Stone");
                ConvertFrom.Items.Add("Pound");
                ConvertFrom.Items.Add("Ounce");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("Metric ton");
                ConvertTo.Items.Add("Kilogram");
                ConvertTo.Items.Add("Gram");
                ConvertTo.Items.Add("Milligram");
                ConvertTo.Items.Add("Microgram");
                ConvertTo.Items.Add("Imperial ton");
                ConvertTo.Items.Add("US ton");
                ConvertTo.Items.Add("Stone");
                ConvertTo.Items.Add("Pound");
                ConvertTo.Items.Add("Ounce");
            }

            else if (MenuItemList.SelectedIndex == 11)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("Celsius");
                ConvertFrom.Items.Add("Fahrenheit");
                ConvertFrom.Items.Add("Kelvin");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("Celsius");
                ConvertTo.Items.Add("Fahrenheit");
                ConvertTo.Items.Add("Kelvin");
            }
            else if (MenuItemList.SelectedIndex == 12)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("Nanosecond");
                ConvertFrom.Items.Add("Microsecond");
                ConvertFrom.Items.Add("Millisecond");
                ConvertFrom.Items.Add("Second");
                ConvertFrom.Items.Add("Minute");
                ConvertFrom.Items.Add("Hour");
                ConvertFrom.Items.Add("Day");
                ConvertFrom.Items.Add("Week");
                ConvertFrom.Items.Add("MOnth");
                ConvertFrom.Items.Add("Year");
                ConvertFrom.Items.Add("Decade");
                ConvertFrom.Items.Add("Century");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("Nanosecond");
                ConvertTo.Items.Add("Microsecond");
                ConvertTo.Items.Add("Millisecond");
                ConvertTo.Items.Add("Second");
                ConvertTo.Items.Add("Minute");
                ConvertTo.Items.Add("Hour");
                ConvertTo.Items.Add("Day");
                ConvertTo.Items.Add("Week");
                ConvertTo.Items.Add("MOnth");
                ConvertTo.Items.Add("Year");
                ConvertTo.Items.Add("Decade");
                ConvertTo.Items.Add("Century");
            }

            else if (MenuItemList.SelectedIndex == 13)
            {
                ConvertFrom.Items.Clear();
                ConvertFrom.Items.Add("US liquid gallon");
                ConvertFrom.Items.Add("US liquid quart");
                ConvertFrom.Items.Add("US liquid pint");
                ConvertFrom.Items.Add("US legal cup");
                ConvertFrom.Items.Add("US fluid ounce");
                ConvertFrom.Items.Add("US Tablespoon");
                ConvertFrom.Items.Add("US teaspoon");
                ConvertFrom.Items.Add("Cubic meter");
                ConvertFrom.Items.Add("Liter");
                ConvertFrom.Items.Add("Milliliter");
                ConvertFrom.Items.Add("Cubic foot");
                ConvertFrom.Items.Add("Cubic inch");

                ConvertTo.Items.Clear();
                ConvertTo.Items.Add("US liquid gallon");
                ConvertTo.Items.Add("US liquid quart");
                ConvertTo.Items.Add("US liquid pint");
                ConvertTo.Items.Add("US legal cup");
                ConvertTo.Items.Add("US fluid ounce");
                ConvertTo.Items.Add("US Tablespoon");
                ConvertTo.Items.Add("US teaspoon");
                ConvertTo.Items.Add("Cubic meter");
                ConvertTo.Items.Add("Liter");
                ConvertTo.Items.Add("Milliliter");
                ConvertTo.Items.Add("Cubic foot");
                ConvertTo.Items.Add("Cubic inch");
            }

            }

        private void ConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConvertFrom.SelectedIndex == 0)//Celsius
            {
                if (ConvertTo.SelectedIndex == 1)//Fahrenheit
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = (tempConverTo * 9) / 5 + 32;
                    valueConvertedTo.Text = convertedVal.ToString();

                }
                else if (ConvertTo.SelectedIndex == 2)//Kelvin
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = tempConverTo+273.15;
                    valueConvertedTo.Text = convertedVal.ToString();
                }    
            }
            else if (ConvertFrom.SelectedIndex == 1)//Fahrenheit
            {
                if (ConvertTo.SelectedIndex == 0)//Celsius
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = (tempConverTo -32)*5/9;
                    valueConvertedTo.Text = convertedVal.ToString();

                }
                else if (ConvertTo.SelectedIndex == 2)//Kelvin
                    
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = (tempConverTo +459.67)*5/9;
                    valueConvertedTo.Text = convertedVal.ToString();
                    
                }
            }
            else if (ConvertFrom.SelectedIndex == 2)//Kelvin
            {
                if (ConvertTo.SelectedIndex == 0)//Celsius
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = tempConverTo - 273.15;
                    valueConvertedTo.Text = convertedVal.ToString();

                }
                else if (ConvertTo.SelectedIndex == 1)//Fahrenheit
                  
                {
                    tempConverTo = Double.Parse(txtValToConvert.Text);
                    convertedVal = (tempConverTo- 273.15)*9/5+32;
                    valueConvertedTo.Text = convertedVal.ToString();
                }
            }
        }

        private void txtValToConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValToConvert_Click(object sender, EventArgs e)
        {


        }

        private void txtValToConvert_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& e.KeyChar != ('.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar=='.')&&((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
            if ((txtValToConvert.Text == "0") || (enter_value))
                txtValToConvert.Text = "";
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            int[] pushupscore = new int[10] { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };

           // double age=0;
            //double pushups = 0;
            //double totalPushupScore = 0;
            
            //age = double.Parse(soldierAge.Text);
            //pushups = double.Parse(totalPushups.Text);


            //if (comboBox1.SelectedIndex == 1)
            //{
            //    if (age>=17 && age <= 21)
            //    {
            //        const double maxPushups = 71.0;
            //        totalPushupScore = Math.Ceiling ((pushups / maxPushups) * 100);
            //        MessageBox.Show(totalPushupScore.ToString());
            //    }

            //    //else if (age >= 22 && age <= 26)
            //    //{
            //    //    const double maxPushups = 75.0;
            //    //    totalPushupScore = Math.Ceiling((pushups / maxPushups) * 100);
            //    //    MessageBox.Show(totalPushupScore.ToString());
                    
            //    //}

            //}
        }
    }           
}
