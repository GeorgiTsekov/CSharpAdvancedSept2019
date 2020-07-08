using System;

namespace P07Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personFullName = personInfo[0] + " " + personInfo[1];
            string personAddress = personInfo[2];
            string personTown = string.Empty;
            for (int i = 3; i < personInfo.Length; i++)
            {
                personTown += personInfo[i];
                if (i + 1 < personInfo.Length)
                {
                    personTown += " ";
                }
            }          
            Tuple<string, string, string> personTuple = new Tuple<string, string, string>(personFullName, personAddress, personTown);

            string[] personBeerInfo = Console.ReadLine()
                .Split();
            string personBeerName = personBeerInfo[0];
            int personBeerLiters = int.Parse(personBeerInfo[1]);
            string personBeerDrunkOrNot = personBeerInfo[2];
            bool drunkOrNot = false;
            if (personBeerDrunkOrNot == "drunk")
            {
                drunkOrNot = true;
            }
            Tuple<string, int, bool> personBeerTuple = new Tuple<string, int, bool>(personBeerName, personBeerLiters, drunkOrNot);

            string[] numbersInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = numbersInfo[0];
            double accoundBalance = double.Parse(numbersInfo[1]);
            string bankName = numbersInfo[2];
            Tuple<string, double, string> numberTuple = new Tuple<string, double, string>(name, accoundBalance, bankName);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numberTuple.GetInfo());
        }
    }
}
