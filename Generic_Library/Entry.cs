using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Library
{
    public class Entry : UserDecorator
    {
        public string entry;
        public string description;
        public int vote = 0;
        public Entry(User user):base(user)
        {

        }

        public Entry()
        {
        }

     


        public override string Display()
        {
            return base.Display();
        }

    }
}