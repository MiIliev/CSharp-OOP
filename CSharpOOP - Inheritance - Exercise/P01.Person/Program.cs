using P01.Person;

public class StartUp
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(new Child(name, age));
    }
}