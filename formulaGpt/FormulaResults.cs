using OpenAIUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulaGpt
{
    public interface IFormulaControls { }

    [ComVisible(true)]
    [ComDefaultInterface(typeof(IFormulaControls))]
    public partial class FormulaResults : UserControl, IFormulaControls
    {

        
        public FormulaResults()
        {
            InitializeComponent();

            txtFormula.Clear();

            

            var output = ResultStore.Result;

           
                foreach (var txt in output)
                {
                    txtFormula.Text += txt.ToString()
                            .Replace("\\r", Environment.NewLine)
                            .Replace("\\", Environment.NewLine)
                            .Replace("\n", Environment.NewLine)
                            .Replace("\r", Environment.NewLine)
                            .Trim()
                            + Environment.NewLine
                            + Environment.NewLine
                            + "'-------------------------- End Of Line -------------------------- "
                            + Environment.NewLine
                            + Environment.NewLine;
                }
        
           
            

           // MessageBox.Show(output.GetType().ToString());
          //  string txt = string.Empty;

           


           // txtFormula.Text = txt;

        }
    

        public void UpdateFormulaTextBox(string text)
        {
           // FormulaResultsCTP.ShowCTP();
           
        }
    }
}
