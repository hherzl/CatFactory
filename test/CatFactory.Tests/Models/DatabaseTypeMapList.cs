using System;
using System.Collections.Generic;
using System.Data;
using CatFactory.Mapping;

namespace CatFactory.Tests.Models
{
    public static class DatabaseTypeMapList
    {
        public static List<DatabaseTypeMap> Definition
            => new List<DatabaseTypeMap>
            {
                new DatabaseTypeMap
                {
                    DatabaseType = "bigint",
                    ClrFullNameType = typeof(long).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "long",
                    DbTypeEnum = DbType.Int64
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "binary",
                    ClrFullNameType = typeof(byte[]).FullName,
                    ClrAliasType = "byte[]",
                    DbTypeEnum = DbType.Binary
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "bit",
                    ClrFullNameType = typeof(bool).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "bool",
                    DbTypeEnum = DbType.Boolean
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "char",
                    AllowsLengthInDeclaration = true,
                    ClrFullNameType = typeof(string).FullName,
                    AllowClrNullable = false,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.String
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "date",
                    ClrFullNameType = typeof(DateTime).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.Date
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "datetime",
                    ClrFullNameType = typeof(DateTime).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.DateTime
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "datetime2",
                    ClrFullNameType = typeof(DateTime).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.DateTime2
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "datetimeoffset",
                    ClrFullNameType = typeof(DateTimeOffset).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.DateTimeOffset
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "decimal",
                    AllowsPrecInDeclaration = true,
                    AllowsScaleInDeclaration = true,
                    ClrFullNameType = typeof(decimal).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "decimal",
                    DbTypeEnum = DbType.Decimal
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "float",
                    AllowsPrecInDeclaration = true,
                    ClrFullNameType = typeof(double).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "double",
                    DbTypeEnum = DbType.Double
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "image",
                    ClrFullNameType = typeof(byte[]).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "byte[]",
                    DbTypeEnum = DbType.Binary
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "int",
                    ClrFullNameType = typeof(int).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "int",
                    DbTypeEnum = DbType.Int32
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "money",
                    ClrFullNameType = typeof(decimal).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "decimal",
                    DbTypeEnum = DbType.Decimal
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "nchar",
                    AllowsLengthInDeclaration = true,
                    ClrFullNameType = typeof(string).FullName,
                    AllowClrNullable = false,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.StringFixedLength
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "ntext",
                    ClrFullNameType = typeof(string).FullName,
                    AllowClrNullable = false,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.String
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "numeric",
                    AllowsPrecInDeclaration = true,
                    AllowsScaleInDeclaration = true,
                    ClrFullNameType = typeof(decimal).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "decimal",
                    DbTypeEnum = DbType.Decimal
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "nvarchar",
                    AllowsLengthInDeclaration = true,
                    ClrFullNameType = typeof(string).FullName,
                    AllowClrNullable = false,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.String
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "real",
                    ClrFullNameType = typeof(float).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "float",
                    DbTypeEnum = DbType.Single
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "rowversion",
                    ClrFullNameType = typeof(byte[]).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "byte[]",
                    DbTypeEnum = DbType.Binary
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "smalldatetime",
                    ClrFullNameType = typeof(DateTime).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.DateTime
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "smallint",
                    ClrFullNameType = typeof(short).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "short",
                    DbTypeEnum = DbType.Int16
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "smallmoney",
                    ClrFullNameType = typeof(decimal).FullName,
                    AllowClrNullable = true,
                    ClrAliasType = "decimal",
                    DbTypeEnum = DbType.Decimal
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "sql_variant",
                    ClrFullNameType = typeof(object).FullName,
                    ClrAliasType = "object",
                    DbTypeEnum = DbType.Object
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "text",
                    ClrFullNameType = typeof(string).FullName,
                    AllowClrNullable = false,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.String
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "time",
                    ClrFullNameType = typeof(TimeSpan).FullName,
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.Time
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "timestamp",
                    ClrFullNameType = typeof(byte[]).FullName,
                    ClrAliasType = "byte[]",
                    DbTypeEnum = DbType.Binary
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "tinyint",
                    ClrFullNameType = typeof(byte).FullName,
                    ClrAliasType = "byte",
                    AllowClrNullable = true,
                    DbTypeEnum = DbType.Byte
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "uniqueidentifier",
                    ClrFullNameType = typeof(Guid).FullName,
                    DbTypeEnum = DbType.Guid
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "varbinary",
                    AllowsLengthInDeclaration = true,
                    ClrFullNameType = typeof(byte[]).FullName,
                    ClrAliasType = "byte[]",
                    DbTypeEnum = DbType.Binary
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "varchar",
                    AllowsLengthInDeclaration = true,
                    ClrFullNameType = typeof(string).FullName,
                    ClrAliasType = "string",
                    DbTypeEnum = DbType.String
                },
                new DatabaseTypeMap
                {
                    DatabaseType = "xml",
                    DbTypeEnum = DbType.Xml
                }
            };
    }
}
