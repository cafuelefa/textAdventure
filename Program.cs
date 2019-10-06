using System;
using System.Collections.Generic;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiate variables
            String input = "";
            String arch = "";
            //parser
            Scripter narrator = new Scripter();

        StartGame:
            narrator.NewLine("Welcome to the magical world of Text Adventure!");
            narrator.NewLine("What is your name?");
            centerText(narrator.script);
            narrator.Clear();
            input = Console.ReadLine();
            String name = input;

            bool failedClass = false;
            narrator.NewLine( name + ", huh... Sure. That'll work.");
            narrator.NewLine("And how do you fancy yourself? A Brute? A Wizard? A Bowman, perhaps?");
            FailedClass:
                if (failedClass)
                {
                narrator.NewLine("Try again.");
                }
            centerText(narrator.script);
            narrator.Clear();
            input = Console.ReadLine().ToLower();
            if ( input == "brute" || input == "clairvoyant" || input == "bowman" )
            {
                failedClass = false;
                arch = input;
            }
            else
            {
                failedClass = true;
                goto FailedClass;
            }

            Player me = new Player(name, arch);

            narrator.NewLine("And so, the journey of " + me.name + " the " + me.archetype + " begins...");
            centerText(narrator.script);
            narrator.Clear();
        }
        private static void centerText(List<String> text)
        {
            foreach (String element in text)
            {
                Console.Write(new string(' ', (Console.WindowWidth - element.Length) / 2));
                Console.WriteLine(element);
            }
        }
        public class Scripter
        {
            public List<String> script = new List<String>();
            public  void NewLine( String line )
            {
                script.Add(line);
            }
            public void Clear()
            {
                script.Clear();
            }
        }
    }
}
