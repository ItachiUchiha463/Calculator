using System.Windows.Forms;
using Calculator;
using Xunit;

public class CalculatorEngineTests2
{
    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var tb1 = new TextBox { Text = "6" };
        var tb2 = new TextBox { Text = "7" };
        var resultTb = new TextBox();
        var combo = new ComboBox();
        combo.Items.Add("×");
        combo.SelectedItem = "×";

        // Act
        CalculatorEngine.Calculate(tb1, tb2, combo, resultTb);

        // Assert
        Assert.Equal("42", resultTb.Text);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var tb1 = new TextBox { Text = "20" };
        var tb2 = new TextBox { Text = "4" };
        var resultTb = new TextBox();
        var combo = new ComboBox();
        combo.Items.Add("÷");
        combo.SelectedItem = "÷";

        // Act
        CalculatorEngine.Calculate(tb1, tb2, combo, resultTb);

        // Assert
        Assert.Equal("5", resultTb.Text);
    }

    [Fact]
    public void Power_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var tb1 = new TextBox { Text = "2" };
        var tb2 = new TextBox { Text = "10" };
        var resultTb = new TextBox();
        var combo = new ComboBox();
        combo.Items.Add("^");
        combo.SelectedItem = "^";

        // Act
        CalculatorEngine.Calculate(tb1, tb2, combo, resultTb);

        // Assert
        Assert.Equal("1024", resultTb.Text);
    }
}
