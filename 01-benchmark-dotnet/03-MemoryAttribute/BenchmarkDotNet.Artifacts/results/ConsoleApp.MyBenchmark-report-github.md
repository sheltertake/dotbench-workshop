``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.203
  [Host]     : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  Job-YZDMOD : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT

InvocationCount=10  IterationCount=2  LaunchCount=1  
RunStrategy=Throughput  UnrollFactor=1  WarmupCount=3  

```
|   Method | N |      Mean | Error |    StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|--------- |-- |----------:|------:|----------:|---------:|---------:|---------:|----------:|
| **Allocate** | **1** |  **82.44 us** |    **NA** | **16.942 us** | **300.0000** | **300.0000** | **300.0000** |      **1 MB** |
| **Allocate** | **2** | **573.74 us** |    **NA** |  **5.621 us** | **300.0000** | **300.0000** | **300.0000** |      **2 MB** |
| **Allocate** | **3** | **157.58 us** |    **NA** |  **4.837 us** | **900.0000** | **900.0000** | **900.0000** |      **3 MB** |
