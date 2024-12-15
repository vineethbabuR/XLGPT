using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace formulaGpt
{
    [ComVisible(true)]
    public class Ribbon : ExcelRibbon
    {
        public override string GetCustomUI(string RibbonID)
        {
            return @"
                <customUI xmlns='http://schemas.microsoft.com/office/2009/07/customui'>
			<ribbon>
				<tabs>
					<tab id='sqladdin' label='XL GPT'>
						<group id='modelGroup' label='Model Controls'>
                            <button id='showModel' imageMso='MacroPlay' size='large' label='Dispaly Controls' onAction='ShowControlsPane'/>
						</group>
                       <group id='resultGroup' label='Result Control'>
                            <button id='showResult' imageMso='AnimationTriggerAddMenu' size='large' label='Add To VBE' onAction='AddToVBE'/>
						</group>
					</tab>
				</tabs>
			</ribbon>
		</customUI>
			";
        }

        public void ShowControlsPane(IRibbonControl control)
        {
            TaskPaneManager.ShowCTPControls();
        }

        public void AddToVBE(IRibbonControl control)
        {
            string vbaCode = Clipboard.GetText();

            if (string.IsNullOrWhiteSpace(vbaCode))
            {
                MessageBox.Show("Clipboard is empty or does not contain text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var xlApp = (Excel.Application)ExcelDnaUtil.Application;
            var controlBook = xlApp.ActiveWorkbook;
            var vbaProject = controlBook.VBProject;

            var thisWorkbookCodeModule = vbaProject.VBComponents.Item("ThisWorkbook").CodeModule;
            int numOfLines = thisWorkbookCodeModule.CountOfLines;
            thisWorkbookCodeModule.DeleteLines(1, numOfLines);
            thisWorkbookCodeModule.AddFromString(vbaCode);
            MessageBox.Show("Selection added to ThisWorkbook object");
        }
    }
}