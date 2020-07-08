using System;
using System.Collections.Generic;
using System.Text;

namespace P08CarSalesman
{
    public class Car
    {
        private string model;
        private string engine;
        private int weight;
        private string color;

        public Car(string model, string engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = default;
            this.Color = "n/a";
        }

        public Car(string model, string engine, int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = "n/a";
        }

        public Car(string model, string engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
            this.Weight = default;
        }

        public Car(string model, string engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
