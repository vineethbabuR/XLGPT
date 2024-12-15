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

            rtbResult.Clear();

            var output = ResultStore.Result;

            DisplayResponse(output);
        }

        public void UpdateFormulaTextBox(string text)
        {
            // FormulaResultsCTP.ShowCTP();
        }

        private void DisplayResponse((List<(string explanation, string output)> steps, List<string> finalAnswer) response)
        {
            rtbResult.Clear();

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

            rtbResult.AppendText("Steps:\r\n");
            foreach (var step in response.steps)
            {
                var cleanedExplanation = CleanText(step.explanation);
                var cleanedOutput = CleanText(step.output);

                rtbResult.AppendText($"- Explanation: {cleanedExplanation}\r\n");
                if (!string.IsNullOrWhiteSpace(cleanedOutput))
                {
                    rtbResult.AppendText($"  Output: {cleanedOutput}\r\n");
                }
                rtbResult.AppendText("\r\n");
            }

            rtbResult.AppendText("⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬⏬\r\n");

            rtbResult.AppendText("Final Answer:\r\n");
            
            foreach (var answer in response.finalAnswer)
            {
                var cleanedAnswer = CleanText(answer);
                rtbResult.SelectionColor = System.Drawing.Color.Blue;
                rtbResult.AppendText(cleanedAnswer + "\r\n");
            }
            rtbResult.SelectionColor = System.Drawing.Color.Black;
        }
    }
}