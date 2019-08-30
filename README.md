# dotbench-workshop

1) benchmark dotnet

Create an empty console app
Install nuget package BenchmarkDotNet
Create a benchmark 
    C:\Github\dotbench-workshop\01-benchmark-dotnet\01-ShaVsMd5\Program.cs
Run benchmark
    dotnet run -c Release
Study the artifact

2) rplotexporter + rstudio

Clone the console app 
Add the RPlotExporter in the benchmark class
Run benchmark
    dotnet run -c Release
Install R + RStudio
Open BuildPlots.r and run the script (installing the deps when asks)
Study the artifacts with plots

3) BenchmarkDotNet Jobs

Create the console app
Add the basic benchmark class
Run the benchmark 
The static variable is invoked 110593 times. Ocio!!!
ShortRunJob 16385

4) Benchmark attributes
    Runtimes:
    dotnet run -c Release -f netcoreapp2.2