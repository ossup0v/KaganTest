
using KaganTest.FileProcessing;

public class Program
{
    public static void Main(string[] args)
    {
        ExcelWrapper a = new ExcelWrapper();

        var b = new FileWrapper();
        var test = b.LoadTest();

        a.SaveTestResult(new KaganTestResult("123OMN", DateTime.UtcNow)
        { 
            StepResults = new List<TestStepResult>
            { 
                new TestStepResult(1, TimeSpan.FromSeconds(1), false),
                new TestStepResult(2, TimeSpan.FromSeconds(2), true),
                new TestStepResult(3, TimeSpan.FromSeconds(1), true),
                new TestStepResult(4, TimeSpan.FromSeconds(4), false),
                new TestStepResult(5, TimeSpan.FromSeconds(5), false),
                new TestStepResult(6, TimeSpan.FromSeconds(11), true),
            }
        });

        a.SaveTestResult(new KaganTestResult("124OMN", DateTime.UtcNow)
        {
            StepResults = new List<TestStepResult>
            {
                new TestStepResult(1, TimeSpan.FromSeconds(1), false),
                new TestStepResult(2, TimeSpan.FromSeconds(2), true),
                new TestStepResult(3, TimeSpan.FromSeconds(1), true),
                new TestStepResult(4, TimeSpan.FromSeconds(4), false),
                new TestStepResult(5, TimeSpan.FromSeconds(5), false),
                new TestStepResult(6, TimeSpan.FromSeconds(11), true),
            }
        });

        a.SaveTestResult(new KaganTestResult("125OMN", DateTime.UtcNow)
        {
            StepResults = new List<TestStepResult>
            {
                new TestStepResult(1, TimeSpan.FromSeconds(1), false),
                new TestStepResult(2, TimeSpan.FromSeconds(2), true),
                new TestStepResult(3, TimeSpan.FromSeconds(1), true),
                new TestStepResult(4, TimeSpan.FromSeconds(4), false),
                new TestStepResult(5, TimeSpan.FromSeconds(5), false),
                new TestStepResult(6, TimeSpan.FromSeconds(11), true),
            }
        });
        Console.ReadLine();
    }
}