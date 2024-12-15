using OpenAIUtility;
using System.Runtime.InteropServices;

namespace formulaGpt
{
    public interface IModelControls
    { }

    [ComVisible(true)]
    [ComDefaultInterface(typeof(IModelControls))]
    public partial class ModelControls : UserControl, IModelControls
    {
        public ModelControls()
        {
            InitializeComponent();
        }

        private void ModelControls_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Local");
            cmbType.Items.Add("OpenAI");

            cmbModels.Items.Add("gpt-4o");
            cmbModels.Items.Add("gpt-4o-mini");
        }

        private void trkBarTemp_Scroll(object sender, EventArgs e)
        {
            int scale = trkBarTemp.Value;
            float temperature = (float)scale / 100;
            txtTempValue.Text = temperature.ToString();
        }

        private void trkBarFreqPen_Scroll(object sender, EventArgs e)
        {
            int scale = trkBarFreqPen.Value;
            float FreqPen = (float)scale / 100;
            txtFreqPen.Text = FreqPen.ToString();
        }

        private void trackBarTopP_Scroll(object sender, EventArgs e)
        {
            int scale = trackBarTopP.Value;
            float TopP = (float)scale / 100;
            txtToPp.Text = TopP.ToString();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            btnAsk.ForeColor = Color.Gray;
            btnAsk.Enabled = false;
            TaskPaneManager.DeleteCTPResults();

            int temp = trkBarTemp.Value;
            float temperature = (float)temp / 100;

            int freq = trkBarFreqPen.Value;
            float FreqPen = (float)freq / 100;

            int top_p = trackBarTopP.Value;
            float TopP = (float)top_p / 100;

            (List<(string, string)>, List<string>) answer = FunctionAssistant.GetAnswer(txtQuestion.Text.ToString().Trim(), cmbModels.Text,
                txtAPIKey.Text.ToString().Trim(), temperature, FreqPen, TopP);
            ResultStore.Result = answer;

            TaskPaneManager.ShowCTPResults();

            btnAsk.ForeColor = Color.White;
            btnAsk.Enabled = true;
        }

        private void trkBarTemp_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ToolTipTitle = "Temperature Settings";
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.IsBalloon = false;

            toolTip.Show("Use temperature values as follows:\n" +
                         "- For Excel-related tasks requiring precise outputs like formulas, VBA code, DAX expressions, or Power Query M scripts, set temperature to 0.0–0.3 \n" +
                         " to ensure accuracy and determinism.\n",
                         trkBarTemp);
        }

        private void trkBarFreqPen_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ToolTipTitle = "Frequency Penalty Settings";
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.IsBalloon = false;

            toolTip.Show("Use frequency penalty values as follows:\n" +
                         "- For structured responses like formulas, code snippets, and expressions, set frequency penalty to 0.0 to avoid penalizing repetition of essential terms. \n" +
                         "- For longer outputs with explanations or comments, set frequency penalty to 0.1–0.2 to reduce redundancy.\n",
                         trkBarFreqPen);
        }

        private void trackBarTopP_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ToolTipTitle = "Nucleus Sampling Settings";
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.IsBalloon = false;

            toolTip.Show("Use Nucleus Sampling values as follows:\n" +
                         "- For deterministic and highly accurate tasks, set top_p to 1.0 to allow the model to consider all possible high-probability outputs. \n" +
                         "- For tasks where slightly diverse or alternative valid approaches are acceptable, set top_p to 0.8–0.9.\n",
                         trackBarTopP);
        }

        //private void trkBarFreqPen_Scroll(object sender, EventArgs e)
        //{
        //    int scale = trkBarFreqPen.Value;
        //    float FreqPen = (float)scale / 100;
        //    txtFreqPen.Text = FreqPen.ToString();
        //}
    }
}