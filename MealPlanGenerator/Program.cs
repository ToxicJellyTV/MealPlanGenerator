using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanGenerator
{
    internal class Program
    {

        static string[] dishes = { "Frikadellen mit Kartoffelpüree und Bratensoße", "Reis mit Frühlingsrolle", "Hot Dog", "Wikinger Topf", "Baguette mit Salat", "Kartoffelsuppe", "Käse-Lauch-Suppe", "Pandas Cock", "Pizza", "Spaghetti Bolognese", "Lasagne", "Chicken Nugget's und Fritten", "Nudelauflauf", "Reis mit Hühnchen und Soße", "Bratkartoffeln mit Bohnen und Grobe Wurst", "Nudeln mit Carbonara", "Hamburger und Salat" };

        static void Main(string[] args)
        {
            Random rnd = new Random();

            var week = new List<string>();

            for (int i = 0; week.Count() < 8; i++)
            {
                int num = rnd.Next(dishes.Length);
                bool isDouble = false;

                for (int i2 = 0; i2 < week.Count();  i2++)
                {
                    if (dishes[num] == week[i2])
                    {
                        isDouble = true;
                    }
                }

                if (isDouble == false)
                {
                    week.Add(dishes[num]);
                }
            }

            Console.WriteLine(
                " Dein Essensplan für die Woche:" +
                "\n\n" +
                " Montag:      " + week[0] + "\n" +
                " Dienstag:    " + week[1] + "\n" +
                " Mittwoch:    " + week[2] + "\n" +
                " Donnerstag:  " + week[3] + "\n" +
                " Freitag:     " + week[4] + "\n" +
                " Samstag:     " + week[5] + "\n" +
                " Sonntag:     " + week[6] + "\n" +
                "\n"
            );

            Console.WriteLine(dishes.Length);

            Console.ReadKey();
        }
    }
}
