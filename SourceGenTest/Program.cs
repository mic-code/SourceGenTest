using SourceGenAttribute;

namespace SourceGenTest;

internal class Program
{
    static void Main(string[] args)
    {
        var sample = new SampleClass();
        Console.WriteLine(sample.GeneratedMethod());
    }
}

[GenStuff]
public class SampleClass
{
}
