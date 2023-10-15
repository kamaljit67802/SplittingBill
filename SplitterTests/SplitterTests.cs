using MySplitterLibrary;
using System;
using Xunit;

public class MySplitterTests
{
    [Fact]
    public void SplitAmount_EqualAmountAndPeople_ReturnsAmountPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 100;
        int numberOfPeople = 5;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void SplitAmount_ZeroAmount_ReturnsZeroPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 0;
        int numberOfPeople = 4;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void SplitAmount_DecimalAmountAndPeople_ReturnsCorrectPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 123.45M;
        int numberOfPeople = 3;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(41.15M, result);
    }

    [Fact]
    public void SplitAmount_NegativePeople_ThrowsArgumentException()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 100;
        int numberOfPeople = -2;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => splitter.SplitAmount(amount, numberOfPeople));
    }

    [Fact]
    public void SplitAmount_DecimalAmountAndZeroPeople_ThrowsArgumentException()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 123.45M;
        int numberOfPeople = 0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => splitter.SplitAmount(amount, numberOfPeople));
    }
    
    [Fact]
    public void SplitAmount_NegativeAmountAndPositivePeople_ReturnsZeroPerPerson()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = -100;
        int numberOfPeople = 5;

        // Act
        decimal result = splitter.SplitAmount(amount, numberOfPeople);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void SplitAmount_DecimalAmountAndNegativePeople_ThrowsArgumentException()
    {
        // Arrange
        var splitter = new Splitter();
        decimal amount = 123.45M;
        int numberOfPeople = -2;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => splitter.SplitAmount(amount, numberOfPeople));
    }

    // Add more tests as needed to cover your specific scenarios.
}
