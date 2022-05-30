# Golog
一个跨平台的Blog项目
# V1
##  开发环境
> 基于 MySQL 8.0——.NET6( EF Core+ C#10 + IOC + WebAPI + JWT +Log4Net)——VUE3( Axios + TypeScript)

## 部署环境
### 系统部署
1. MySQL——CnetOS 8.2
2. API——CentOS 8.2 .NET 6 RunTime Kestrel自托管
3. VUE3——Nginx 反向代理

### K8S/Docker 部署
1. MySQL——集群主从(应用层远程复制)
2. API——Docker镜像
3. VUE3——Docker Naginx镜像

