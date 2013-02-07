using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

using FluentLib;

namespace EulerProjectGUI.ProblemLogic
{
    public static class EulerProjectProblems
    {
        public static EulerProjectProblemInfo CalculateEulerProjectProblem(int nr)
        {
            Stopwatch stopwatch = new Stopwatch();
            EulerProjectProblemInfo problemInfo = new EulerProjectProblemInfo();

            stopwatch.Start();
            switch (nr)
            {
                case 1:
                    problemInfo.Result = FluentMath.SumOf(FluentMath.MultiplesOf(3).Or(5).Under(1000)).ToString(CultureInfo.InvariantCulture);
                    problemInfo.MethodCall = "FluentMath.SumOf(FluentMath.MultiplesOf(3).Or(5).Under(1000))";
                    break;
                case 2:
                    problemInfo.Result = FluentMath.SumOf(FluentMath.Get().EvenValues.OutOf(FluentMath.Get().FibonacciNumbers.ToValue(4000000))).ToString(CultureInfo.InvariantCulture);
                    problemInfo.MethodCall = "FluentMath.SumOf(FluentMath.Get().EvenValues.OutOf(FluentMath.Get().FibonacciNumbers.ToValue(4000000)))";
                    break;
                case 5:
                    List<long> values = new List<long>();
                    for (int i = 0; i < 20; i++)
                    {
                        values.Add(i + 1);
                    }
                    problemInfo.Result = FluentMath.LeastCommonMultipleOf(values).ToString();
                    problemInfo.MethodCall = "FluentMath.LeastCommonMultipleOf(values)";
                    break;
                default:
                    problemInfo.Result = "Sorry, not yet implemented!";
                    problemInfo.MethodCall = "";
                    break;
            }
            stopwatch.Stop();
            double millisecPerTick = 1000.0 / Stopwatch.Frequency;
            problemInfo.DurationInMs = stopwatch.ElapsedTicks * millisecPerTick;


            return problemInfo;
        }

    }

    public class EulerProjectProblemInfo : IEulerProjectProblemInfo
    {
        public double DurationInMs { get; set; }
        public int Nr { get; set; }
        public string MethodCall { get; set; }
        public string Result { get; set; }
    }
}
