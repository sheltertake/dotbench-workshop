``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.203
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  .NETCore20 : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  .NETCore21 : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT


```
|   Method |        Job |     Toolchain |      Mean |     Error |    StdDev |
|--------- |----------- |-------------- |----------:|----------:|----------:|
| Positive | .NETCore20 | .NET Core 2.0 | 0.4901 ns | 0.0514 ns | 0.0703 ns |
| Negative | .NETCore20 | .NET Core 2.0 | 1.5344 ns | 0.0745 ns | 0.0660 ns |
| Positive | .NETCore21 | .NET Core 2.1 | 0.2931 ns | 0.0224 ns | 0.0199 ns |
| Negative | .NETCore21 | .NET Core 2.1 | 0.1640 ns | 0.0400 ns | 0.0354 ns |
