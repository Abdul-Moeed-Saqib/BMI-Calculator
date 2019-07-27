using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    public partial class BMICalculatorForm : Form
    {
        // Class Properties
        public float BMIFormulaImperial { get; set; }
        public float BMIFormulaMetric { get; set; }
        public float Output { get; set; }
        public float OutputValue { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the ImperialRadioButton CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
            HeightmTextBox.Clear();
            WeightkgTextBox.Clear();
        }

        /// <summary>
        /// This is the Event Handler for the MetricRadioButton CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
            HeightInTextBox.Clear();
            WeightlbTextBox.Clear();
        }

        private void HeightInTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(HeightInTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch
            {
                CalculateButton.Enabled = false;
            }
        }

        private void WeightlbTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(WeightlbTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch
            {
                CalculateButton.Enabled = false;
            }
        }

        private void HeightmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(HeightmTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch
            {
                CalculateButton.Enabled = false;
            }
        }

        private void WeightkgTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(WeightkgTextBox.Text);
                CalculateButton.Enabled = true;
            }
            catch
            {
                CalculateButton.Enabled = false;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked == true)
            {
                Output = BMIFormulaImperial = (float.Parse(WeightlbTextBox.Text) * 703) / (float.Parse(HeightInTextBox.Text) * float.Parse(HeightInTextBox.Text));
            }
            else if (MetricRadioButton.Checked == true)
            {
                Output = BMIFormulaMetric = (float.Parse(WeightkgTextBox.Text)) / (float.Parse(HeightmTextBox.Text) * float.Parse(HeightmTextBox.Text)); 
            }
            BMITextBox.Text = Output.ToString();
            OutputValue = Output;
            OutputValue = (float)Math.Round(OutputValue, 1);
            if (OutputValue < 0.1f)
            {
                OutputValue = 0.1f;
            }
            BMITextBox.Text = OutputValue.ToString();
        }
    }
}
