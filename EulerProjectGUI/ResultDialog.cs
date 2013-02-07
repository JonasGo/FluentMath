using EulerProjectGUI.ProblemLogic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace EulerProjectGUI
{
    public partial class ResultDialog : Form
    {
        public ResultDialog()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNr.Text)) return;
            int problemNr;
            if (!Int32.TryParse(textBoxNr.Text, out problemNr)) return;
            IEulerProjectProblemInfo resultInfo = EulerProjectProblems.CalculateEulerProjectProblem(problemNr);

            textBoxDuration.Text = resultInfo.DurationInMs.ToString(CultureInfo.InvariantCulture) +" ms";
            textBoxResult.Text = resultInfo.Result;
            textBoxMethodCall.Text = resultInfo.MethodCall;
        }

    }
}
