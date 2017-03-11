using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Library
{
    public class Contest
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
        public bool WinVotes(int entryvote)
        {
            if (maxVote == entryvote)
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