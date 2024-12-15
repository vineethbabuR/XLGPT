using ExcelDna.Integration.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace formulaGpt
{
    [ComVisible(true)]
    public class Ribbon: ExcelRibbon
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
                      <!--  <group id='resultGroup' label='Result Control'>
                            <button id='showResult' imageMso='AnimationTriggerAddMenu' size='large' label='Show Results' onAction='ShowResultsPane'/>
						</group> -->
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

        public void ShowResultsPane(IRibbonControl control)
        {
            TaskPaneManager.ShowCTPResults();
        }
    }
}
