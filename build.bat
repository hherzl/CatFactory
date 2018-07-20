cls
set initialPath=%cd%
set srcPath=%cd%\CatFactory
set testPath=%cd%\CatFactory.Tests
cd %srcPath%
dotnet build
cd %testPath%
dotnet test
cd %srcPath%
dotnet pack
cd %initialPath%
pause
