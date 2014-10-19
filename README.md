Generate a data access layer for your SQL Server database for use with the [King.Mapper](https://github.com/jefking/King.Mapper) framework.

## [NuGet](https://www.nuget.org/packages/King.Mapper.Generator)
```
PM> Install-Package King.Mapper.Generator
```

## Usage
**Code Generation**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Project code
```
**MSTest: Unit Test Cases**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Project mstest
```
**NUnit: Unit Test Cases**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Project nunit
```
**Visual Studio (Build Event)**
```
$(ProjectDir)King.Mapper.Generator\King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" $(ProjectDir)\ code nunit
```
### Output
>**Example: [StoredProcedures.Generated.cs](https://github.com/jefking/King.Mapper.Generator/blob/master/King.Mapper.Generator.Integration/StoredProcedures.Generated.cs)** 
>
>**Example: [StoredProcedures.Unit.Test.Generated.cs](https://github.com/jefking/King.Mapper.Generator/blob/master/King.Mapper.Generator.Integration/StoredProcedures.Unit.Test.Generated.cs)**