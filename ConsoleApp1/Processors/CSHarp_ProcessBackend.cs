using System;

namespace ConsoleApp1
{
    internal class CSHarp_ProcessBackend
    {
        public CSHarp_ProcessBackend()
        {
        }

        internal static ReponseItem Controller(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"BACKEND/{c.EntityName}.controller.cs";

            r.Text += $@"
            using Microsoft.AspNetCore.Mvc;
            using {c.ProjectName}Context.API.DataAccessEntityFramework;
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Threading.Tasks;

            namespace {c.ProjectName}.Controllers
            {{
                [Route(""api/[controller]"")]
                [ApiController]
                public class {c.EntityName}Controller : ControllerBase
                {{
                    // GET: api/<{c.EntityName}Controller>
                    [HttpGet]
                    public IEnumerable<{c.EntityName}> Get()
                    {{
                        {c.ProjectName}Context db = new AppHogar2022Context();
                        return db.{c.EntityName}.ToList();
                    }}

                    // GET api/<{c.EntityName}Controller>/5
                    [HttpGet(""{{id}}"")]
                    public {c.EntityName} Get(int id)
                    {{
                        {c.ProjectName}Context db = new AppHogar2022Context();
                        return db.{c.EntityName}.Where(x => x.{c.Columns[0].Name} == id).FirstOrDefault();
                    }}

                    // POST api/<{c.EntityName}Controller>
                    [HttpPost]
                    public void Post([FromBody] {c.EntityName} value)
                    {{
                        {c.ProjectName}Context db = new AppHogar2022Context();
                        db.{c.EntityName}.Add(value);
                        db.SaveChanges();
                    }}

                    // PUT api/<{c.EntityName}Controller>/5
                    [HttpPut(""{{id}}"")]
                    public void Put(int id, [FromBody] {c.EntityName} value)
                    {{
                        {c.ProjectName}Context db = new AppHogar2022Context();
                        db.{c.EntityName}.Attach(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        db.SaveChanges();
                    }}

                    // DELETE api/<{c.EntityName}Controller>/5
                    [HttpDelete(""{{id}}"")]
                    public void Delete(int id)
                    {{
                        {c.ProjectName}Context db = new AppHogar2022Context();
                        var item = db.{c.EntityName}.Where(x => x.{c.Columns[0].Name} == id).FirstOrDefault();
                        db.{c.EntityName}.Remove(item);
                        db.SaveChanges();
                    }}
                }}
            }}

            ";

            return r;
        }
    }
}