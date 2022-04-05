
using System;
using System.Collections.Generic;

namespace Day18Person
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hero Mo = new Hero("Monday", "Week", "Mo", 11, 1111, HeroType.Hero, "Good swimmer, fast runner, strong body", 99);
            Hero Tu = new Hero("Tuesday", "Week", "Tu", 12, 2222, HeroType.Hero, "Good climber, fearless, jumps high", 98);
            Hero We = new Hero("Wednesday", "Week", "We", 13, 3333, HeroType.Hero, "Flies high, fast, furious", 97);
            Hero Th = new Hero("Thursday", "Week", "Th", 14, 4444, HeroType.Hero, "Knows everything, does everything, can code", 96);
            Hero Fr = new Hero("Friday", "Week", "Fr", 15, 5555, HeroType.Hero, "Good swimmer, fast runner, strong body", 95);
            Hero Sa = new Hero("Saturday", "Week", "Sa", 16, 6666, HeroType.Hero, "Good swimmer, fast runner, strong body", 94);
            Hero Su = new Hero("Sunday", "Week", "Su", 17, 7777, HeroType.Hero, "Good swimmer, fast runner, strong body", 93);


            List<Hero> listOfHeroes = new List<Hero>();
            listOfHeroes.Add(Mo);
            listOfHeroes.Add(Tu);
            listOfHeroes.Add(We);
            listOfHeroes.Add(Th);
            listOfHeroes.Add(Fr);
            listOfHeroes.Add(Sa);
            listOfHeroes.Add(Su);

            District Gotalandas = new District("Skovde", "Tibro", 1010, listOfHeroes);
            District Varmland = new District("Hjo", "Linkoping", 1213, listOfHeroes);

            Villain Jan = new Villain("January", "Month", "Jan", 19, 8989, VillainType.Villain, "Cold, White, Freezing", 65);
            Villain Feb = new Villain("February", "Month", "Feb", 29, 7878, VillainType.Villain, "Red, Inlove, Hot", 56);
            Villain Mar = new Villain("March", "Month", "Mar", 39, 6767, VillainType.Villain, "Green, nice, friendly", 65);
        }
    }
}