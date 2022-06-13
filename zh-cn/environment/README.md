# 环境
> Windows11 + Navicat + Visual Studio 2022 + VSCode  
> MySql 8.0 + RabbitMQ
> .NET6( EF Core+ C#10 + IOC(三层) + WebAPI + JWT + Log4Net )  
> VUE3( Axios + TypeScript )

# System
> 开发环境Windows11  
> 部署环境基于CentOS8和Docker20
## Linux
> [CentOS 8](https://mirrors.aliyun.com/centos/8/isos/x86_64/)  

## Docker
> [Docker 20](https://www.docker.com/get-started/)

```shell
uname -r    # 查看当前系统内核
yum -y update   # 升级所有包同时也升级软件和系统内核；​ 
yum -y upgrade  # 只升级所有包，不升级软件和系统内核
yum remove docker*  # 移除所有docker相关的包
yum install -y yum-utils device-mapper-persistent-data lvm2 #  yum-util 提供yum-config-manager功能，另两个是devicemapper驱动依赖
yum-config-manager --add-repo http://download.docker.com/linux/centos/docker-ce.repo    # Docker官网仓库
yum-config-manager --add-repo http://mirrors.aliyun.com/docker-ce/linux/centos/docker-ce.
repo    # 阿里仓库
yum list docker-ce --showduplicates | sort -r   # 查看可用的Docker版本
yum -y install docker-ce:latest # 安装最新版的Docker
systemctl start docker  # 启动Docker
systemctl enable docker # 开机自启
```

