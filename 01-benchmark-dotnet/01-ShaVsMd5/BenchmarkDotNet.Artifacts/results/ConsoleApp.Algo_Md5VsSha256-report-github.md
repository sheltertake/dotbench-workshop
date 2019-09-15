``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.301
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------- |---------:|----------:|----------:|------:|--------:|
|    Md5 | 27.03 us | 0.4380 us | 0.3883 us |  1.00 |    0.00 |
| Sha256 | 60.36 us | 1.2022 us | 1.6049 us |  2.23 |    0.06 |
