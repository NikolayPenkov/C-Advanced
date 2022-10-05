using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          //Person firstPerson = new Person();
          //  //firstPerson.Age = 18;
          //  //firstPerson.Name = "Gosho";
          //  Console.WriteLine(firstPerson.Name);
          //  Console.WriteLine(firstPerson.Age);
          Family people = new Family();
          int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                List<string> newPeople = Console.ReadLine().Split(" ").ToList();
                Person person = new Person(newPeople[0], int.Parse(newPeople[1]));
                people.AddMember(person);
            }
            Person oldestPerson = people.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
