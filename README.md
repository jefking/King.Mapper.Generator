Generate a data access layer for your SQL Server database for use with the [King.Mapper](https://github.com/jefking/King.Mapper) framework.

## NuGet
[Add via NuGet](https://www.nuget.org/packages/King.Mapper.Generator)
```
PM> Install-Package King.Mapper.Generator
```

## Usage
**Code Generation**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Code
```
**Code Generation (with MSTest Unit Test Cases)**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Code mstest
```
**Code Generation (with NUnit Unit Test Cases)**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Code nunit
```
### Output
>**Example: [StoredProcedures.Generated.cs](https://github.com/jefking/King.Mapper.Generator/blob/master/King.Mapper.Generator.Integration/StoredProcedures.Generated.cs)** 
>
>**Example: [StoredProcedures.Unit.Test.Generated.cs](https://github.com/jefking/King.Mapper.Generator/blob/master/King.Mapper.Generator.Integration/StoredProcedures.Unit.Test.Generated.cs)**