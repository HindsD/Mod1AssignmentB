// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.IO;
using System.Collections;
public class Program {

    public static void Main(string[] args) {
        List<Talkable> zoo = new List<Talkable>();
        StreamWriter streamWriter = new StreamWriter("animals.txt", true);

        AnimalConsole animalConsole = new AnimalConsole(zoo);
        animalConsole.Create();

        zoo.Add(new Dog(true, "Bean"));
        zoo.Add(new Cat(9, "Charlie"));
        zoo.Add(new Teacher(44, "Stacy Read"));

        foreach (Talkable thing in zoo){
            printOut(thing);
        }

        void printOut(Talkable p){
            Console.WriteLine(p.GetName() + " says " + p.Talk());
            streamWriter.WriteLine(p.GetName() + " | " + p.Talk());
        }
        
        streamWriter.Close();

        string line = "";
        StreamReader streamReader = new StreamReader("animals.txt");
        while((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
