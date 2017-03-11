using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Generic_Library;
using System.Xml.Linq;

namespace Generic_Library
{
    public class Voter : UserDecorator
    {
        private int vote { get; set; }
        public string entry { get; set; }
        public Voter(User user):base(user)
        {

        }

        public Voter()
        { }

      
       


        public override string Display()
        {
            return base.Display();
        }
    }
   
}