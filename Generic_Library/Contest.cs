﻿using System;
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
    public class Contest:ISerialize
    {
        public string contest;
        public string description;
        public DateTime specificDate;
        public int maxVote;

        public Contest(string contest, string description, DateTime duration, int maxVote)
        {
            this.contest = contest;
            this.description = description;
            specificDate = duration;
            this.maxVote = maxVote;
        }

        public void Serialize(Stream stream, object entry)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(Contest));
            serialize.Serialize(stream, entry);
            stream.Close();

        }
        public bool WinVotes(int entryvote,int maxVote)
        {
            if (maxVote <= entryvote)
                return true;
            else
                return false;
        }

        public bool IsExpired(DateTime specificDate)
        {
            TimeSpan st = new TimeSpan(specificDate.Ticks);
            TimeSpan dt = new TimeSpan(DateTime.Now.Ticks);
            return st < dt;
        }

        public Contest()
        { }
    }
}