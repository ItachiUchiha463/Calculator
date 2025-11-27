namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformCalculation()
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
                    "÷" or "/" when num2 == 0 => throw new DivideByZeroException(),
                    "÷" or "/" => num1 / num2,
                    "^" => Math.Pow(num1, num2),
                    _ => double.NaN
                };

                if (double.IsNaN(result) || double.IsInfinity(result))
                    textBoxResult.Text = "Помилка";
                else
                    textBoxResult.Text = result.ToString("G10");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ділення на нуль заборонено!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "Помилка";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася невідома помилка: " + ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "Помилка";
            }
        }

        private void UpdateOperationSign()
        {
            if (comboBoxOperations.SelectedItem is string selectedOp)
            {
                labelSign.Text = selectedOp;
            }
        }
    }
}