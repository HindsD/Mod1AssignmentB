public class AnimalConsole
{
  public List<Talkable> Zoo { get; set; }

  public AnimalConsole(List<Talkable> zoo)
  {
    this.Zoo = zoo;
  }

  public void Create()
  {
    Console.WriteLine("Which type of animal would you like to add to the zoo?");
    Console.WriteLine("You may choose between a Cat, Dog, or Teacher");
    var choice = Console.ReadLine();

        if (choice.ToLower() == "cat")
        {
            Console.WriteLine("What is the cat's name?");
            var name = Console.ReadLine();
            Console.WriteLine("How many mice has the cat killed?");
            var miceKilled = int.Parse(Console.ReadLine());
            this.Zoo.Add(new Cat(miceKilled, name));
        }
        else if (choice.ToLower() == "dog")
        {
            Console.WriteLine("What is the dog's name?");
            var name = Console.ReadLine();
            Console.WriteLine("Is it friendly? (Y/N)");
            var friendly = Console.ReadLine();
            if (friendly.ToLower() == "y")
            {
                this.Zoo.Add(new Dog(true, name));
            }
            else if (friendly.ToLower() == "n")
            {
                this.Zoo.Add(new Dog(false, name));
            }
            else
            {
                Console.WriteLine("Please only enter a Y or an N");
            }
        }
        else if (choice.ToLower() == "teacher")
        {
            Console.WriteLine("What is the teacher's name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are they?");
            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                this.Zoo.Add(new Teacher(age, name));
            }
            else
            {
                Console.WriteLine("That's someone that's still a student!");
            }
        }
        else
        {
            Console.WriteLine("That isn't one of the options!");
        }
  }
}