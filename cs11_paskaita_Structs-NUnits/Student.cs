using System;
using System.Collections.Generic;
using System.Linq;

namespace cs11_paskaita_Structs_NUnits
{
    internal struct Student
	{
		public string Name; // <-- by default čia yra ( get; set ) pagal nutylėjimą
		public string LastName;
        public List<int> Grades;

        public Student(string name, string lastName, List<int> grades) // <-- konstrukroius
        {
            Name = name;
            LastName = lastName;
            Grades = grades;
        }
        public double GetAverage()
        {
            return Grades.Average();
        }
    }
    public struct MokinysX
    {
        public string Name;
        public string LastName;
        public DateTime CoueseStart;
        public DateTime CoueseEnd;

        public MokinysX(string name, string lastName, DateTime coueseStart, DateTime coueseEnd)
        {
            Name = name;
            LastName = lastName;
            CoueseStart = coueseStart;
            CoueseEnd = coueseEnd;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Students name: {Name}");
            Console.WriteLine($"Students last name: {LastName}");
            Console.WriteLine($"Coure start: {CoueseStart}");
            Console.WriteLine($"Course end: {CoueseEnd}");
        }
    }


}

