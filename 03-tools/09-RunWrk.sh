#!/bin/bash
curl -vs http://localhost:5000/memory/report

wrk -t12 -c400 -d30s --latency http://localhost:5000/memory/classes

wrk -t12 -c400 -d30s --latency http://localhost:5000/memory/structs

curl -vs http://localhost:5000/memory/report

