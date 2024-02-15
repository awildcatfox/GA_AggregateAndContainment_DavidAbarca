using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    public class Computer
    {
        private GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard;
        }

        public GraphicsCard GraphicsCard
        {
            get { return _graphicsCard; }
        }
    }
}