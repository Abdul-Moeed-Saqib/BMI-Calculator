using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
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

        /// <summary>
        /// This is the Event Handler for the HeightInTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This is the Event Handler for the WeightlbTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This is the Event Handler for the HeightmTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This is the Event Handler for the WeightkgTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This is the Event Handler for the CalculateButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            BMIScale();
        }

        /// <summary>
        /// This method shows the result with the BMI scale
        /// </summary>
        private void BMIScale()
        {
            if (OutputValue < 18.15)
            {
                MultlineTextBox.Text = OutputValue.ToString() + $"\n UnderWeight";
                MultlineTextBox.BackColor = Color.Yellow;
            }
            else if (OutputValue > 18.15 && OutputValue < 24.9)
            {
                MultlineTextBox.Text = OutputValue.ToString() + $"\n Normal";
                MultlineTextBox.BackColor = Color.Green;
            }
            else if (OutputValue > 25 && OutputValue < 29.9)
            {
                MultlineTextBox.Text = OutputValue.ToString() + $"\n Overweight";
                MultlineTextBox.BackColor = Color.Orange;
            }
            else if (OutputValue > 30)
            {
                MultlineTextBox.Text = OutputValue.ToString() + $" \n Obese";
                MultlineTextBox.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// This is the Event Handler for BMICalculatorFOrm FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is Event Handler for BMICalculatorForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateButton.Enabled = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This is Event Handler for ResetButton's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightmTextBox.Clear();
            WeightkgTextBox.Clear();
            HeightInTextBox.Clear();
            WeightlbTextBox.Clear();
            BMITextBox.Clear();
            MultlineTextBox.Clear();
            MultlineTextBox.BackColor = Color.White;
        }
    }
}
