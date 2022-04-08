using MyLibrary;
using Xunit;

namespace MyLibrary.UnitTests;

public class StringCalculatorTests
{
    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber()
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add("0");

        Assert.Equal(0, actual);
    }

    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        // Arrange
        var stringCalculator = new StringCalculator();

        // Act
        var actual = stringCalculator.Add("");

        // Assert
        Assert.Equal(0, actual);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsSumOfNumbers()
    {
        var stringCalculator = CreateDefaultStringCalculator();

        var actual = stringCalculator.Add("0,1");

        Assert.Equal(1, actual);
    }

    [Theory]
    [InlineData("0,0,0", 0)]
    [InlineData("0,1,2", 3)]
    [InlineData("1,2,3", 6)]
    public void Add_MultipleNumbers_ReturnsSumOfNumbers(string input, int expected)
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    void Add_MaximumSumResult_ThrowsOverflowException()
    {
        var stringCalculator = new StringCalculator();
        const string MAXIMUM_RESULT = "1001";

        Action actual = () => stringCalculator.Add(MAXIMUM_RESULT);

        Assert.Throws<OverflowException>(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("a")]
    public void Add_InputNullOrAlphabetic_ThrowsArgumentException(string input)
    {
        var stringCalculator = new StringCalculator();

        Action actual = () => stringCalculator.Add(input);

        Assert.Throws<ArgumentException>(actual);
    }

    private StringCalculator CreateDefaultStringCalculator() => new StringCalculator();
}
