using BenchmarkDotNet.Attributes;

public class StringOperations
{
    [Benchmark]
    public string WithToString() 
    {
        return DayOfWeek.Monday.ToString();
    }

    [Benchmark]
    public string WithNameOf()
    {
        return nameof(DayOfWeek.Monday);
    }
}
