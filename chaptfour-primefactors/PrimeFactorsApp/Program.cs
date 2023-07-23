using static System.Console;
using static PrimeFactorsLib.PrimeFactorsLib;

WriteLine("Enter a number to discover its prime factors:");
int number = int.Parse(ReadLine() ?? "0");

WriteLine(PrimeFactors(number));