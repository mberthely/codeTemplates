using System.Collections.Generic;

namespace ConsoleApp1
{
    public class TableConfigItem
    {
        public TableConfigItem()
        {
        }

        public string ProjectName { get; internal set; }
        public string EntityName { get; internal set; }
        public List<Column> Columns { get; internal set; }
    }
}