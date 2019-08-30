using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

namespace ConsoleApp
{
    //110593
    //[SimpleJob]       // -> 225281

    //[ShortRunJob]     // -> 16385       // Job: ShortRun(IterationCount=3, LaunchCount=1, WarmupCount=3)
    //[MediumRunJob]    // -> 55297       // Job: MediumRun(IterationCount=15, LaunchCount=2, WarmupCount=10)
    //[LongRunJob]      // -> 239617      // Job: LongRun(IterationCount=100, LaunchCount=3, WarmupCount=15)
    //[VeryLongRunJob]  // -> 1089537     // Job: VeryLongRun(IterationCount=500, LaunchCount=4, WarmupCount=30)
    //                                            Run time: 00:47:22 (2842 sec), executed benchmarks: 1


    //[CoreJob]         // -> 221185      // Job: Core(Runtime=Core)

    //[DryJob]          // -> 1           // Job: Dry(IterationCount=1, LaunchCount=1, RunStrategy=ColdStart, UnrollFactor=1, WarmupCount=1)
    //[DryCoreJob]      // -> 1           // Job: DryCore(Runtime=Core, IterationCount=1, LaunchCount=1, RunStrategy=ColdStart, UnrollFactor=1, WarmupCount=1)

    //[SimpleJob(
    // 110593 -> // Job: MyId(RunStrategy=Throughput)
    //    id: "MyId"
    //, runStrategy: RunStrategy.Throughput
    //, baseline: false
    //, launchCount: -1
    //, invocationCount: -1
    //, warmupCount: -1
    //, targetCount: -1

    // 3 --> // Job: Job-JHVPXD(InvocationCount=1, IterationCount=1, LaunchCount=1, RunStrategy=Throughput, UnrollFactor=1, WarmupCount=0)

    //  runStrategy: RunStrategy.Throughput
    //, launchCount: 1
    //, invocationCount: 1
    //, warmupCount: 0
    //, targetCount: 1

    // 20 -> // Job: Job-AOKRYF(InvocationCount=10, IterationCount=2, LaunchCount=1, RunStrategy=ColdStart, UnrollFactor=1, WarmupCount=0)
    //runStrategy: RunStrategy.ColdStart
    // 31 -> // Job: Job-BEDLXG(InvocationCount=10, IterationCount=2, LaunchCount=1, RunStrategy=Throughput, UnrollFactor=1, WarmupCount=0)
    //runStrategy: RunStrategy.Throughput
    //, launchCount: 1
    //, invocationCount: 10
    //, warmupCount: 0
    //, targetCount: 2

    // 51 -> // // Job: Job-UDQHMA(InvocationCount=10, IterationCount=2, LaunchCount=1, RunStrategy=Throughput, UnrollFactor=1, WarmupCount=3)
    //runStrategy: RunStrategy.Throughput
    //, launchCount: 1
    //, invocationCount: 10
    //, warmupCount: 3
    //, targetCount: 2
    //)]

    public class MyBenchmark
    {
        private static int i;
        [Benchmark]
        public void Count()
        {
            Console.WriteLine(++i);
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
