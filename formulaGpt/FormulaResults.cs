using OpenAIUtility;
using System.Runtime.InteropServices;

namespace formulaGpt
{
    public interface IFormulaControls
    { }

    [ComVisible(true)]
    [ComDefaultInterface(typeof(IFormulaControls))]
    public partial class FormulaResults : UserControl, IFormulaControls
    {
        public FormulaResults()
        {
            InitializeComponent();

            txtFormula.Clear();

            var output = ResultStore.Result;

            DisplayResponse(output);
        }

        public void UpdateFormulaTextBox(string text)
        {
            // FormulaResultsCTP.ShowCTP();
        }

        private void DisplayResponse((List<(string explanation, string output)> steps, List<string> finalAnswer) response)
        {
            txtFormula.Clear();

            string CleanText(string text)
            {
                if (string.IsNullOrWhiteSpace(text)) return string.Empty;

                return text.Replace("\\r", Environment.NewLine)
                           .Replace("\\n", Environment.NewLine)
                           .Replace("\\", Environment.NewLine)
                           .Replace("\n", Environment.NewLine)
                           .Replace("\r", Environment.NewLine)
                           .Trim();
            }

            txtFormula.AppendText("Steps:\r\n");
            foreach (var step in response.steps)
            {
                var cleanedExplanation = CleanText(step.explanation);
                var cleanedOutput = CleanText(step.output);

                txtFormula.AppendText($"- Explanation: {cleanedExplanation}\r\n");
                if (!string.IsNullOrWhiteSpace(cleanedOutput))
                {
                    txtFormula.AppendText($"  Output: {cleanedOutput}\r\n");
                }
                txtFormula.AppendText("\r\n");
            }

            txtFormula.AppendText("⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬\r\n");

            txtFormula.AppendText("Final Answer:\r\n");
            foreach (var answer in response.finalAnswer)
            {
                var cleanedAnswer = CleanText(answer);
                txtFormula.AppendText(cleanedAnswer + "\r\n");
            }
        }
    }
}