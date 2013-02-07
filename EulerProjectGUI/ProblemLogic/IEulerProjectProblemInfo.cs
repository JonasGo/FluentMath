namespace EulerProjectGUI.ProblemLogic
{
    public interface IEulerProjectProblemInfo
    {
        double DurationInMs { get; set; }
        int Nr { get; set; }
        string MethodCall { get; set; }
        string Result { get; set; }
    }
}