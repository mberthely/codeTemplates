using System;

namespace ConsoleApp1
{
    public  class CodeProcessor
    {
        public CodeProcessor()
        {
        }

        public  GeneratorResponse Process(TableConfigItem c)
        {
            var p = new ProcessorMain();
            return p.GenerateCode(c);
        }
    }
}