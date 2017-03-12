using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Library
{
    public class UserConcrete : User
    {
        public string username { get; set; }

        public string password { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string type { get; set; }
        
        public bool status { get; set; }

        public string entry { get; set; }

        public override string Display()
        {
            return firstname + " " + lastname;
        }
    }
}