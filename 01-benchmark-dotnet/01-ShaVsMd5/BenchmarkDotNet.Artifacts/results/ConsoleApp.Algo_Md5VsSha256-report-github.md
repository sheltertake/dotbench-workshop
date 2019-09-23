``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100-rc1-014190
  [Host]     : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |
|------- |---------:|----------:|----------:|---------:|------:|--------:|
|    Md5 | 26.93 us | 0.4479 us | 0.4189 us | 26.72 us |  1.00 |    0.00 |
| Sha256 | 61.17 us | 1.5082 us | 4.2539 us | 59.28 us |  2.34 |    0.19 |
