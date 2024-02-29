using System.Diagnostics;

namespace WinformsBasic.UserControls
{
    public partial class SumCalculatorControl : UserControl
    {
        private enum CalculatedOption { ForLoop, WhileLoop, LINQ, Formula }
        private CalculatedOption calculatedOption = CalculatedOption.ForLoop;
        private long executionTimeInMilisecond = 0;
        private long endNumberValue = 0;
        private string newLine = Environment.NewLine;

        public SumCalculatorControl()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            endNumberValue = (long)Math.Round(endNumberInput.Value);
            txtResult.Text = string.Empty;
            txtResult.Text += GenerateStartMessage();
            txtResult.Text += GenerateLoopTypeMessage(calculatedOption);
            txtResult.Text += $"{newLine}{CalculateSumFromOneTo(endNumberValue)}{newLine}{newLine}";
            txtResult.Text += GenerateExecutionTimeMessage();
        }

        private long CalculateSumFromOneTo(long endNumber)
        {
            switch (calculatedOption)
            {
                case CalculatedOption.ForLoop: return CalculateTimeExecutionOf(CalculateWithForLoop, endNumber);
                case CalculatedOption.WhileLoop: return CalculateTimeExecutionOf(CalculateWithWhileLoop, endNumber);
                case CalculatedOption.LINQ: return CalculateWithLinq(endNumber);
                case CalculatedOption.Formula: return CalculateTimeExecutionOf(CalculateWithFormula, endNumber);
                default: return CalculateTimeExecutionOf(CalculateWithForLoop, endNumber);
            }
        }

        private long CalculateTimeExecutionOf(Func<long, long> calculationMethod, long endNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            long sum = calculationMethod(endNumber);

            stopWatch.Stop();
            executionTimeInMilisecond = stopWatch.ElapsedMilliseconds;
            return sum;
        }

        private long CalculateWithForLoop(long endNumber)
        {
            long sum = 0;

            for (int i = 1; i <= endNumber; i++)
            {
                sum += i;
            }

            return sum;

        }

        private long CalculateWithWhileLoop(long endNumber)
        {
            int index = 1;
            long sum = 0;

            while (index <= endNumber)
            {
                sum += index;
                index++;
            }

            return sum;
        }

        private long CalculateWithLinq(long endNumber)
        {
            List<long> numberList = new List<long>();

            for (int i = 1; i <= endNumber; i++)
            {
                numberList.Add(i);
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            long sum = numberList.Sum();

            stopWatch.Stop();
            executionTimeInMilisecond = stopWatch.ElapsedMilliseconds;
            return sum;
        }

        private long CalculateWithFormula(long endNumber)
        {
            return endNumber * (endNumber + 1) / 2;
        }

        private string GenerateStartMessage()
        {
            return $"Program starts calculating sum of first {endNumberValue} numbers! {newLine}";
        }

        private string GenerateLoopTypeMessage(CalculatedOption loopType)
        {
            string loopTypeName = "";

            switch (loopType)
            {
                case CalculatedOption.ForLoop: { loopTypeName = "For loop"; break; }
                case CalculatedOption.WhileLoop: { loopTypeName = "While loop"; break; }
                case CalculatedOption.LINQ: { loopTypeName = "LINQ"; break; }
                case CalculatedOption.Formula: { loopTypeName = "Formula"; break; }

            }

            return $"Option: {loopTypeName} {newLine}";
        }

        private string GenerateExecutionTimeMessage()
        {
            return $"Execution time: {executionTimeInMilisecond} ms";
        }

        private void RadioButtonUsingLinq_Click(object sender, EventArgs e)
        {
            calculatedOption = CalculatedOption.LINQ;
        }

        private void RadioButtonWhileLoopType_Click(object sender, EventArgs e)
        {
            calculatedOption = CalculatedOption.WhileLoop;
        }

        private void RadioButtonFormula_Click(object sender, EventArgs e)
        {
            calculatedOption = CalculatedOption.Formula;
        }

        private void RadioButtonForLoopType_Click(object sender, EventArgs e)
        {
            calculatedOption = CalculatedOption.ForLoop;
        }
    }
}
