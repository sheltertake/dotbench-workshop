``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.203
  [Host]     : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------- |---------:|----------:|----------:|------:|--------:|
|    Md5 | 22.73 us | 0.1995 us | 0.1866 us |  1.00 |    0.00 |
| Sha256 | 51.75 us | 0.6247 us | 0.5844 us |  2.28 |    0.03 |
