using System.Windows.Forms;
using Calculator;
using Xunit;

public class CalculatorEngineTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var tb1 = new TextBox { Text = "5" };
        var tb2 = new TextBox { Text = "7" };
        var resultTb = new TextBox();
        var combo = new ComboBox();
        combo.Items.Add("+");
        combo.SelectedItem = "+";

        // Act
        CalculatorEngine.Calculate(tb1, tb2, combo, resultTb);

        // Assert
        Assert.Equal("12", resultTb.Text);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var tb1 = new TextBox { Text = "10" };
        var tb2 = new TextBox { Text = "3" };
        var resultTb = new TextBox();
        var combo = new ComboBox();
        combo.Items.Add("-");
        combo.SelectedItem = "-";

        // Act
        CalculatorEngine.Calculate(tb1, tb2, combo, resultTb);

        // Assert
        Assert.Equal("7", resultTb.Text);
    }
}
