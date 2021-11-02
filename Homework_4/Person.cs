using System;

namespace Homework_4
{
   public class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public Person()
        {
            name = "Geralt";
            birthYear = new DateTime(2000, 12, 12);
        }
        public Person(string _Name, int _BirthYear)
        {
            name = _Name;
            birthYear = new DateTime(_BirthYear, 12, 12);
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Enter person name:");
            name = Console.ReadLine();
            Console.Write("Enter the year of birth: ");
            birthYear = new DateTime(Convert.ToInt32(Console.ReadLine()), 12, 12);
        }
        public void ChangeName(string _Name)
        {
            name = _Name;
        }

        public override string ToString()
        {
            return "Name: " + Name + ".\nAge: " + Age();
        }

        public void Output()
        {
            Console.WriteLine(ToString());
            Console.WriteLine(" ");
        }
        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
