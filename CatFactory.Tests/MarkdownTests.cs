using System.IO;
using CatFactory.Markdown;
using Xunit;

namespace CatFactory.Tests
{
    public class MarkdownTests
    {
        [Fact]
        public void TestCatFactoryReadMeMd()
        {
            var readme = new MdDocument();

            readme.H1("CatFactory ==^^==");

            readme.H2("What Is CatFactory?");

            readme.WriteLine("CatFactory it's a scaffolding engine for .NET Core built in C#.");

            readme.H2("How it Works?");

            readme.WriteLine("The concept behind CatFactory is import an existing database from SQL Server instance, then scaffolding a target technology.");

            readme.WriteLine("Also, We can replace the database from SQL Server instance with an in memory database.");

            readme.WriteLine("Currently, the following technologies are supported:");

            readme.UnorderedList(
                "Entity Framework Core",
                "ASP.NET Core",
                "Dapper"
            );

            readme.WriteLine("To understand the scope for CatFactory, in few words CatFactory is the core, to have more packages we can create them with this naming convention: CatFactory.PackageName.");

            readme.WriteLine("The flow to import an existing database is:");

            readme.OrderedList(
                "Create Database Factory",
                "Import Database",
                "Create instance of Project (Entity Framework Core, Dapper, etc)",
                "Build Features (One feature per schema)",
                "Scaffold objects, these methods read all objects from database and create instances for code builders"
                );

            readme.H2("Roadmap");

            readme.WriteLine("There are improvements for CatFactory on road:");

            readme.UnorderedList(
                "Scaffolding Services Layer",
                "Dapper Integration for ASP.NET Core",
                "MD files",
                "Scaffolding C# Client for ASP.NET Web API",
                "Scaffolding Unit Tests for ASP.NET Core",
                "Scaffolding Integration Tests for ASP.NET Core",
                "Scaffolding Angular"
            );

            readme.H2("Concepts behind CatFactory");

            readme.H3("Database Type Map");

            readme.WriteLine("One of things I don't like to get equivalent between SQL data type for CLR is use magic strings, after of review the more \"fancy\" way to resolve a type equivalence is to have a class that allows to know the equivalence between SQL data type and CLR type.");

            readme.WriteLine("This concept was created from this matrix: {0}.", Md.Link("SQL Server Data Type Mappings", "https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings"));

            readme.WriteLine("Using this matrix as reference, now CatFactory has a class named DatabaseTypeMap. Database class contains a property with all mappings named DatebaseTypeMaps, so this property is filled by Import feature for SQL Server package.");

            readme.CodeBlock("csharp",
                "public class DatabaseTypeMap",
                "{",
                "    public string DatabaseType { get; set; }",
                "",
                "    public bool AllowsLengthInDeclaration { get; set; }",
                "",
                "    public bool AllowsPrecInDeclaration { get; set; }",
                "",
                "    public bool AllowsScaleInDeclaration { get; set; }",
                "",
                "    public string ClrFullNameType { get; set; }",
                "",
                "    public bool HasClrFullNameType { get; }",
                "",
                "    public string ClrAliasType { get; set; }",
                "",
                "    public bool HasClrAliasType { get; }",
                "",
                "    public bool AllowClrNullable { get; set; }",
                "",
                "    public DbType DbTypeEnum { get; set; }",
                "",
                "    public bool IsUserDefined { get; set; }",
                "",
                "    public string ParentDatabaseType { get; set; }",
                "",
                "    public string Collation { get; set; }",
                "}"
                );

            readme.WriteLine("DatabaseTypeMap is the class to represent database type definition, for database instance we need to create a collection of DatabaseTypeMap class to have a matrix to resolve data types.");

            readme.WriteLine("Suppose there is a class with name DatabaseTypeMapList, this class has a property to get data types. Once we have imported an existing database we can resolve data types:");

            readme.WriteLine("Resolve without extension methods:");

            readme.CodeBlock("csharp",
                "// Get mappings",
                "var dataTypes = database.DatabaseTypeMaps;",
                "",
                "// Resolve CLR type",
                "var mapsForString = dataTypes.Where(item => item.ClrType == typeof(string)).ToList();",
                "",
                "// Resolve SQL Server type",
                "var mapForVarchar = dataTypes.FirstOrDefault(item => item.DatabaseType == \"varchar\");"
            );

            readme.WriteLine("Resolve with extension methods:");

            readme.CodeBlock("csharp",
                "// Get database type",
                "var varcharDataType = database.ResolveType(\"varchar\");",
                "",
                "// Resolve CLR",
                "var mapForVarchar = varcharDataType.GetClrType();"
            );

            readme.WriteLine("SQL Server allows to define data types, suppose the database instance has a data type defined by user with name Flag, Flag data type is a bit, bool in C#. Import method retrieve user data types, so in DatabaseTypeMaps collection we can search the parent data type for Flag:");

            readme.H3("Project Selection");

            readme.WriteLine("A project selection is a limit to apply settings for objects that match with pattern.");

            readme.WriteLine("GlobalSelection is the default selection for project, contains a default instance of settings.");

            readme.WriteLine("Patterns:");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Pattern", "Scope"),
                Rows =
                {
                    new MdTableRow("Sales.OrderHeader", "Applies for specific object with name Sales.OrderHeader"),
                    new MdTableRow("Sales.\\*", "Applies for all objects inside of Sales schema"),
                    new MdTableRow("\\*.OrderHeader", "Applies for all objects with name Order with no matter schema"),
                    new MdTableRow("\\*.\\*", "Applies for all objects, this is the global selection")
                }
            });

            readme.WriteLine("Sample:");

            readme.CodeBlock("csharp",
                "// Apply settings for Project",
                "project.GlobalSelection(settings =>",
                "{",
                "    settings.ForceOverwrite = true;",
                "    settings.AuditEntity = new AuditEntity(\"CreationUser\", \"CreationDateTime\", \"LastUpdateUser\", \"LastUpdateDateTime\");",
                "    settings.ConcurrencyToken = \"Timestamp\";",
                "});",
                "",
                "// Apply settings for specific object",
                "project.Select(\"Sales.OrderHeader\", settings =>",
                "{",
                "    settings.EntitiesWithDataContracts = true;",
                "});"
            );

            readme.H3("Event Handlers to Scaffold");

            readme.WriteLine("In order to provide a more flexible way to scaffold, there are two delegates in CatFactory, one to perform an action before of scaffolding and another one to handle and action after of scaffolding.");

            readme.CodeBlock("csharp", "// Add event handlers to before and after of scaffold",
            "",
            "project.ScaffoldingDefinition += (source, args) =>",
            "{",
            "    // Add code to perform operations with code builder instance before to create code file",
            "};",
            "",
            "project.ScaffoldedDefinition += (source, args) =>",
            "{",
            "    // Add code to perform operations after of create code file",
            "};");

            readme.H2("Packages");

            readme.H3("CatFactory");

            readme.WriteLine("This package provides all definitions for CatFactory engine, this is the core for child packages.");

            readme.H4("Namespaces");

            readme.WriteLine("{0}: Contains objects to perform code generation.", Md.Bold("CodeFactory"));

            readme.WriteLine("{0}: Contains objects for diagnostics.", Md.Bold("Diagnostics"));

            readme.WriteLine("{0}: Contains objects for markup languages.", Md.Bold("Markup"));

            readme.WriteLine("{0}: Contains objects to modeling definitions: classes, interfaces and enums.", Md.Bold("ObjectOrientedProgramming"));

            readme.WriteLine("{0}: Contains objects for ORM: database, tables, views, scalar functions, table functions and stored procedures.", Md.Bold("ObjectRelationalMapping"));

            readme.H3("CatFactory.SqlServer");

            readme.WriteLine("This packages contains logic to import existing databases from SQL Server instances.");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Object", "Supported"),
                Rows =
                {
                    new MdTableRow("Tables", "Yes"),
                    new MdTableRow("Views", "Yes"),
                    new MdTableRow("Scalar Functions", "Yes"),
                    new MdTableRow("Table Functions", "Yes"),
                    new MdTableRow("Stored Procedures", "Yes"),
                    new MdTableRow("Sequences", "Yes"),
                    new MdTableRow("Extended Properties", "Yes"),
                    new MdTableRow("Data Types", "Yes")
                }
            });

            readme.H3("CatFactory.NetCore");

            readme.WriteLine("This package contains code builders and definitions for .NET Core (C#).");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Object", "Members", "Supported"),
                Rows =
                {
                    new MdTableRow("Struct", "All", "Not yet"),
                    new MdTableRow("Interface", "Inheritance", "Yes"),
                    new MdTableRow("Interface", "Events", "Yes"),
                    new MdTableRow("Interface", "Properties", "Yes"),
                    new MdTableRow("Interface", "Methods", "Yes"),
                    new MdTableRow("Class", "Inheritance", "Yes"),
                    new MdTableRow("Class", "Events", "Yes"),
                    new MdTableRow("Class", "Fields", "Yes"),
                    new MdTableRow("Class", "Properties", "Yes"),
                    new MdTableRow("Class", "Methods", "Yes"),
                    new MdTableRow("Enum", "Options", "Yes")
                }
            });

            readme.H3("CatFactory.EntityFrameworkCore");

            readme.WriteLine("This package provides scaffolding for Entity Framework Core.");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Object", "Supported"),
                Rows =
                {
                    new MdTableRow("Class for table", "Yes"),
                    new MdTableRow("Class for view", "Yes"),
                    new MdTableRow("Class for table function", "Yes"),
                    new MdTableRow("Class for stored procedure result", "Not yet"),
                    new MdTableRow("Class for DbContext", "Yes"),
                    new MdTableRow("Class for entity configuration (table)", "Yes"),
                    new MdTableRow("Class for entity configuration (view)", "Yes"),
                    new MdTableRow("Interface for Repository", "Yes"),
                    new MdTableRow("Class for Repository", "Yes"),
                    new MdTableRow("Method for scalar function invocation", "Yes"),
                    new MdTableRow("Method for table function invocation", "Yes"),
                    new MdTableRow("Method for stored procedure invocation", "Not yet")
                }
            });

            readme.H4("Entity Framework Core 2 Feature Chart");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Category", "Feature", "Supported"),
                Rows =
                {
                    new MdTableRow("Modeling", "Table splitting", "Not yet"),
                    new MdTableRow("Modeling", "Owned types", "Not yet"),
                    new MdTableRow("Modeling", "Model-level query filters", "Not yet"),
                    new MdTableRow("Modeling", "Database scalar function mapping", "Not yet"),
                    new MdTableRow("Modeling", "Self-contained type configuration for code first", "Not yet"),
                    new MdTableRow("High Performance", "DbContext pooling", "Not yet"),
                    new MdTableRow("High Performance", "Explicitly compiled queries", "Not yet")
                }
            });

            readme.WriteLine(Md.Link("New features in EF Core 2.0", "https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-2.0"));

            readme.H3("CatFactory.AspNetCore");

            readme.WriteLine("This package provides scaffolding for Asp .NET Core.");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Feature", "Supported"),
                Rows =
                {
                    new MdTableRow("Controllers", "Yes"),
                    new MdTableRow("Requests", "Yes"),
                    new MdTableRow("Responses", "Yes"),
                    new MdTableRow("Scaffold Client", "Not yet"),
                    new MdTableRow("Help Page for Web API", "Not yet"),
                    new MdTableRow("Unit Tests", "Not yet"),
                    new MdTableRow("Integration Tests", "Not yet")
                }
            });

            readme.H3("CatFactory.Dapper");

            readme.WriteLine("This package provides scaffolding for Dapper.");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Object", "Supported"),
                Rows =
                {
                    new MdTableRow("Table", "Yes"),
                    new MdTableRow("View", "Yes"),
                    new MdTableRow("Scalar Function", "Yes"),
                    new MdTableRow("Table Function", "Yes"),
                    new MdTableRow("Stored Procedures", "Yes"),
                    new MdTableRow("Sequences", "Yes")
                }
            });

            readme.H3("CatFactory.TypeScript");

            readme.WriteLine("This package provides scaffolding for Type Script.");

            readme.Write(new MdTable
            {
                Header = new MdTableHeader("Object", "Feature", "Supported"),
                Rows =
                {
                    new MdTableRow("Interface", "Inheritance", "Yes"),
                    new MdTableRow("Interface", "Fields", "Yes"),
                    new MdTableRow("Interface", "Properties", "Yes"),
                    new MdTableRow("Interface", "Methods", "Yes"),
                    new MdTableRow("Class", "Inheritance", "Yes"),
                    new MdTableRow("Class", "Fields", "Yes"),
                    new MdTableRow("Class", "Constructors", "Yes"),
                    new MdTableRow("Class", "Properties", "Yes"),
                    new MdTableRow("Class", "Methods", "Yes"),
                    new MdTableRow("Module", "Methods", "Yes")
                }
            });

            readme.H2("History");

            readme.WriteLine("In 2005 year, I was on my college days and I worked on my final project that included a lot of tables, for those days C# didn't have automatic properties also I worked on store procedures that included a lot of columns, I thought if there was a way to generate all that code because it was repetitive and I wasted time in wrote a lot of code.");

            readme.WriteLine("In 2006 beggining I've worked for a company and I worked in a prototype to generate code but I didn't have experience and I was a junior developer, so I developed a version in WebForms that didn't allow to save the structure ha,ha,ha that project it was my first project in C# because I came from VB world but I bought a book about Web Services in DotNet and that book used C# code, that was new for me but it got me a very important idea, learn C# and I wrote all first code generation form in C#.");

            readme.WriteLine("Later, there was a prototype of Entity for SQL, the grandfather of entity framework and I develop a simple ORM because I had table class and other classes such as Column, so after of reviewed Entity for SQL I decided to add the logic to read database and provide a simple way to read the database also of code generation.");

            readme.WriteLine("In 2008 I built the first ORM based on my code generation engine, in that time it was called F4N1, I worked on an ORM must endure different databases engines such as SQL Server, Sybase and Oracle; so I generated a lot of classes with that engine, for that time the automated unit tests did not exist, I had a webform page that generated that code ha,ha,ha I know it was ugly and crappy but in that time that was my knowledge allowed me.");

            readme.WriteLine("In 2011 I worked on a demo for a person that worked in his company and that person used another tool for code generation, so my code generation engine wasn't use for his work.");

            readme.WriteLine("In 2012 I worked for a company needed to rebuilt all system with new technologies (ASP.NET MVC and Entity Framework) so I invested time about MVC and EF learning but as usual, there isn't time for that ha,ha,ha and again my code generation it wasn't considered for that upgrade =(");

            readme.WriteLine("In 2014, I thought to make a nuget package to my code generation but in those days I didn't have the focus to accomplish that feature and always I used my code generation as a private tool, in some cases I shared my tool with some coworkers to generate code and reduce the time for code writing.");

            readme.WriteLine("In 2016, I decided to create a nuget package and integrates with EF Core, using all experience from 10 years ago :D Please remember that from the beginning I was continuing improve the way of code generation, my first code was a crap but with the timeline I've improved the design and naming for objects.");

            readme.WriteLine("Why I named CatFactory? It was I had a cat, her name was Mindy and that cat had manny kittens (sons), so the basic idea it was the code generation engine generates the code as fast Mindy provided kittens ha,ha,ha");

            readme.H2("Trivia");

            readme.UnorderedList(
                "The name for this framework it was F4N1 before than CatFactory",
                "Framework's name is related to kitties",
                "Import logic uses sp_help stored procedure to retrieve the database object's definition, I learned that in my database course at college",
                "Load mapping for entities with MEF, it's inspired in \"OdeToCode\" (Scott Allen) article for Entity Framework 6.x",
                "Expose all settings in one class inside of project's definition is inspired on DevExpress settings for Web controls (Web Forms)",
                "There are three alpha versions for CatFactory as reference for Street Fighter Alpha fighting game.",
                "There will be two beta versions for CatFactory: Sun and Moon as reference for characters from The King of Fighters game: Kusanagi Kyo and Yagami Iori."
                );

            readme.H2("Quick Starts");

            readme.WriteLine(
                Md.Link("Scaffolding View Models with CatFactory", "https://www.codeproject.com/Tips/1164636/Scaffolding-View-Models-with-CatFactory")
                );

            readme.WriteLine(
                Md.Link("Scaffolding Entity Framework Core 2 with CatFactory", "https://www.codeproject.com/Articles/1160615/Scaffolding-Entity-Framework-Core-with-CatFactory")
                );

            readme.WriteLine(
                Md.Link("Scaffolding Dapper with CatFactory", "https://www.codeproject.com/Articles/1213355/Scaffolding-Dapper-with-CatFactory")
                );

            readme.WriteLine(
                Md.Link("Scaffolding ASP.NET Core 2 with CatFactory", "https://www.codeproject.com/Tips/1229909/Scaffolding-ASP-NET-Core-with-CatFactory")
                );

            File.WriteAllText("C:\\Temp\\CatFactory\\CatFactory.README.md", readme.ToString());
        }

        [Fact]
        public void TestCodeChallengeReadMeMd()
        {
            var readme = new MdDocument();

            readme.H1("CodeChallenge");

            readme.WriteLine("This is the repository for {0} Code Challenge.", Md.Italics("Snacks API"));

            readme.H2("Technologies");

            readme.WriteLine("This solution is built with the following technologies:");

            readme.H3("Back-end");

            readme.UnorderedList("ASP.NET Core", "Entity Framework Core");

            readme.H3("Front-end");

            readme.UnorderedList("Angular 6", "Angular Material 6");

            readme.H2("Executing Solution");

            readme.H3("Prerequisites");

            readme.WriteLine("In order to run this solution, install the following components:");

            readme.UnorderedList(".NET Core", "NodeJS", "Angular CLI");

            readme.H3("First Run");

            readme.WriteLine("If is the first run, execute {0} file inside of {1} directory.", Md.Italics("build.bat"), Md.Italics("SourceCode"));

            readme.WriteLine("Then execute {0} file from {1} directory.", Md.Italics("deploy.bat"), Md.Italics("Database"));

            readme.WriteLine(Md.Italics("To deploy database script, you need access to SQL Server instance."));

            readme.H3("Running Solution");

            readme.WriteLine("Execute {0} file inside of {1} directory.", Md.Italics("run.bat"), Md.Italics("SourceCode"));

            readme.UnorderedList(
                string.Format("{0} project runs on {1} port.", Md.Bold("AuthAPI"), Md.Italics("5600")),
                string.Format("{0} project runs on {1} port.", Md.Bold("API"), Md.Italics("5700")),
                string.Format("Angular client runs on {0} port.", Md.Italics("4200"))
                );

            readme.H4("API Help Page");

            readme.WriteLine("Open {0} url in browser:", Md.Italics("http://localhost:5700/swagger/index.html"));

            readme.H4("Client");

            readme.WriteLine(Md.Image("Help Api Page", "HelpApiPage.jpg"));

            readme.H3("Tests");

            readme.WriteLine("There is a collection for Postman Inside of {0} directory.", Md.Italics("Tests"));

            File.WriteAllText("C:\\Temp\\CatFactory\\codechallenge.README.md", readme.ToString());
        }

        [Fact]
        public void TestTestsReadMeMd()
        {
            var readme = new MdDocument();

            readme.H1("Tests for Snacks API");

            readme.WriteLine("{0} file contains the following tests for {1}:", Md.Italics("Store API.postman_collection.json"), Md.Bold("Snacks API"));

            readme.Write(
                new MdTable
                {
                    Header = new MdTableHeader("Name", "Requires Authentication", "Role", "Description"),
                    Rows =
                    {
                        new MdTableRow("Get Products", "No", "None", "Retrieves products"),
                        new MdTableRow("Get Products by Name", "No", "None", "Retrieves products filtering by name")
                    }
                }
            );

            File.WriteAllText("C:\\Temp\\CatFactory\\tests.README.md", readme.ToString());
        }

        [Fact]
        public void TestToDoMd()
        {
            var readme = new MdDocument();

            readme.H1("To Do");

            readme.TaskList(
                new MdTask(true, "First"),
                new MdTask(false, "Second"),
                new MdTask(true, "Third")
            );

            File.WriteAllText("C:\\Temp\\CatFactory\\tasks.README.md", readme.ToString());
        }
    }
}
