using System.Security;
using Packt.Shared;

partial class Program
{
    // a method to handle the Shout event recieved by the
    // Person class

    static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null) return;
        Person p = (Person)sender;
        if (p is null) return;
        Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }
}