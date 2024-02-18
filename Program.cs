using System;
using Xunit;

public class ArraySumCalculator
{
    public int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}

public class ArraySumCalculatorTests
{
    [Fact]
    public void Sum_Returns_CorrectSum()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        ArraySumCalculator calculator = new ArraySumCalculator();

        // Act
        int result = calculator.Sum(numbers);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Sum_Returns_Zero_ForEmptyArray()
    {
        // Arrange
        int[] numbers = { };
        ArraySumCalculator calculator = new ArraySumCalculator();

        // Act
        int result = calculator.Sum(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_Returns_CorrectSum_ForNegativeNumbers()
    {
        // Arrange
        int[] numbers = { -1, -2, -3, -4, -5 };
        ArraySumCalculator calculator = new ArraySumCalculator();

        // Act
        int result = calculator.Sum(numbers);

        // Assert
        Assert.Equal(-15, result);
    }
}
