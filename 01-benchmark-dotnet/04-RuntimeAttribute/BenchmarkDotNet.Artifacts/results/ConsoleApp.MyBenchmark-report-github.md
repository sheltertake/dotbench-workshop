``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.950 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.203
  [Host]       : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  Clr          : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Core         : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  CoreRT       : .NET CoreRT 1.0.27527.01 @BuiltBy: dlab14-DDVSOWINAGE101 @Branch: master @Commit: bd07c4e0727fa104d50e28ed70ca9bb480dcbc1b, 64bit AOT
  LegacyJitX64 : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  LegacyJitX86 : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3416.0


```
| Method |          Job |       Jit | Platform | Runtime | Num |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |------------- |---------- |--------- |-------- |---- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **Concat** |          **Clr** |    **RyuJit** |      **X64** |     **Clr** |   **1** | **1.2374 ns** | **0.1055 ns** | **0.0935 ns** |     **-** |     **-** |     **-** |         **-** |
| Concat |         Core |    RyuJit |      X64 |    Core |   1 | 1.1505 ns | 0.0517 ns | 0.0483 ns |     - |     - |     - |         - |
| Concat |       CoreRT |    RyuJit |      X64 |  CoreRT |   1 | 1.1000 ns | 0.1240 ns | 0.1035 ns |     - |     - |     - |         - |
| Concat | LegacyJitX64 | LegacyJit |      X64 |     Clr |   1 | 1.1430 ns | 0.1027 ns | 0.0911 ns |     - |     - |     - |         - |
| Concat | LegacyJitX86 | LegacyJit |      X86 |     Clr |   1 | 0.9626 ns | 0.0793 ns | 0.0703 ns |     - |     - |     - |         - |
| **Concat** |          **Clr** |    **RyuJit** |      **X64** |     **Clr** |   **2** | **1.2344 ns** | **0.1144 ns** | **0.1224 ns** |     **-** |     **-** |     **-** |         **-** |
| Concat |         Core |    RyuJit |      X64 |    Core |   2 | 1.1327 ns | 0.1171 ns | 0.1716 ns |     - |     - |     - |         - |
| Concat |       CoreRT |    RyuJit |      X64 |  CoreRT |   2 | 1.3018 ns | 0.1285 ns | 0.1883 ns |     - |     - |     - |         - |
| Concat | LegacyJitX64 | LegacyJit |      X64 |     Clr |   2 | 2.1370 ns | 0.1368 ns | 0.1464 ns |     - |     - |     - |         - |
| Concat | LegacyJitX86 | LegacyJit |      X86 |     Clr |   2 | 0.5917 ns | 0.1019 ns | 0.1213 ns |     - |     - |     - |         - |
| **Concat** |          **Clr** |    **RyuJit** |      **X64** |     **Clr** |   **3** | **1.4186 ns** | **0.0960 ns** | **0.0851 ns** |     **-** |     **-** |     **-** |         **-** |
| Concat |         Core |    RyuJit |      X64 |    Core |   3 | 0.9255 ns | 0.0743 ns | 0.0695 ns |     - |     - |     - |         - |
| Concat |       CoreRT |    RyuJit |      X64 |  CoreRT |   3 | 0.9637 ns | 0.0709 ns | 0.0628 ns |     - |     - |     - |         - |
| Concat | LegacyJitX64 | LegacyJit |      X64 |     Clr |   3 | 1.0616 ns | 0.0866 ns | 0.0723 ns |     - |     - |     - |         - |
| Concat | LegacyJitX86 | LegacyJit |      X86 |     Clr |   3 | 0.5345 ns | 0.0936 ns | 0.0876 ns |     - |     - |     - |         - |
