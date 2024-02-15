using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    internal class Car
    {
        private string v1;
        private string v2;

        public string Make { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Suspension Suspension { get; }

        public Car(string make, string model, Engine engine, Suspension suspension)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Suspension = suspension;
        }

        public Car(string v1, string v2, Engine engine)
        {
            this.v1 = v1;
            this.v2 = v2;
            Engine = engine;
        }

        public override string ToString()
        {
            return $"{Make} {Model}, HP: {Engine.HP}\nFront Balance: {Suspension.FrontBalance}\nRear Balance: {Suspension.RearBalance}";
        }
    }
}
