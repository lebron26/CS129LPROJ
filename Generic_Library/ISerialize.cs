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
    public interface ISerialize
    {
        void Serialize(Stream stream, object entry);
    }
}