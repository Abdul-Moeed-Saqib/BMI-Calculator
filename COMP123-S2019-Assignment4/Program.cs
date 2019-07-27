using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    static class Program
    {
        /// <summary>
        /// Name: Abdul Moeed Saqib
        /// Student ID: 301004138
        /// Date last Modified: July 26th, 2019
        /// Program description: BMI Calculater application will measure body fat based on height and weight.
        /// 
        /// RevisionHistory:
        ///
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
