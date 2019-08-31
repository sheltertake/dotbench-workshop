``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.203
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  .NETCore20 : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  .NETCore21 : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT


```
|          Method |        Job |     Toolchain |       Mean |      Error |     StdDev |
|---------------- |----------- |-------------- |-----------:|-----------:|-----------:|
| ConvertToString | .NETCore20 | .NET Core 2.0 | 6,261.6 ns | 140.122 ns | 399.775 ns |
| ConvertToString | .NETCore21 | .NET Core 2.1 |   282.7 ns |   4.355 ns |   3.636 ns |
