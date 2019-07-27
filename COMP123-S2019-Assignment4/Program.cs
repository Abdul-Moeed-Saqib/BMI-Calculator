using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    static class Program
    {
        public static Dictionary<string, Form> Forms;

        /// <summary>
        /// Name: Abdul Moeed Saqib
        /// Student ID: 301004138
        /// Date last Modified: July 26th, 2019
        /// Program description: BMI Calculater application will measure body fat based on height and weight.
        /// 
        /// RevisionHistory:
        /// 1: added controls like Textboxes for user input, radio buttons to choose imperial or metric, and Calculate Button
        /// 2: Users now can enter only numeric data in Height and Weight text boxes
        /// 3: RadioButtons are now working for the users to choose between Imperial and Metric
        /// 4: Calculate button is working to take data from weight and weight depending on whether its Imperial or Metric. It also takes the data and put it in BMI text box.
        /// 5: Fixed multiline Text Box that display BMI scale
        /// 6: created a splash screen
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<string, Form>();
            Forms.Add("StartForm", new StartForm());
            Forms.Add("BMICalculatorForm", new BMICalculatorForm());

            Application.Run(Forms["StartForm"]);
        }
    }
}
