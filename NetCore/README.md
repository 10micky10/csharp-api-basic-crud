# CSharp .NetCore
# Entity Framework Core Database First


# Prerequisites 🔨

* Install Windows 10, Linux or Mac
* Install .Net Core version 5 https://dotnet.microsoft.com/download


# Installation 🔧

### Installation SQL Server in docker.

* Docker 20.10.5

* download docker Sql Server image: 

```
docker pull mcr.microsoft.com/mssql server:2019-CU9-ubuntu-16.04
```

* start container:

```
docker run -d --name sqlserver -e SA_PASSWORD=Secret-123 -e ACCEPT_EULA=Y -p 1433:1433  mcr.microsoft.com/mssql/server:2019-CU9-ubuntu-16.04
```
* Sql Credentials

```
host: localhost
user: sa
password: Secret-123
port: 1433
database/schema: master
```

# Command to generate classes from existing database

## Generic

* Microsoft Authenticated

```
Scaffold-DbContext "Server=(server name); Database=(database name); Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir (Directory where classes will be generated)
```

* Without  Microsoft Authenticated

```
Scaffold-DbContext "Server=(server name); Database=(Database name); User=(database user); Password=(database password);" Microsoft.EntityFrameworkCore.SqlServer -OutputDir (Directory where classes will be generated)
```

* Project

```
Scaffold-DbContext "Server=(server name); Database=dbcrudapi; User=sa; Password=Secret-123;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
```
