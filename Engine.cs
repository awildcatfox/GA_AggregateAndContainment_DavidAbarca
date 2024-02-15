using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    internal class Engine
    {
        //public int HP { get; set; }

        public Engine(int hp)
        {
            HP = hp;
        }

        private int hp;
        public int HP
        {
            get { return hp; }
            set
            {
                if (value >= 50)
                {
                    hp = value;
                }
                else
                {
                    throw new Exception("Invalid horsepower value");
                }


            }
        }
    }
}
