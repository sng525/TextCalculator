using TextCalculator;
namespace TextCalculatorTests;

public class TextCalculatorTests
{
    Calculator calculator = new Calculator();

    [Theory]
    [InlineData("", "0")]
    [InlineData("     ", "0")]
    public void EmptyString_ReturnStringZero(string value, string expected)
    {
        string actual = calculator.Add(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("1", "1")]
    [InlineData("5,7", "12")]
    [InlineData("1.1,3.4", "4.5")]
    [InlineData("1,2.4,3.6", "7")]
    [InlineData("2.2,3.3,4.4,5.5,6.6", "22")]
    public void ManyNormalNumbers_ReturnStringSum(string value, string expected)
    {
        string actual = calculator.Add(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("1,3,")]
    [InlineData("1,3,2.2,4,")]
    public void MissingNumberInLastPosition_ThrowsInvalidOperationException(string value)
    {
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(value));
        Assert.Equal("Missing number in the input.", exception.Message);
    }

    [Theory]
    [InlineData(",2,3.3")]
    [InlineData(",5.5,2.8")]
    public void MissingNumberInFirstPosition_ThrowsInvalidOperationException(string value)
    {
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add(value));
        Assert.Equal("Missing number in the input.", exception.Message);
    }

    [Fact]
    public void NegativeNumbers_ThrowsInvalidOperationException()
    {
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add("-1,2"));
        Assert.Equal("Negative not allowed: -1", exception.Message);
    }

    [Fact]
    public void MultipleNegativeNumbers_ThrowsInvalidOperationException()
    {
        var exception = Assert.Throws<InvalidOperationException>(() => calculator.Add("7,-4,1,-5"));
        Assert.Equal("Negative not allowed: -4, -5", exception.Message);
    }
}
