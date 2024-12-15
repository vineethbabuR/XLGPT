namespace formulaGpt
{
    partial class ModelControls
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
            components = new System.ComponentModel.Container();
            cmbModels = new ComboBox();
            label1 = new Label();
            trkBarTemp = new TrackBar();
            label2 = new Label();
            txtTempValue = new TextBox();
            label3 = new Label();
            cmbType = new ComboBox();
            label4 = new Label();
            txtAPIKey = new TextBox();
            btnAsk = new Button();
            txtQuestion = new TextBox();
            label5 = new Label();
            txtFreqPen = new TextBox();
            trkBarFreqPen = new TrackBar();
            label6 = new Label();
            trkBarToPp = new Label();
            txtToPp = new TextBox();
            trackBarTopP = new TrackBar();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)trkBarTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkBarFreqPen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTopP).BeginInit();
            SuspendLayout();
            // 
            // cmbModels
            // 
            cmbModels.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cmbModels.ForeColor = Color.Blue;
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(10, 103);
            cmbModels.Margin = new Padding(4, 3, 4, 3);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(249, 23);
            cmbModels.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 2;
            label1.Text = "Select Model";
            // 
            // trkBarTemp
            // 
            trkBarTemp.LargeChange = 20;
            trkBarTemp.Location = new Point(9, 285);
            trkBarTemp.Maximum = 100;
            trkBarTemp.Name = "trkBarTemp";
            trkBarTemp.Size = new Size(198, 45);
            trkBarTemp.SmallChange = 10;
            trkBarTemp.TabIndex = 4;
            trkBarTemp.TickFrequency = 10;
            trkBarTemp.Value = 20;
            trkBarTemp.Scroll += trkBarTemp_Scroll;
            trkBarTemp.MouseHover += trkBarTemp_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 259);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 5;
            label2.Text = "Temperature";
            // 
            // txtTempValue
            // 
            txtTempValue.BackColor = SystemColors.GradientActiveCaption;
            txtTempValue.Enabled = false;
            txtTempValue.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTempValue.ForeColor = SystemColors.InfoText;
            txtTempValue.Location = new Point(213, 285);
            txtTempValue.Name = "txtTempValue";
            txtTempValue.Size = new Size(45, 20);
            txtTempValue.TabIndex = 6;
            txtTempValue.Text = "0.2";
            txtTempValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 21);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 7;
            label3.Text = "Model Type";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cmbType.ForeColor = Color.Blue;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(9, 44);
            cmbType.Margin = new Padding(4, 3, 4, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(249, 23);
            cmbType.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 9;
            label4.Text = "API Key";
            // 
            // txtAPIKey
            // 
            txtAPIKey.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAPIKey.Location = new Point(10, 165);
            txtAPIKey.Multiline = true;
            txtAPIKey.Name = "txtAPIKey";
            txtAPIKey.Size = new Size(249, 86);
            txtAPIKey.TabIndex = 10;
            // 
            // btnAsk
            // 
            btnAsk.BackColor = Color.Purple;
            btnAsk.Font = new Font("Consolas", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsk.ForeColor = Color.White;
            btnAsk.Location = new Point(9, 715);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(249, 27);
            btnAsk.TabIndex = 11;
            btnAsk.Text = "Ask";
            btnAsk.UseVisualStyleBackColor = false;
            btnAsk.Click += btnAsk_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Consolas", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuestion.Location = new Point(9, 482);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ScrollBars = ScrollBars.Both;
            txtQuestion.Size = new Size(249, 226);
            txtQuestion.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 455);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 13;
            label5.Text = "Question";
            // 
            // txtFreqPen
            // 
            txtFreqPen.BackColor = SystemColors.GradientActiveCaption;
            txtFreqPen.Enabled = false;
            txtFreqPen.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtFreqPen.ForeColor = SystemColors.InfoText;
            txtFreqPen.Location = new Point(214, 339);
            txtFreqPen.Name = "txtFreqPen";
            txtFreqPen.Size = new Size(45, 20);
            txtFreqPen.TabIndex = 15;
            txtFreqPen.Text = "0.5";
            txtFreqPen.TextAlign = HorizontalAlignment.Center;
            // 
            // trkBarFreqPen
            // 
            trkBarFreqPen.LargeChange = 20;
            trkBarFreqPen.Location = new Point(10, 339);
            trkBarFreqPen.Maximum = 200;
            trkBarFreqPen.Minimum = -200;
            trkBarFreqPen.Name = "trkBarFreqPen";
            trkBarFreqPen.Size = new Size(198, 45);
            trkBarFreqPen.SmallChange = 10;
            trkBarFreqPen.TabIndex = 14;
            trkBarFreqPen.TickFrequency = 25;
            trkBarFreqPen.Value = 50;
            trkBarFreqPen.Scroll += trkBarFreqPen_Scroll;
            trkBarFreqPen.MouseHover += trkBarFreqPen_MouseHover;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 316);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 19);
            label6.TabIndex = 16;
            label6.Text = "Frequency Penalty";
            // 
            // trkBarToPp
            // 
            trkBarToPp.AutoSize = true;
            trkBarToPp.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trkBarToPp.Location = new Point(9, 378);
            trkBarToPp.Margin = new Padding(4, 0, 4, 0);
            trkBarToPp.Name = "trkBarToPp";
            trkBarToPp.Size = new Size(130, 19);
            trkBarToPp.TabIndex = 19;
            trkBarToPp.Text = "Nucleus Sampling";
            // 
            // txtToPp
            // 
            txtToPp.BackColor = SystemColors.GradientActiveCaption;
            txtToPp.Enabled = false;
            txtToPp.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtToPp.ForeColor = SystemColors.InfoText;
            txtToPp.Location = new Point(213, 401);
            txtToPp.Name = "txtToPp";
            txtToPp.Size = new Size(45, 20);
            txtToPp.TabIndex = 18;
            txtToPp.Text = "0.9";
            txtToPp.TextAlign = HorizontalAlignment.Center;
            // 
            // trackBarTopP
            // 
            trackBarTopP.LargeChange = 20;
            trackBarTopP.Location = new Point(9, 401);
            trackBarTopP.Maximum = 100;
            trackBarTopP.Name = "trackBarTopP";
            trackBarTopP.Size = new Size(198, 45);
            trackBarTopP.SmallChange = 10;
            trackBarTopP.TabIndex = 17;
            trackBarTopP.TickFrequency = 10;
            trackBarTopP.Value = 90;
            trackBarTopP.Scroll += trackBarTopP_Scroll;
            trackBarTopP.MouseHover += trackBarTopP_MouseHover;
            // 
            // ModelControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(trkBarToPp);
            Controls.Add(txtToPp);
            Controls.Add(trackBarTopP);
            Controls.Add(label6);
            Controls.Add(txtFreqPen);
            Controls.Add(trkBarFreqPen);
            Controls.Add(label5);
            Controls.Add(txtQuestion);
            Controls.Add(btnAsk);
            Controls.Add(txtAPIKey);
            Controls.Add(label4);
            Controls.Add(cmbType);
            Controls.Add(label3);
            Controls.Add(txtTempValue);
            Controls.Add(label2);
            Controls.Add(trkBarTemp);
            Controls.Add(cmbModels);
            Controls.Add(label1);
            ForeColor = Color.DimGray;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ModelControls";
            Size = new Size(340, 1011);
            Load += ModelControls_Load;
            ((System.ComponentModel.ISupportInitialize)trkBarTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkBarFreqPen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTopP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.Label label1;
        private TrackBar trkBarTemp;
        private Label label2;
        private TextBox txtTempValue;
        private Label label3;
        private ComboBox cmbType;
        private Label label4;
        private TextBox txtAPIKey;
        private Button btnAsk;
        private TextBox txtQuestion;
        private Label label5;
        private TextBox txtFreqPen;
        private TrackBar trkBarFreqPen;
        private Label label6;
        private Label trkBarToPp;
        private TextBox txtToPp;
        private TrackBar trackBarTopP;
        private ToolTip toolTip;
    }


}
