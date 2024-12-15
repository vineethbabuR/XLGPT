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
            ((System.ComponentModel.ISupportInitialize)trkBarTemp).BeginInit();
            SuspendLayout();
            // 
            // cmbModels
            // 
            cmbModels.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cmbModels.ForeColor = Color.Blue;
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(10, 113);
            cmbModels.Margin = new Padding(4, 3, 4, 3);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(249, 23);
            cmbModels.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 2;
            label1.Text = "Select Model";
            // 
            // trkBarTemp
            // 
            trkBarTemp.LargeChange = 20;
            trkBarTemp.Location = new Point(9, 316);
            trkBarTemp.Maximum = 100;
            trkBarTemp.Name = "trkBarTemp";
            trkBarTemp.Size = new Size(198, 45);
            trkBarTemp.SmallChange = 10;
            trkBarTemp.TabIndex = 4;
            trkBarTemp.TickFrequency = 10;
            trkBarTemp.Scroll += trkBarTemp_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 290);
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
            txtTempValue.Location = new Point(213, 316);
            txtTempValue.Name = "txtTempValue";
            txtTempValue.Size = new Size(45, 20);
            txtTempValue.TabIndex = 6;
            txtTempValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 31);
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
            cmbType.Location = new Point(9, 54);
            cmbType.Margin = new Padding(4, 3, 4, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(249, 23);
            cmbType.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 9;
            label4.Text = "API Key";
            // 
            // txtAPIKey
            // 
            txtAPIKey.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtAPIKey.Location = new Point(10, 175);
            txtAPIKey.Multiline = true;
            txtAPIKey.Name = "txtAPIKey";
            txtAPIKey.Size = new Size(249, 108);
            txtAPIKey.TabIndex = 10;
            // 
            // btnAsk
            // 
            btnAsk.BackColor = Color.Purple;
            btnAsk.Font = new Font("Consolas", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsk.ForeColor = Color.White;
            btnAsk.Location = new Point(9, 689);
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
            txtQuestion.Location = new Point(9, 378);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ScrollBars = ScrollBars.Both;
            txtQuestion.Size = new Size(249, 292);
            txtQuestion.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 351);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 13;
            label5.Text = "Question";
            // 
            // ModelControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }


}
