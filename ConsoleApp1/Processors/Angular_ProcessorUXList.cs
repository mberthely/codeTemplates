using ConsoleApp1.Extensions;
using System;

namespace ConsoleApp1
{
    internal class Angular_ProcessorUXList
    {
        public Angular_ProcessorUXList()
        {
        }

        internal static ReponseItem MODEL_GenerateModel_TEMPLATE(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"data-{c.EntityName.ToLower()}-service.service.ts";

            r.Text += $@"

            ";

            return r;
        }

        internal static ReponseItem MODEL_GenerateModel(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"models/{c.EntityName.ToLower()}.ts";

            r.Text += $@"
            export class {c.EntityName} {{";
            foreach (var item in c.Columns)
            {
                r.Text += $@"
                {item.Name.ToCamelCase()}: string | undefined;";
            }
            r.Text += @"
            }";

            return r;
        }

        internal static ReponseItem SERVICE_GenerateAPIService(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"services/data-{c.EntityName.ToLower()}-service.service.ts";

            r.Text += $@"
            import {{ HttpClient }} from '@angular/common/http';
            import {{ Injectable }} from '@angular/core';
            import {{ Observable }} from 'rxjs';
            import {{ {c.EntityName} }} from '../models/{c.EntityName.ToLower()}';

            @Injectable({{ providedIn: 'root' }})
            export class Data{c.EntityName}Service {{

              path = 'https://localhost:44308/api/';

              constructor(private http: HttpClient) {{ }}

              get{c.EntityName}(): Observable<{c.EntityName}[]> {{
                return this.http.get<{c.EntityName}[]>(this.path + '{c.EntityName.ToLower()}');
              }}

              get{c.EntityName}ById(id: string): Observable<{c.EntityName}> {{
                return this.http.get<{c.EntityName}>(this.path + `{c.EntityName.ToLower()}/${{id}}`);
              }}

              save{c.EntityName}({c.EntityName.ToLower()}: {c.EntityName}): Observable<any> {{
                return this.http.post<{c.EntityName}>(this.path + '{c.EntityName.ToLower()}', {c.EntityName.ToLower()});
              }}

              eliminar{c.EntityName}(id: number): Observable<any> {{
                return this.http.delete(this.path + '{c.EntityName.ToLower()}/' + id);
              }}

              update{c.EntityName}({c.EntityName.ToLower()}: {c.EntityName}): Observable<any> {{
                return this.http.put(this.path + '{c.EntityName.ToLower()}/' + {c.EntityName.ToLower()}.{c.Columns[0].Name}, {c.EntityName.ToLower()});
              }}
            }}

            ";

            return r;
        }

        public ReponseItem LIST_GenerateSCSS(TableConfigItem c)
        {
            return new ReponseItem();
        }
    }
}