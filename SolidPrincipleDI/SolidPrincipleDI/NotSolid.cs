using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipleDI
{
    class NotSolid
    {   //This class violates 'S', 'O', 'L' and 'D'
        //'S' because it does two seemingly unrelated things, emailing and updating user records
        public NotSolid()
        {

        }

        public void DoSomething()
        {
            //this will work, however it 'traps' this dependency in this method
            //there is no way to swap this for testing
            //Violates 'O', 'D' and 'L'
            //'L' and 'D' because we depend on a concrete class
            //'O' because there is no way to change the email dependency
            var emaildependency = new EmailDependency();
            emaildependency.sendMail();
        }


        public void DoSomethingElse()
        {
            //also trapping a dependency here
            //seems to be doing something unrelated to sending email
            var update = new UpdateUserRecords();
            update.DoSomeUpdates();
        }


        public void DoSomethingElseAgain()
        {
            //also trapping a dependency here
            //seems to be doing something unrelated to sending emails
            var update = new UpdateUserRecords();
            update.DoSomeUpdates();

        }
    }
}
