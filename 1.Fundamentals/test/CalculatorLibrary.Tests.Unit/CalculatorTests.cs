using CalculatorLibrary;
using Xunit.Abstractions;

namespace CalculatorLibraryTests;

public class CalculatorTests
{
    // System under test
    private readonly Calculator _sut = new ();

    private readonly ITestOutputHelper _outputHelper;
    
    
    // Setup
    public CalculatorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    
    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Arrange

        // Act
        var result = _sut.Add(5, 4);
        
        // Assert
        Assert.Equal(9, result);
        
        _outputHelper.WriteLine("Hello from the Add test");
    }
    
    [Fact]
    public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Arrange

        // Act
        var result = _sut.Substract(5, 4);
        
        // Assert
        Assert.Equal(1, result);
        
        _outputHelper.WriteLine("Hello from the Subtract test");
    }
}