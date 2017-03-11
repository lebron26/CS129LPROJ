using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Library
{
    public class Organizer:UserDecorator
    {

        public Organizer(User user):base(user)
        {

        }

        public override string Display()
        {
            return base.Display();
        }
    }
}