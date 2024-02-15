using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    public class GraphicsCard // chang tp public so it can be intergrated with computer class
    {
        public enum Brand { Nvidia, AMD, Intel }
        Brand _graphicsCardBrand;

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand = graphicsCardBrand;
        }

        public override string ToString()
        {
            return _graphicsCardBrand.ToString();
        }

    }
}
