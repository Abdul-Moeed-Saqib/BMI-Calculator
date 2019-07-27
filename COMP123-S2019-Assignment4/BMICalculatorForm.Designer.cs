namespace COMP123_S2019_Assignment4
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
            this.HeightInLabel = new System.Windows.Forms.Label();
            this.WeightlbLabel = new System.Windows.Forms.Label();
            this.HeightInTextBox = new System.Windows.Forms.TextBox();
            this.WeightlbTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightmTextBox = new System.Windows.Forms.TextBox();
            this.HeightmLabel = new System.Windows.Forms.Label();
            this.WeightkgLabel = new System.Windows.Forms.Label();
            this.WeightkgTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(20, 12);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(254, 83);
            this.ImperialTableLayoutPanel.TabIndex = 0;
            // 
            // HeightInLabel
            // 
            this.HeightInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInLabel.AutoSize = true;
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
            this.WeightlbLabel.Location = new System.Drawing.Point(3, 41);
            this.WeightlbLabel.Name = "WeightlbLabel";
            this.WeightlbLabel.Size = new System.Drawing.Size(121, 42);
            this.WeightlbLabel.TabIndex = 0;
            this.WeightlbLabel.Text = "Weight(lb):";
            this.WeightlbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightInTextBox
            // 
            this.HeightInTextBox.Location = new System.Drawing.Point(130, 3);
            this.HeightInTextBox.Name = "HeightInTextBox";
            this.HeightInTextBox.Size = new System.Drawing.Size(121, 32);
            this.HeightInTextBox.TabIndex = 1;
            // 
            // WeightlbTextBox
            // 
            this.WeightlbTextBox.Location = new System.Drawing.Point(130, 44);
            this.WeightlbTextBox.Name = "WeightlbTextBox";
            this.WeightlbTextBox.Size = new System.Drawing.Size(121, 32);
            this.WeightlbTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HeightmTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightmLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightkgLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightkgTextBox, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HeightmTextBox
            // 
            this.HeightmTextBox.Location = new System.Drawing.Point(130, 3);
            this.HeightmTextBox.Name = "HeightmTextBox";
            this.HeightmTextBox.Size = new System.Drawing.Size(121, 32);
            this.HeightmTextBox.TabIndex = 1;
            // 
            // HeightmLabel
            // 
            this.HeightmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightmLabel.AutoSize = true;
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
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(19, 25);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(81, 22);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(19, 53);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(69, 22);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceGroupBox
            // 
            this.ChoiceGroupBox.Controls.Add(this.ImperialRadioButton);
            this.ChoiceGroupBox.Controls.Add(this.MetricRadioButton);
            this.ChoiceGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceGroupBox.Location = new System.Drawing.Point(53, 221);
            this.ChoiceGroupBox.Name = "ChoiceGroupBox";
            this.ChoiceGroupBox.Size = new System.Drawing.Size(200, 100);
            this.ChoiceGroupBox.TabIndex = 2;
            this.ChoiceGroupBox.TabStop = false;
            this.ChoiceGroupBox.Text = "Choose";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(53, 338);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(218, 42);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(101, 386);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(121, 38);
            this.BMITextBox.TabIndex = 1;
            this.BMITextBox.Text = "0";
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ChoiceGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox HeightmTextBox;
        private System.Windows.Forms.Label HeightmLabel;
        private System.Windows.Forms.Label WeightkgLabel;
        private System.Windows.Forms.TextBox WeightkgTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.GroupBox ChoiceGroupBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BMITextBox;
    }
}

