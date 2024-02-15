using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GA_AggregateAndContainment_DavidAbarca
{
    internal class Character
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Character(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"weight class:{Weight}\n" +
                $"Name: {Name}";
        }

    }
}
