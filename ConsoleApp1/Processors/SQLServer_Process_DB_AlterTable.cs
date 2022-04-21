using System;

namespace ConsoleApp1
{
    internal class SQLServer_Process_DB_AlterTable
    {
        internal static ReponseItem Generate(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"SQL SERVER/ALTER TABLE {c.EntityName}.sql";

            r.Text += $@"
            ALTER TABLE [dbo].[{c.EntityName}]
                ADD    ";

            foreach (var item in c.Columns)
            {
                r.Text += $@"[{item.Name}]   [varchar](200) NULL,
                ";
            }

            return r;
        }
    }
}