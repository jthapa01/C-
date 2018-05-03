using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipleDI
{
    public class EmailDependency: IEmailDependency
    {
        public void sendMail()
        {
            Console.WriteLine("Sending an email...");
        }
    }
}
