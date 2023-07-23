namespace Packt.Shared;
public class Person
{
    public string? Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public event EventHandler? Shout;

    public int AngerLevel;

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            if (Shout is not null)
            {
                Shout(this, EventArgs.Empty);
            }
        }
    }
}
