using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipleDI
{
    public class SolidEmailer:ISolidEmailer
    {
        private readonly IEmailDependency _emailDependency;

        //We take our dependences via the constructor and they are of an abstracted type 
        //swapping which emailer we use is simple
        public SolidEmailer(IEmailDependency emailDependency)
        {
            _emailDependency = emailDependency;
        }

        //we limit this class to only handle emailing
        public void SendMail()
        {
            _emailDependency.sendMail();
        }

    }
}
