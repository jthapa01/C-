using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipleDI
{
    class UpdateUserRecords : IUpdateUserRecords
    {
        public void DoSomeUpdates()
        {
            Console.WriteLine("Updating records...");
        }
    }
}
