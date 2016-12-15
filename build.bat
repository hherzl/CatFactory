cls
set initialPath=%cd%
set srcPath=%cd%\src\CatFactory
set testPath=%cd%\test\CatFactory.Tests
cd %srcPath%
dotnet build
cd %testPath%
dotnet test
cd %srcPath%
dotnet pack
cd %initialPath%
pause
