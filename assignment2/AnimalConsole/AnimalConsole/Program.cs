using AnimalConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog bowser = new Dog();
        bowser.Talk();
        bowser.Greet();
        bowser.Sing();
        bowser.Fetch("stick");
        bowser.FeedMe();
        bowser.TouchMe();

        Robin red = new Robin();
        red.Talk();
        red.Greet();
        red.Sing();

        Console.ReadLine();

    }
}