using ConsoleApp1.Extensions;

namespace ConsoleApp1
{
    internal class Angular_UX_List_TS
    {

        public static ReponseItem LIST_GenerateTS(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = c.EntityName.ToLower() + "/" + c.EntityName.ToLower() + ".component.ts";

            r.Text += $@"

            filterForm = this.fb.group({{";
            foreach (var item in c.Columns)
            {
                r.Text += $@" {item.Name.ToCamelCase()}:[''],
                ";
            };
            
            r.Text += $@"
            }});

            displayedColumns: string[] = [";
            foreach (var item in c.Columns)
            {
                r.Text += $@"
                    '{item.Name}',";
            }
            r.Text += $@"
                'acciones',
            ]

            dataSource = new MatTableDataSource<{c.EntityName}>([]);

              constructor(
                public dialog: MatDialog,
                private service: Data{c.EntityName}Service,
                private router: Router,
                private fb: FormBuilder,
              ) {{ }}

              ngOnInit() : void {{
                this.cargar{c.EntityName}();
                }}

                cargar{c.EntityName}() : void {{
                this.service
                  .get{c.EntityName}()
                  .subscribe((response) => (this.dataSource.data = response));
                }}

                navegarAgregar{c.EntityName}() : void {{
                this.router.navigate(['{c.EntityName}-agregar']);
              }}

            filtrar() {{
                this.dataSource.filterPredicate = this.customFilterPredicate();
                this.dataSource.filter = this.filterForm.value;
            }}

            customFilterPredicate() {{
                const myFilterPredicate = (data: any, filter: any): boolean => {{
                    return";

            foreach (var item in c.Columns)
            {
                r.Text += $@" 
                    this.checkFilter(data.{item.Name.ToCamelCase()}, filter.{item.Name.ToCamelCase()}) &&
                ";
            }

             r.Text += $@"   
                // Arreglar return como corresponde
                }}
                return myFilterPredicate;
            }}

            checkFilter(a: any, b: any): boolean {{
                return a.toString().toLowerCase().trim().indexOf(b.toLowerCase()) !== -1
            }}

              eliminar(id: number) : void {{
                this.service.eliminar{c.EntityName}(id).subscribe(() => {{
                  this.cargar{c.EntityName}();
                }});
              }}

            editar(item: any): void
            {{
                this.router.navigate(['{c.EntityName}-agregar'], {{ queryParams: {{ id: item.{c.EntityName}Id }} }});
            }}
        }}
        ";

            return r;
        }
    }
}