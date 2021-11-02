using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];

            Console.WriteLine("Enter name and birth year");

            for (int i = 0; i < 6; i++)
            {
                persons[i] = new Person();

                Console.WriteLine($"Person {i + 1}");
                persons[i].Input();
                Console.WriteLine();
            }

            Console.WriteLine("Info :");

            foreach (Person p in persons)
            {
                p.Output();
            }

            Console.WriteLine("Updated information:\n");

            foreach (Person p in persons)
            {

                if (p.Age() < 16)
                {
                    p.ChangeName("Very Young\n");
                }

                p.Output();
                Console.WriteLine("\nPeople with same names:\n");

            Dictionary<string, int> some_names =
                new Dictionary<string, int>();

            foreach (Person pers in persons)
            {
                string name = pers.Name;

                if (some_names.ContainsKey(name))
                {
                    some_names[name]++;
                }
                else
                {
                    some_names.Add(name, 1);
                }
            }

            foreach (Person pers in persons)
            {
                if (some_names[pers.Name] >= 2)
                {
                    pers.Output();
                }
            }
            }
        }
    }
}
