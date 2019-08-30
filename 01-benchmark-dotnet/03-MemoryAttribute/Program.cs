using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace ConsoleApp
{
    [RPlotExporter]
    [MemoryDiagnoser]
    [SimpleJob(
    // 51-> // // Job: Job-UDQHMA(InvocationCount=10, IterationCount=2, LaunchCount=1, RunStrategy=Throughput, UnrollFactor=1, WarmupCount=3)
    runStrategy: RunStrategy.Throughput
    , launchCount: 1
    , invocationCount: 10
    , warmupCount: 3
    , targetCount: 2
    )]
    /*
    |   Method | N |      Mean | Error |    StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
    |--------- |-- |----------:|------:|----------:|---------:|---------:|---------:|----------:|
    | Allocate | 1 |  82.44 us |    NA | 16.942 us | 300.0000 | 300.0000 | 300.0000 |      1 MB |
    | Allocate | 2 | 573.74 us |    NA |  5.621 us | 300.0000 | 300.0000 | 300.0000 |      2 MB |
    | Allocate | 3 | 157.58 us |    NA |  4.837 us | 900.0000 | 900.0000 | 900.0000 |      3 MB |
     */
    public class MyBenchmark
    {
        public const int Mega = 1024 * 1024;
        [Params(1,2,3)]
        public int N { get; set; }
        [Benchmark]
        public long Allocate()
        {
            var data = new byte[N * Mega];
            return data.Length;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
