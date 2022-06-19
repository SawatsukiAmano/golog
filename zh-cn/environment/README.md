# 环境
> 开发工具： Windows11 + Navicat + Visual Studio 2022 + VSCode  
> 数据库/中间件：MySql 8.0 + RabbitMQ + Redis
> 后端：.NET6( EF Core+ C#10 + IOC + WebAPI + JWT + Log4Net )  
> 前端：VUE3( Axios + TypeScript )

# System
> 开发环境Windows11  
> 部署环境基于CentOS8和Docker20
## Linux
> [CentOS 8](https://mirrors.aliyun.com/centos/8/isos/x86_64/)  
> 测试环境为本地和国内未备案轻量云，均为CentOS 8.2/8.5
> 以下配置为本地x86_64服务器装机后的配置，其中Docker安装路径在一个NTFS格式的U盘中
### YUM源
```bash
# 设置yum源
cd /etc/yum.repos.d/
mkdir repo_bak
mv *.repo repo_bak/
vim CentOS-Base.repo
```

```repo
[base]
name=CentOS-8-stream - Base - mirrors.aliyun.com
baseurl=https://mirrors.aliyun.com/centos/8-stream/BaseOS/$basearch/os/
gpgcheck=1
gpgkey=https://mirrors.aliyun.com/centos/RPM-GPG-KEY-CentOS-Official

#additional packages that may be useful
[extras]
name=CentOS-8-stream - Extras - mirrors.aliyun.com
baseurl=https://mirrors.aliyun.com/centos/8-stream/extras/$basearch/os/
gpgcheck=1
gpgkey=https://mirrors.aliyun.com/centos/RPM-GPG-KEY-CentOS-Official

#additional packages that extend functionality of existing packages
[centosplus]
name=CentOS-8-stream - Plus - mirrors.aliyun.com
baseurl=https://mirrors.aliyun.com/centos/8-stream/centosplus/$basearch/os/
gpgcheck=1
enabled=0
gpgkey=https://mirrors.aliyun.com/centos/RPM-GPG-KEY-CentOS-Official

[PowerTools]
name=CentOS-8-stream - PowerTools - mirrors.aliyun.com
baseurl=https://mirrors.aliyun.com/centos/8-stream/PowerTools/$basearch/os/
gpgcheck=1
enabled=0
gpgkey=https://mirrors.aliyun.com/centos/RPM-GPG-KEY-CentOS-Official

[AppStream]
name=CentOS-8-stream - AppStream - mirrors.aliyun.com
baseurl=https://mirrors.aliyun.com/centos/8-stream/AppStream/$basearch/os/
gpgcheck=1
gpgkey=https://mirrors.aliyun.com/centos/RPM-GPG-KEY-CentOS-Official
```

```bash
# 重新生成yum源
yum clean all
yum makecache
```
### 挂载NFTS格式U盘
```bash
yum install -y ntfs-3g
yum install -y ntfsprogs
fdisk -l
ntfsfix /dev/sdb1
mkdir -p /mnt/device01/

mount -t ntfs-3g /dev/sdb1 /mnt/device01
mkdir -p /mnt/device01/docker/
```

## Docker
> [Docker 20](https://www.docker.com/get-started/)

```bash
uname -r    # 查看当前系统内核
yum -y update   # 升级所有包同时也升级软件和系统内核
yum -y upgrade  # 只升级所有包，不升级软件和系统内核
yum remove docker*  # 移除所有docker相关的包


# 设置Docker安装路径
mkdir -p /etc/docker/
vim /etc/docker/daemon.json
#配置文件内容：graph代表docker指定的安装目录
# {
# "registry-mirrors": ["http://hub-mirror.c.163.com"], # 镜像源
# "graph":"/mnt/device01/docker" # 安装路径
# }

yum-config-manager --add-repo  http://mirrors.aliyun.com/docker-ce/linux/centos/docker-ce.repo
yum-config-manager --add-repo http://download.docker.com/linux/centos/docker-ce.repo    # Docker官网仓库
yum install docker-ce docker-ce-cli containerd.io --allowerasing # CentOS8默认使用podman代替docker。直接安装docker会出现错误

systemctl start docker  # 启动Docker
systemctl enable docker # 开机自启
docker version
mkdir -p /mnt/device01/docker-data
cd /mnt/device01/docker-data
mkdir mysql redis mongo_db rabbit_mq maria_db mssql # 创建docker持久化数据文件夹
```

# Application
## MySql
```bash
docker search mysql
docker pull mysql

# 防火墙
firewall-cmd --zone=public --list-ports 
firewall-cmd --query-port=3306/tcp # 查询端口是否开放
firewall-cmd --zone=public --add-port=3306/tcp --permanent # 开启防火墙3306端口
firewall-cmd --zone=public --remove-port=3306/tcp --permanent
firewall-cmd --reload
systemctl status firewalld

# 启动mysql
docker run -it -d --name mysql -v /mnt/device01/docker-data/mysql/:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=123456ABC --privileged=true --restart=always -p 3306:3306 mysql
docker start mysql
```

## RabbitMQ
```bash

```