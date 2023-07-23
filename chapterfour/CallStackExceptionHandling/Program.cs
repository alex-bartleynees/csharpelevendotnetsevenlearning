using CallStackExceptionHandlingLib;
using static System.Console;

WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");

    try
    {
        Calculator.Gamma();
    }
    catch (IOException)
    {
        throw new InvalidOperationException(
            message: "Calculation had invalid values. See inner exception for why."
        );
    }
}

