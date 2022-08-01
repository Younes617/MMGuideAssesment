
using System;

namespace MMGuideAssesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalList listOfAnimals = new AnimalList();
            DoubleList listOfNumbers = new DoubleList();

            listOfNumbers.DoSomething(2.5);
            listOfAnimals.DoSomething(new Animal());

            Console.WriteLine("----------------------------");

            GenericList listOfAnimals2 = new GenericList();
            GenericList listOfNumbers2 = new GenericList();

            listOfNumbers2.DoSomething(2.5);
            listOfAnimals2.DoSomething(new Animal());
        }
    }
}
