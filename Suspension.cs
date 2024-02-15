using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    public class Suspension
    {
        public float FrontBalance { get; set; }
        public float RearBalance { get; set; }
        public float Springiness { get; set; }

        public Suspension(float frontBalance, float rearBalance, float springiness)
        {
            FrontBalance = frontBalance;
            RearBalance = rearBalance;
            Springiness = springiness;
        }

        

    }
}
