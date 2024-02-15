using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_DavidAbarca
{
    internal class GoKart
    {
        public string Make { get; set; }
        public string Model { get; set; }
        // private Engine engine;

        public GoKart(string make, string model)
        {
            Make = make;
            Model = model;
            engine = new Engine(250); // Engine is contained and not swappable
        }
        public Character Driver { get; set; }
        

        public GoKart(Character driver)
        {
            Driver = driver;
            engine = new Engine(250 - driver.Weight / 2); // Engine power influenced by driver's weight
        }

        public override string ToString()
        {
            return $"Character: {Driver.Name} - Weight: {Driver.Weight}";
        }
        
        private Engine engine = new Engine(250);
        public Engine Engine
        {
            get { return engine; }
        }
        public void TweakEngine(int newHP)
        {
            engine.HP = newHP;
        }

        public void SwapEngine(Engine newEngine)
        {
            engine = newEngine;
        }

        public void SwapEngine(int hp)
        {
            engine = new Engine(hp);
        }



    }
}
