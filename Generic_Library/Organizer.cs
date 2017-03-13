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
    public class Organizer:UserDecorator
    {

        public Organizer(User user):base(user)
        {

        }
        public void Serialize(Stream stream, object entry)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(UserConcrete));
            serialize.Serialize(stream, entry);
            stream.Close();

        }
        public override string Display()
        {
            return base.Display();
        }
    }
}