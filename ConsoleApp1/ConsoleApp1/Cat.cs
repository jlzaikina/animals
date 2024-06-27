namespace ConsoleApp1;

public class Cat : Animals
{
    public void move()
    {
        Console.WriteLine("Идет");
    }

    public void eat()
    {
        Console.WriteLine("Кушает");
    }

    public void say()
    {
        Console.WriteLine("Мяу");
    }
}