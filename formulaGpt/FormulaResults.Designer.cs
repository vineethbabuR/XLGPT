namespace formulaGpt
{
    partial class FormulaResults
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // rtbResult
            // 
            rtbResult.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbResult.ForeColor = Color.Black;
            rtbResult.Location = new Point(3, 18);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(680, 850);
            rtbResult.TabIndex = 0;
            rtbResult.Text = "";
            // 
            // FormulaResults
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(rtbResult);
            Name = "FormulaResults";
            Size = new Size(686, 1106);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbResult;
    }
}
