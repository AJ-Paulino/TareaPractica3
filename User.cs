using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPractica3
{
    public class User
    {
        public class Id
        {
            public string name { get; set; }
            public object value { get; set; }
        }
        public class Name
        {
            public string title { get; set; }
            public string first { get; set; }
            public string last { get; set; }
        }

        public class Dob
        {
            public DateTime date { get; set; }
            public int age { get; set; }
        }

        public class Picture
        {
            public string large { get; set; }
            public string medium { get; set; }
            public string thumbnail { get; set; }
        }

        public class Registered
        {
            public DateTime date { get; set; }
            public int age { get; set; }
        }
    }




}
