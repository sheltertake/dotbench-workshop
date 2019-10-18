http://localhost:5000/memory/gen0/1
wrk -t12 -c400 -d30s --latency http://localhost:5000/memory/gen0/10 

{
"myDictionary": "0Mb",
"myByteArray": "0Mb",
"volatile": "1Kb"
}

http://localhost:5000/memory/loh/1

{
"myDictionary": "0Mb",
"myByteArray": "0Mb",
"volatile": "1Mb"
}

http://localhost:5000/memory/loh/s/1

{
"myDictionary": "0Mb",
"myByteArray": "1Mb"
}

http://localhost:5000/memory/loh/d/1/10
http://localhost:5000/memory/loh/d/2/20

{
"myDictionary": "30Mb",
"myByteArray": "1Mb"
}