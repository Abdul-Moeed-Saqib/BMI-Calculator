namespace BMICalculator
{
    partial class BMICalculatorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightInTextBox = new System.Windows.Forms.TextBox();
            this.HeightInLabel = new System.Windows.Forms.Label();
            this.WeightlbLabel = new System.Windows.Forms.Label();
            this.WeightlbTextBox = new System.Windows.Forms.TextBox();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightmTextBox = new System.Windows.Forms.TextBox();
            this.HeightmLabel = new System.Windows.Forms.Label();
            this.WeightkgLabel = new System.Windows.Forms.Label();
            this.WeightkgTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.MultlineTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.ChoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightInTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightInLabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightlbLabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightlbTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(20, 87);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(254, 83);
            this.ImperialTableLayoutPanel.TabIndex = 0;
            // 
            // HeightInTextBox
            // 
            this.HeightInTextBox.Location = new System.Drawing.Point(130, 3);
            this.HeightInTextBox.Name = "HeightInTextBox";
            this.HeightInTextBox.Size = new System.Drawing.Size(121, 32);
            this.HeightInTextBox.TabIndex = 1;
            this.HeightInTextBox.TextChanged += new System.EventHandler(this.HeightInTextBox_TextChanged);
            // 
            // HeightInLabel
            // 
            this.HeightInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInLabel.AutoSize = true;
            this.HeightInLabel.ForeColor = System.Drawing.Color.White;
            this.HeightInLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightInLabel.Name = "HeightInLabel";
            this.HeightInLabel.Size = new System.Drawing.Size(121, 41);
            this.HeightInLabel.TabIndex = 0;
            this.HeightInLabel.Text = "Height(In):";
            this.HeightInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightlbLabel
            // 
            this.WeightlbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightlbLabel.AutoSize = true;
            this.WeightlbLabel.ForeColor = System.Drawing.Color.White;
            this.WeightlbLabel.Location = new System.Drawing.Point(3, 41);
            this.WeightlbLabel.Name = "WeightlbLabel";
            this.WeightlbLabel.Size = new System.Drawing.Size(121, 42);
            this.WeightlbLabel.TabIndex = 0;
            this.WeightlbLabel.Text = "Weight(lb):";
            this.WeightlbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightlbTextBox
            // 
            this.WeightlbTextBox.Location = new System.Drawing.Point(130, 44);
            this.WeightlbTextBox.Name = "WeightlbTextBox";
            this.WeightlbTextBox.Size = new System.Drawing.Size(121, 32);
            this.WeightlbTextBox.TabIndex = 1;
            this.WeightlbTextBox.TextChanged += new System.EventHandler(this.WeightlbTextBox_TextChanged);
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Controls.Add(this.HeightmTextBox, 1, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.HeightmLabel, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.WeightkgLabel, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.WeightkgTextBox, 1, 1);
            this.MetricTableLayoutPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(20, 88);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(254, 83);
            this.MetricTableLayoutPanel.TabIndex = 0;
            // 
            // HeightmTextBox
            // 
            this.HeightmTextBox.Location = new System.Drawing.Point(130, 3);
            this.HeightmTextBox.Name = "HeightmTextBox";
            this.HeightmTextBox.Size = new System.Drawing.Size(121, 32);
            this.HeightmTextBox.TabIndex = 1;
            this.HeightmTextBox.TextChanged += new System.EventHandler(this.HeightmTextBox_TextChanged);
            // 
            // HeightmLabel
            // 
            this.HeightmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightmLabel.AutoSize = true;
            this.HeightmLabel.ForeColor = System.Drawing.Color.White;
            this.HeightmLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightmLabel.Name = "HeightmLabel";
            this.HeightmLabel.Size = new System.Drawing.Size(121, 41);
            this.HeightmLabel.TabIndex = 0;
            this.HeightmLabel.Text = "Height(m):";
            this.HeightmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightkgLabel
            // 
            this.WeightkgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightkgLabel.AutoSize = true;
            this.WeightkgLabel.ForeColor = System.Drawing.Color.White;
            this.WeightkgLabel.Location = new System.Drawing.Point(3, 41);
            this.WeightkgLabel.Name = "WeightkgLabel";
            this.WeightkgLabel.Size = new System.Drawing.Size(121, 42);
            this.WeightkgLabel.TabIndex = 0;
            this.WeightkgLabel.Text = "Weight(kg):";
            this.WeightkgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightkgTextBox
            // 
            this.WeightkgTextBox.Location = new System.Drawing.Point(130, 44);
            this.WeightkgTextBox.Name = "WeightkgTextBox";
            this.WeightkgTextBox.Size = new System.Drawing.Size(121, 32);
            this.WeightkgTextBox.TabIndex = 1;
            this.WeightkgTextBox.TextChanged += new System.EventHandler(this.WeightkgTextBox_TextChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(19, 25);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(81, 22);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(19, 53);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(69, 22);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ChoiceGroupBox
            // 
            this.ChoiceGroupBox.Controls.Add(this.ImperialRadioButton);
            this.ChoiceGroupBox.Controls.Add(this.MetricRadioButton);
            this.ChoiceGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceGroupBox.ForeColor = System.Drawing.Color.White;
            this.ChoiceGroupBox.Location = new System.Drawing.Point(53, 204);
            this.ChoiceGroupBox.Name = "ChoiceGroupBox";
            this.ChoiceGroupBox.Size = new System.Drawing.Size(200, 100);
            this.ChoiceGroupBox.TabIndex = 2;
            this.ChoiceGroupBox.TabStop = false;
            this.ChoiceGroupBox.Text = "Choose";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkRed;
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(41, 334);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(218, 42);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.Black;
            this.BMITextBox.Location = new System.Drawing.Point(88, 413);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(121, 38);
            this.BMITextBox.TabIndex = 1;
            this.BMITextBox.Text = "0";
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MultlineTextBox
            // 
            this.MultlineTextBox.Enabled = false;
            this.MultlineTextBox.ForeColor = System.Drawing.Color.Black;
            this.MultlineTextBox.Location = new System.Drawing.Point(12, 476);
            this.MultlineTextBox.Multiline = true;
            this.MultlineTextBox.Name = "MultlineTextBox";
            this.MultlineTextBox.Size = new System.Drawing.Size(280, 73);
            this.MultlineTextBox.TabIndex = 1;
            this.MultlineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Brown;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExitButton.Location = new System.Drawing.Point(214, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 55);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Brown;
            this.ResetButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.LightGray;
            this.ResetButton.Location = new System.Drawing.Point(12, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(129, 55);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(304, 565);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MultlineTextBox);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ChoiceGroupBox);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ChoiceGroupBox.ResumeLayout(false);
            this.ChoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.TextBox HeightInTextBox;
        private System.Windows.Forms.Label HeightInLabel;
        private System.Windows.Forms.Label WeightlbLabel;
        private System.Windows.Forms.TextBox WeightlbTextBox;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.TextBox HeightmTextBox;
        private System.Windows.Forms.Label HeightmLabel;
        private System.Windows.Forms.Label WeightkgLabel;
        private System.Windows.Forms.TextBox WeightkgTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.GroupBox ChoiceGroupBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TextBox MultlineTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

