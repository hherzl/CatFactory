using System;
using System.Collections.Generic;
using System.Data;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models;

public static class DatabaseTypeMapList
{
    public static List<DatabaseTypeMap> Default
        => new()
        {
            new()
            {
                DatabaseType = "bigint",
                ClrFullNameType = typeof(long).FullName,
                AllowClrNullable = true,
                ClrAliasType = "long",
                DbTypeEnum = DbType.Int64
            },
            new()
            {
                DatabaseType = "binary",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "bit",
                ClrFullNameType = typeof(bool).FullName,
                AllowClrNullable = true,
                ClrAliasType = "bool",
                DbTypeEnum = DbType.Boolean
            },
            new()
            {
                DatabaseType = "char",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "date",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.Date
            },
            new()
            {
                DatabaseType = "datetime",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime
            },
            new()
            {
                DatabaseType = "datetime2",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime2
            },
            new()
            {
                DatabaseType = "datetimeoffset",
                ClrFullNameType = typeof(DateTimeOffset).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTimeOffset
            },
            new()
            {
                DatabaseType = "decimal",
                AllowsPrecInDeclaration = true,
                AllowsScaleInDeclaration = true,
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "float",
                AllowsPrecInDeclaration = true,
                ClrFullNameType = typeof(double).FullName,
                AllowClrNullable = true,
                ClrAliasType = "double",
                DbTypeEnum = DbType.Double
            },
            new()
            {
                DatabaseType = "image",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "int",
                ClrFullNameType = typeof(int).FullName,
                AllowClrNullable = true,
                ClrAliasType = "int",
                DbTypeEnum = DbType.Int32
            },
            new()
            {
                DatabaseType = "money",
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "nchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.StringFixedLength
            },
            new()
            {
                DatabaseType = "ntext",
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "numeric",
                AllowsPrecInDeclaration = true,
                AllowsScaleInDeclaration = true,
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "nvarchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "real",
                ClrFullNameType = typeof(float).FullName,
                AllowClrNullable = true,
                ClrAliasType = "float",
                DbTypeEnum = DbType.Single
            },
            new()
            {
                DatabaseType = "rowversion",
                ClrFullNameType = typeof(byte[]).FullName,
                AllowClrNullable = true,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "smalldatetime",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime
            },
            new()
            {
                DatabaseType = "smallint",
                ClrFullNameType = typeof(short).FullName,
                AllowClrNullable = true,
                ClrAliasType = "short",
                DbTypeEnum = DbType.Int16
            },
            new()
            {
                DatabaseType = "smallmoney",
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "sql_variant",
                ClrFullNameType = typeof(object).FullName,
                ClrAliasType = "object",
                DbTypeEnum = DbType.Object
            },
            new()
            {
                DatabaseType = "text",
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "time",
                ClrFullNameType = typeof(TimeSpan).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.Time
            },
            new()
            {
                DatabaseType = "timestamp",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "tinyint",
                ClrFullNameType = typeof(byte).FullName,
                ClrAliasType = "byte",
                AllowClrNullable = true,
                DbTypeEnum = DbType.Byte
            },
            new()
            {
                DatabaseType = "uniqueidentifier",
                ClrFullNameType = typeof(Guid).FullName,
                DbTypeEnum = DbType.Guid
            },
            new()
            {
                DatabaseType = "varbinary",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "varchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "xml",
                DbTypeEnum = DbType.Xml
            }
        };

    public static List<DatabaseTypeMap> DefinitionWithCustomTypes
        => new()
        {
            new()
            {
                DatabaseType = "bigint",
                ClrFullNameType = typeof(long).FullName,
                AllowClrNullable = true,
                ClrAliasType = "long",
                DbTypeEnum = DbType.Int64
            },
            new()
            {
                DatabaseType = "binary",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "bit",
                ClrFullNameType = typeof(bool).FullName,
                AllowClrNullable = true,
                ClrAliasType = "bool",
                DbTypeEnum = DbType.Boolean
            },
            new()
            {
                DatabaseType = "char",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "date",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.Date
            },
            new()
            {
                DatabaseType = "datetime",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime
            },
            new()
            {
                DatabaseType = "datetime2",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime2
            },
            new()
            {
                DatabaseType = "datetimeoffset",
                ClrFullNameType = typeof(DateTimeOffset).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTimeOffset
            },
            new()
            {
                DatabaseType = "decimal",
                AllowsPrecInDeclaration = true,
                AllowsScaleInDeclaration = true,
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "float",
                AllowsPrecInDeclaration = true,
                ClrFullNameType = typeof(double).FullName,
                AllowClrNullable = true,
                ClrAliasType = "double",
                DbTypeEnum = DbType.Double
            },
            new()
            {
                DatabaseType = "image",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "int",
                ClrFullNameType = typeof(int).FullName,
                AllowClrNullable = true,
                ClrAliasType = "int",
                DbTypeEnum = DbType.Int32
            },
            new()
            {
                DatabaseType = "money",
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "nchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.StringFixedLength
            },
            new()
            {
                DatabaseType = "ntext",
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "numeric",
                AllowsPrecInDeclaration = true,
                AllowsScaleInDeclaration = true,
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "nvarchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "real",
                ClrFullNameType = typeof(float).FullName,
                AllowClrNullable = true,
                ClrAliasType = "float",
                DbTypeEnum = DbType.Single
            },
            new()
            {
                DatabaseType = "rowversion",
                ClrFullNameType = typeof(byte[]).FullName,
                AllowClrNullable = true,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "smalldatetime",
                ClrFullNameType = typeof(DateTime).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.DateTime
            },
            new()
            {
                DatabaseType = "smallint",
                ClrFullNameType = typeof(short).FullName,
                AllowClrNullable = true,
                ClrAliasType = "short",
                DbTypeEnum = DbType.Int16
            },
            new()
            {
                DatabaseType = "smallmoney",
                ClrFullNameType = typeof(decimal).FullName,
                AllowClrNullable = true,
                ClrAliasType = "decimal",
                DbTypeEnum = DbType.Decimal
            },
            new()
            {
                DatabaseType = "sql_variant",
                ClrFullNameType = typeof(object).FullName,
                ClrAliasType = "object",
                DbTypeEnum = DbType.Object
            },
            new()
            {
                DatabaseType = "text",
                ClrFullNameType = typeof(string).FullName,
                AllowClrNullable = false,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "time",
                ClrFullNameType = typeof(TimeSpan).FullName,
                AllowClrNullable = true,
                DbTypeEnum = DbType.Time
            },
            new()
            {
                DatabaseType = "timestamp",
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "tinyint",
                ClrFullNameType = typeof(byte).FullName,
                ClrAliasType = "byte",
                AllowClrNullable = true,
                DbTypeEnum = DbType.Byte
            },
            new()
            {
                DatabaseType = "uniqueidentifier",
                ClrFullNameType = typeof(Guid).FullName,
                DbTypeEnum = DbType.Guid
            },
            new()
            {
                DatabaseType = "varbinary",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(byte[]).FullName,
                ClrAliasType = "byte[]",
                DbTypeEnum = DbType.Binary
            },
            new()
            {
                DatabaseType = "varchar",
                AllowsLengthInDeclaration = true,
                ClrFullNameType = typeof(string).FullName,
                ClrAliasType = "string",
                DbTypeEnum = DbType.String
            },
            new()
            {
                DatabaseType = "xml",
                DbTypeEnum = DbType.Xml
            },
            new()
            {
                DatabaseType = "Name",
                IsUserDefined = true,
                ParentDatabaseType = "nvarchar"
            },
            new()
            {
                DatabaseType = "SpecialName",
                IsUserDefined = true,
                ParentDatabaseType = "nvarchar"
            },
            new()
            {
                DatabaseType = "Flag",
                IsUserDefined = true,
                ParentDatabaseType = "bit"
            }
        };
}
