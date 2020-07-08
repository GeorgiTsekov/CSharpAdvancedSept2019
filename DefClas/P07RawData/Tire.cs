using System;
using System.Collections.Generic;
using System.Text;

namespace P07RawData
{
    public class Tire
    {
        public Tire(
            int age1, 
            double presure1, 
            int age2, 
            double presure2, 
            int age3, 
            double presure3, 
            int age4, 
            double presure4)
        {
            this.Age1 = age1;
            this.Presure1 = presure1;
            this.Age2 = age2;
            this.Presure2 = presure2;
            this.Age3 = age3;
            this.Presure3 = presure3;
            this.Age4 = age4;
            this.Presure4 = presure4;

        }

        public int Age1 { get; set; }
        public double Presure1 { get; set; }
        public int Age2 { get; set; }
        public double Presure2 { get; set; }
        public int Age3 { get; set; }
        public double Presure3 { get; set; }
        public int Age4 { get; set; }
        public double Presure4 { get; set; }
    }
}
