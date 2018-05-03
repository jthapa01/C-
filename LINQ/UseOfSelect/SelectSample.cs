using System;
using System.Collections.Generic;
using System.Text;

namespace UseOfSelect
{
    class SelectSample
    {
        public List<Student> students = new List<Student>
        {
            new Student{First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int>{97,92,81,60 } },
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int>() {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int>() {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int>() {97, 89, 85, 82}},
        };

        public List<ContactInfo> contactList = new List<ContactInfo>
        {
            new ContactInfo {ID=111, Email="SvetlanO@Contoso.com", Phone="206-555-0108"},
            new ContactInfo {ID=112, Email="ClaireO@Contoso.com", Phone="206-555-0298"},
            new ContactInfo {ID=113, Email="SvenMort@Contoso.com", Phone="206-555-1130"},
            new ContactInfo {ID=114, Email="CesarGar@Contoso.com", Phone="206-555-0521"}
        };
    }
}
