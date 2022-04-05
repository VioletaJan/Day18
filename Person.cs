using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Person
{
    public class Person
    { 
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public int Age { get; set; }

        public int PersonID { get; set; }


        public Person()
        {
        string Name = "Zmogus";
            string Surname = "Zmogienas";
        int Age = 11;
        int PersonID = 1234;

        }

        public Person(string Name, string Surname, int Age, int PersonID)
        {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.PersonID = PersonID;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Age: {Age}\n PersonID: {PersonID});
        }
    }
}
