King.Mapper.Generator
============

Generate a data access layer for your SQL Server database for use with the [King.Mapper](https://github.com/jefking/King.Mapper) framework.

## Usage
```
King.Mapper.Generator.exe "[SQL Server Connection String]" [Folder]
```
**Example:**
```
King.Mapper.Generator.exe "Server=localhost;Database=db;Trusted_Connection=True;" C:\Code mstest
```
##Output
```
StoredProcedures.Generated.cs
StoredProcedures.Unit.Test.Generated.cs
```
##Add Nuget to Solution
[King.Mapper](https://www.nuget.org/packages/King.Mapper)

## NuGet
[Add via NuGet](https://www.nuget.org/packages/King.Mapper.Generator)
```
PM> Install-Package King.Mapper.Generator
```
## Contributing

Contributions are always welcome. If you have find any issues, please report them to the [Github Issues Tracker](https://github.com/jefking/King.Mapper.Generator/issues?sort=created&direction=desc&state=open).

## Apache 2.0 License

Copyright 2014 Jef King

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

[http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.