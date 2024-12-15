using ExcelDna.Integration.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenAIUtility;

namespace formulaGpt
{
    public interface IModelControls { }

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

        private void btnAsk_Click(object sender, EventArgs e)
        {
            btnAsk.ForeColor = Color.Gray;
            btnAsk.Enabled = false;
            TaskPaneManager.DeleteCTPResults();

            int scale = trkBarTemp.Value;
            float temperature = (float)scale / 100;

            List<string> answer = FunctionAssistant.GetAnswer(txtQuestion.Text.ToString().Trim(), cmbModels.Text,
                txtAPIKey.Text.ToString().Trim(), temperature);
            ResultStore.Result = answer;           

            TaskPaneManager.ShowCTPResults();

            btnAsk.ForeColor = Color.White;
            btnAsk.Enabled = true;

        }
    }

    
}
