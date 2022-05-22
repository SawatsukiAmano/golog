#! /bin/bash
RED="echo -en \\E[4;31m"
GREEN="echo -en \\E[7;32m"
YELLOW="echo -en \\E[5;33m"
RESET="echo -en \\E[0;39m"

# 3.停止.net 6 运行的api
$GREEN
unzip -o /app/temp/api.zip -d /app/temp &>/dev/null
num=$(ps -ef |grep -E "urls=http://\*:1414" | awk 'NR=1{print $2}')
kill $num
echo "停止正在运行的api进程id"$num
nohup dotnet /app/temp/api/API.dll --urls=http://*:1414 &>/dev/null & 
echo "重新启动api的dll"
$RESE
