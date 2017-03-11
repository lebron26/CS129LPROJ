using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Library
{
    public class UserDecorator:User
    {
        User user = null;

        protected UserDecorator(User user)
        {
            this.user = user;
        }
        protected UserDecorator()
        {
           
        }

        public override string Display()
        {
            return user.Display();
        }
    }
}