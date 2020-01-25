using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercises
{
    public class Band : IComparable
    {
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string BandMembers { get; set; }

        public override string ToString()
        {
            return string.Format($"{BandName} - {this.GetType().Name}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Band otherBand = obj as Band;
            if (otherBand != null)
                return this.BandName.CompareTo(otherBand.BandName);
            else
                throw new ArgumentException("Object is not a Band");
        }
    }
}
