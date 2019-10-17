dotnet publish -c Release
dotnet .\bin\Release\netcoreapp3.0\WebApi3.dll
wget http://localhost:5000/memory/report
wrk -t12 -c400 -d30s --latency http://localhost:5000/memory/classes
wrk -t12 -c400 -d30s --latency http://localhost:5000/memory/structs
wget http://localhost:5000/memory/report


---


dotnet publish -c Release -r win10-x64 --self-contained
copiare in \\vi-dsrv-22\d$\TempDemo\webapi3

POWERSHELL:
$env:ASPNETCORE_URLS="http://*:5123" ; .\WebApi3.exe

CMD:
SET ASPNETCORE_URLS=https://*:5123 && .\WebApi3.exe
http://vi-dsrv-22:5123/memory/report

copy and extract:
"C:\Users\massimiliano.balestr\AppData\Local\JetBrains\Installations\dotTrace192_000\RemoteAgent.zip"

run
connect dottrace to the remote agent 
net.tcp://vi-dsrv-22:9100/RemoteAgent
profile webapi3
wrk -t12 -c400 -d30s --latency http://vi-dsrv-22:5123/memory/classes   

save dump
"\\vi-dsrv-22\c$\Users\massimiliano.balestr\AppData\Local\Temp\6\WebApi3.DMP"
import with dotmemory


---
https://www.jetbrains.com/dotmemory/download/download-thanks.html?platform=windows&code=DMCLP
C:\Users\massimiliano.balestr\Downloads\JetBrains.dotMemoryConsole.2019.2.2