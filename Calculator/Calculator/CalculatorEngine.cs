using System;
using System.Windows.Forms;

namespace Calculator;

public class CalculatorEngine
{
   public static void UpdateOperationSign(ComboBox comboBox, Label labelSign)
        {
            if (comboBox.SelectedItem is string op)
                labelSign.Text = op;
        }

        public static void Calculate(
            TextBox textBoxFirst,
            TextBox textBoxSecond,
            ComboBox comboBoxOperations,
            TextBox textBoxResult)
        {
            try
            {
                if (!double.TryParse(textBoxFirst.Text, out double num1))
                {
                    MessageBox.Show("Перше число введено некоректно!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxResult.Text = "";
                    return;
                }
                
                if (!double.TryParse(textBoxSecond.Text, out double num2))
                {
                    MessageBox.Show("Друге число введено некоректно!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxResult.Text = "";
                    return;
                }

                string op = comboBoxOperations.SelectedItem?.ToString() ?? "+";

                double result = op switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "×" or "*" => num1 * num2,
                    "÷" or "/" when num2 == 0 => throw new DivideByZeroException("Ділення на нуль заборонено!"),
                    "÷" or "/" => num1 / num2,
                    "^" => Math.Pow(num1, num2),
                    _ => double.NaN
                };

                if (double.IsNaN(result) || double.IsInfinity(result))
                    textBoxResult.Text = "Помилка";
                else
                    textBoxResult.Text = result.ToString("G10");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "Помилка";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невідома помилка: " + ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "Помилка";
            }
        }
}