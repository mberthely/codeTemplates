using System;

namespace ConsoleApp1
{
    internal class SQLServer_ProcessDB
    {
        public SQLServer_ProcessDB()
        {
        }

        internal static ReponseItem CREATE_Table(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"SQL SERVER/{c.EntityName}.sql";

            r.Text += $@"
            CREATE TABLE [dbo].[{c.EntityName}](";

            foreach (var item in c.Columns)
            {
                if (item.IsID)
                {
                    r.Text += $@"
                    [{item.Name}]                     [int] IDENTITY(1, 1) NOT NULL,";
                }
                else
                {
                    r.Text += $@"
                    [{item.Name}]                     [varchar](200) NULL,";
                }
            }

            r.Text += $@"
            )";

            return r;
        }
    }
}