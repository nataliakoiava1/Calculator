using projectsBeginer;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly CalculatorEngine engine = new CalculatorEngine();
        private readonly HistoryManager history = new HistoryManager();
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool isNewEntry = true;
        

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            txtDisplay.TabStop = false;
            txtDisplay.ReadOnly = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                string digit = e.KeyCode.ToString().Replace("D", "").Replace("NumPad", "");
                SimulateDigitClick(digit);
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.Add || (e.Shift && e.KeyCode == Keys.Oemplus))
            {
                SimulateOperatorClick("+");
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                SimulateOperatorClick("-");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
            {
                SimulateOperatorClick("*");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                SimulateOperatorClick("/");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                ExecuteSquareRoot();
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.Enter || (!e.Shift && e.KeyCode == Keys.Oemplus))
            {
                btnEquals.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                btnClear.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                SimulateDigitClick(".");
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                ExecuteBackspace();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F9 || e.KeyCode == Keys.F)
            {
                ToggleSign();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma)
            {
                SimulateDigitClick(".");
                e.Handled = true;
            }


        }

        private void ToggleSign()
        {
            if (!double.TryParse(txtDisplay.Text, out double number) || number == 0)
            {
                return;
            }

            number *= -1;
            txtDisplay.Text = number.ToString();
        }

        private void ExecuteBackspace()
        {
            if (isNewEntry || !double.TryParse(txtDisplay.Text, out _))
            {
                return;
            }


            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

                if (txtDisplay.Text == "-")
                {
                    txtDisplay.Text = "0";
                    isNewEntry = true;
                }
            }
            else
            {
                txtDisplay.Text = "0";
                isNewEntry = true;
            }
        }
        private void ExecuteSquareRoot()
        {
            if (!double.TryParse(txtDisplay.Text, out double number)) return;

            if (number < 0)
            {
                txtDisplay.Text = "Invalid Input";
                isNewEntry = true;
                return;
            }

            try
            {
                double result = engine.Calculate("sqrt", number, 0);
                txtDisplay.Text = result.ToString();

                history.AddHistory(number, "√", 0, result, lstHistory);

                firstNumber = result;
                isNewEntry = true;
            }
            catch (Exception)
            {
                txtDisplay.Text = "Error";
                isNewEntry = true;
            }
        }

        private void SimulateDigitClick(string digit)
        {
            if (digit == "." && txtDisplay.Text.Contains("."))
            {
                return;
            }
            if (txtDisplay.Text == "0" || isNewEntry || !double.TryParse(txtDisplay.Text, out _))
            {
                txtDisplay.Text = (digit == ".") ? "0." : digit;
                isNewEntry = false;
            }
            else
            {
                txtDisplay.Text += digit;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                if (keyData == Keys.Enter)
                {
                    btnEquals.PerformClick();
                }

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SimulateOperatorClick(string op)
        {

            if (double.TryParse(txtDisplay.Text, out double result))
            {
                firstNumber = result;
                currentOperator = op;
                isNewEntry = true;
            }
        }
        private void Digital_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                SimulateDigitClick(button.Text);
            }
            this.ActiveControl = null;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                SimulateOperatorClick(button.Text);
            }
            this.ActiveControl = null;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ExecuteSquareRoot();
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            ToggleSign();
            this.ActiveControl = null;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            ExecuteBackspace();
            this.ActiveControl = null;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperator)) return;

            if (!double.TryParse(txtDisplay.Text, out double secondNumber)) return;

            try
            {
                double result = engine.Calculate(currentOperator, firstNumber, secondNumber);
                txtDisplay.Text = result.ToString();

                history.AddHistory(firstNumber, currentOperator, secondNumber, result, lstHistory);

                firstNumber = result;
                isNewEntry = true;
                currentOperator = "";
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Error: Division by 0";
                isNewEntry = true;
            }
        }
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            history.ClearHistory(lstHistory);

            this.ActiveControl = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            currentOperator = "";
            isNewEntry = true;
            this.ActiveControl = null;
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstHistory.SelectedItems != null)
            {
                string selectedEntry = lstHistory.SelectedItems.ToString();
                string[] parts = selectedEntry.Split('=');

                if(parts.Length == 2)
                {
                    txtDisplay.Text = parts[1].Trim();
                }
            }
            this.ActiveControl = null;
        }



    }
}