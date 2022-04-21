using ConsoleApp1.Extensions;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class ProcessorMain
    {
        public ProcessorMain()
        {
        }

        internal GeneratorResponse GenerateCode(TableConfigItem c)
        {
            var response = new GeneratorResponse();
            response.responses = new List<ReponseItem>();

            response.responses.Add(Angular_UX_List_TS.LIST_GenerateTS(c));
            response.responses.Add(Angular_UX_List_HTML.LIST_GenerateHTML(c));
            response.responses.Add(Angular_ProcessorUXList.SERVICE_GenerateAPIService(c));
            response.responses.Add(Angular_ProcessorUXList.MODEL_GenerateModel(c));
            response.responses.Add(Angular_ProcessorUXCreate.CREATE_GenerateHTML(c));
            response.responses.Add(Angular_ProcessorUXCreate.CREATE_GenerateTS(c));
            response.responses.Add(HTML_ProcessUXGeneral.LinkMenu(c));
            response.responses.Add(SQLServer_ProcessDB.CREATE_Table(c));
            response.responses.Add(SQLServer_Process_DB_AlterTable.Generate(c));
            response.responses.Add(CSHarp_ProcessBackend.Controller(c));

            return response;
        }
    }
}