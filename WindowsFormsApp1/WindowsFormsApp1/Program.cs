﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Button button = new Button { Text = "Click me" };
            button.Click += (src, e) =>Log("Click", src, e);
            button.KeyPress += (src, e) => Log("KeyPress", src, e);
            button.MouseClick += (src, e) => Log("MouseClick", src, e);
            Form form = new Form { AutoSize = true, Controls = { button } };
            Application.Run(form);

        }
        static void Log(string title, object sender, EventArgs e)
        {


            Console.WriteLine("Event: {0}", title);
            Console.WriteLine(" Sender: {0}", sender);
            Console.WriteLine(" Arguments: {0}", e.GetType());
            foreach (PropertyDescriptor prop in
            TypeDescriptor.GetProperties(e))
            {
                string name = prop.DisplayName;
                object value = prop.GetValue(e);
                Console.WriteLine(" {0}={1}", name, value);
            }




        }

    }
}
