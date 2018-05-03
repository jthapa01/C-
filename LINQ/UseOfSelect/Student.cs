using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseOfSelect
{
    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        public ContactInfo GetContactInfo(SelectSample app, int id)
        {
            ContactInfo cInfo =
                (from ci in app.contactList
                 where ci.ID == id
                 select ci)
                 .FirstOrDefault();
            return cInfo;
        }

        public override string ToString()
        {
            return First + " " + Last + " "+ ID;
        }
    }
}
