using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class RuntimeBenchmarks
{
    private int[] _array = Enumerable.Range(0, 1000).ToArray();

    [Benchmark(Baseline = true)]
    public int ArrayForeachIEnumerable()
    {
        int sum = 0;
        foreach (var item in (IEnumerable<int>)_array) sum += item;
        return sum;
    }

    [Benchmark]
    public int DirectArraySum()
    {
        int sum = 0;
        for (int i = 0; i < _array.Length; i++) sum += _array[i];
        return sum;
    }

    [Benchmark]
    public int SmallFixedArray()
    {
        int sum = 0;
        int[] small = { 1, 2, 3, 4, 5 }; // Fixed-size, non-escaping
        foreach (var x in small) sum += x;
        return sum;
    }
}