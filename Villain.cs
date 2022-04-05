using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Person
{

    internal class Villain
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public int Age { get; set; }

        public int VillainID { get; set; }

        public Villain Type { get; set; }

        public string VillainCrimes { get; private set; }

        public double CrimeTime { get; set; }

        public object VillainType { get; private set; }

        //public List<string> superHeroPowerList { get; set; }


        public Villain()
        {
            Name = "Tom";
            Surname = "Bonch";
            Nickname = "BadBoy";
            Age = 66;
            VillainID = 7777;
            Type = VillainType.Villain;
            VillainCrimes = "Eats all the cookies, screams, drives fast";
            CrimeTime = 5;
        }
        public Villain(string Name, string Surname, string Nickname, int Age, int VillainID, Villain.Type Villain, string VillainCrimes, double DeedTime) //List<string> superHeroPowerList
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.Age = Age;
            this.VillainID = VillainID;
            this.Type = Villain;
            this.VillainCrimes = VillainCrimes;
            //this.superHeroPowerList = superHeroPowerList;
            this.CrimeTime = DeedTime;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Nickname: {Nickname}\n Age: {Age}\n HeroID: {VillainID}\n Type: {Type}\n Crimes: {VillainCrimes}\n Crimetime: {CrimeTime}\n");
        }
        public int CalculatedLevel()
        {
            int level = 0;
            if (CrimeTime < 20)
            {
                level = 1;
            }
            if (CrimeTime >= 20 && CrimeTime <= 40)
            {
                level = 2;
            }
            if (CrimeTime > 40)
            {
                level = 3;
            }

            return level;
        }
        public void PrintFinancialInformation()
        { }

    }
}