namespace PrimeFactorsLib;
public class PrimeFactorsLib
{
    public static string PrimeFactors(int number)
    {
        string result = "";
        int smallestPrimeFactor = 2;

        while (number > 1)
        {
            if (number % smallestPrimeFactor == 0)
            {
                result += $"{smallestPrimeFactor} x ";
                number /= smallestPrimeFactor;
            }
            else
            {
                smallestPrimeFactor++;
            }
        }

        return result[..^3];
    }
}
