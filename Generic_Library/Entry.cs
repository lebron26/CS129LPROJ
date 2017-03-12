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
        public string entryuser;
        public int vote = 0;
        public Entry(User user):base(user)
        {

        }

        public bool StatusEntry(string entry,string user)
        {
           
            if (entry== user)
                return true;
            else
                return false;
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