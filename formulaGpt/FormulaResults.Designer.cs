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
            txtFormula = new TextBox();
            SuspendLayout();
            // 
            // txtFormula
            // 
            txtFormula.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFormula.Location = new Point(3, 24);
            txtFormula.Multiline = true;
            txtFormula.Name = "txtFormula";
            txtFormula.ReadOnly = true;
            txtFormula.ScrollBars = ScrollBars.Both;
            txtFormula.Size = new Size(680, 828);
            txtFormula.TabIndex = 13;
            // 
            // FormulaResults
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(txtFormula);
            Name = "FormulaResults";
            Size = new Size(650, 1106);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFormula;
    }
}
