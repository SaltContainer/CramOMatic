using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class ApricornBallRate
    {
        public double Rate { get; set; }
        public string Name { get; set; }

        public ApricornBallRate(double rate, string name)
        {
            Rate = rate;
            Name = name;
        }

        public ApricornBallRate CloneQuarter()
        {
            return new ApricornBallRate(Rate * 0.25, Name);
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareRateDesc(ApricornBallRate value1, ApricornBallRate value2)
        {
            return value2.Rate.CompareTo(value1.Rate);
        }
    }
}
