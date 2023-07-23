namespace PrimeFactorsTests;
using PrimeFactorsLib;

public class UnitTest1
{
    [Fact]
    public void PrimeFactors_ShouldReturnStringShowingPrimeFactors()
    {
        // Arrange
        int number = 30;
        string expected = "2 x 3 x 5";

        // Act
        string actual = PrimeFactorsLib.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactors_ShouldReturnStringShowingPrimeFactors2()
    {
        // Arrange
        int number = 60;
        string expected = "2 x 2 x 3 x 5";

        // Act
        string actual = PrimeFactorsLib.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactors_ShouldReturnStringShowingPrimeFactors3()
    {
        // Arrange
        int number = 24;
        string expected = "2 x 2 x 2 x 3";

        // Act
        string actual = PrimeFactorsLib.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactors_ShouldReturnStringShowingPrimeFactors4()
    {
        // Arrange
        int number = 1001;
        string expected = "7 x 11 x 13";

        // Act
        string actual = PrimeFactorsLib.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }
}