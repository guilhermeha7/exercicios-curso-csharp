using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2.Entities
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

        public void AddVotes(int votes)
        {
            Votes = Votes + votes;
        }

        public override string ToString()
        {
            return Name + ": " + Votes;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Candidate))
            {
                return false;
            }
            Candidate other = (Candidate)obj;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
