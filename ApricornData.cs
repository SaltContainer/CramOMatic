using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramOMatic
{
    class ApricornData
    {
        
        public string ApricornColor { get; set; }
        public List<ApricornBallRate> PossibleBalls { get; set; }

        public ApricornData(string color)
        {
            ApricornColor = color;
            PossibleBalls = new List<ApricornBallRate>();
        }

        public void AddBall(ApricornBallRate ball)
        {
            PossibleBalls.Add(ball);
        }

        public override string ToString()
        {
            return ApricornColor;
        }
    }
}
