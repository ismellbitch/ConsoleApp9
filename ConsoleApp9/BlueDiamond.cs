using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class BlueDiamond : Diamond
    {
        public BlueDiamond(string name, string color, double weight, int facetingQuality) : base(name, color, weight, facetingQuality)
        {

        }
        public override double GetDiamondQuality()
        {
            return base.GetDiamondQuality() + 1;
        }
    }
}
