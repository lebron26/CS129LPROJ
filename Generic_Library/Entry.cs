using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Generic_Library;
using System.Xml.Linq;
using System.Xml;

namespace Generic_Library
{
    public class Entry : UserDecorator,ISerialize
    {
        public string entry;
        public string description;
        public string entryuser;
        public int vote = 0;
        public Entry(User user):base(user)
        {

        }

        public Entry()
        {
        }

        public void Serialize(Stream stream, object entry)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(Entry));
            serialize.Serialize(stream, entry);
            stream.Close();
            
        }
        public void AddEntry(string entry, string description, string entryuser)
        {
            this.entry = entry;
            this.description = description;
            this.entryuser = entryuser;
           // this.vote = vote;

        }
      

        public override string Display()
        {
            return base.Display();
        }

    }
}