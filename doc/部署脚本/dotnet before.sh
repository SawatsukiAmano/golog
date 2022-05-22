#! /bin/bash
RED="echo -en \\E[4;31m"
GREEN="echo -en \\E[7;32m"
YELLOW="echo -en \\E[5;33m"
RESET="echo -en \\E[0;39m"

# 1.安装.net 6.0 SDK包
$GREEN
rm -rf /app/temp/api.zip
dotnet --version &>/dev/null
if [ $? -eq 0 ];then
	echo "1.检查到dotnet 已安装!"
else
	echo "1.安装dotnet6环境..." 
	sudo dnf install -y dotnet-sdk-6.0
	echo "1.安装dotnet6环境...安装完成!"
fi
$REST

# 2.创建部署文件夹
if [ ! -d "/app/temp/api" ]; then	
	$YELLOW 
	echo "2.未发现api文件夹,自动创建中..."
	mkdir -p /app/temp/api
	$GREEN
	echo "2.api文件夹创建成功 /app/temp/api"
	$RESET
else
	$GREEN
	echo "2. api文件夹已就绪... /app/temp/api"
	$RESET
fi
