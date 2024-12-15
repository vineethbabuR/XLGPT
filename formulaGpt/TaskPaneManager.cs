using ExcelDna.Integration.CustomUI;

namespace formulaGpt
{
    public static class TaskPaneManager
    {
        private static CustomTaskPane _resultsCTP;
        private static CustomTaskPane _controlCTP;

        public static void ShowCTPResults()
        {
            if (_resultsCTP == null)
            {
                _resultsCTP = CustomTaskPaneFactory.CreateCustomTaskPane(typeof(FormulaResults), "Model Results");
                _resultsCTP.Visible = true;
                _resultsCTP.Width = 700;
                _resultsCTP.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
            }
            else
            {
                _resultsCTP.Visible = true;
            }
        }

        public static void DeleteCTPResults()
        {
            if (_resultsCTP != null)
            {
                _resultsCTP.Delete();
                _resultsCTP = null;
            }
        }

        public static void ShowCTPControls()
        {
            if (_controlCTP == null)
            {
                _controlCTP = CustomTaskPaneFactory.CreateCustomTaskPane(typeof(ModelControls), "Model Control");
                _controlCTP.Visible = true;
                _controlCTP.Width = 280;
                _controlCTP.DockPosition = MsoCTPDockPosition.msoCTPDockPositionLeft;
            }
            else
            {
                _controlCTP.Visible = true;
            }
        }

        public static void DeleteCTPControls()
        {
            if (_controlCTP != null)
            {
                _controlCTP.Delete();
                _controlCTP = null;
            }
        }
    }
}