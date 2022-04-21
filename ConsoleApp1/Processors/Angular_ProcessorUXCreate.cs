using ConsoleApp1.Extensions;
using System;

namespace ConsoleApp1
{
    internal class Angular_ProcessorUXCreate
    {
        public Angular_ProcessorUXCreate()
        {
        }

        internal static ReponseItem CREATE_GenerateTS(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"{c.EntityName.ToLower()}/create/{c.EntityName.ToLower()}.component.ts";
            
            r.Text += $@"
            import {{ Component,OnInit }} from '@angular/core';
            import {{ FormBuilder,Validators }} from '@angular/forms';
            import {{ ActivatedRoute,Params, Router }} from '@angular/router';
            import {{ ApiDataAccessService }} from 'src/app/services/api-data-access.service';

            @Component({{
              selector: 'app-{c.EntityName.ToSepararConGuionMedioLowercase()}-agregar',
              templateUrl: './{c.EntityName.ToSepararConGuionMedioLowercase()}-agregar.component.html',
              styleUrls: ['./{c.EntityName.ToSepararConGuionMedioLowercase()}-agregar.component.scss'],
            }})

            export class {c.EntityName}AgregarComponent implements OnInit {{
              {c.EntityName.ToLower()}Form = this.fb.group({{";

            foreach (var item in c.Columns)
            {
                r.Text += $@"
                {item.Name.ToCamelCase()}: [''],";
            }
              
            r.Text += $@"}});

              id: string | null = null;

              constructor(
                private dataService: Data{c.EntityName}Service,
                private router: Router,
                private fb: FormBuilder,
                private route: ActivatedRoute
              ) {{ }}

              ngOnInit(): void {{
                const ID = 'id';

                this.route.queryParams
                  .subscribe((params: Params) => {{
                    this.id = params[ID];
                    if (this.id) {{
                      this.dataService.get{c.EntityName}ById(this.id).subscribe(item => {{
                        this.{c.EntityName.ToLower()}Form.patchValue(item);
                      }});
                    }}
                  }});
              }}

              guardar(): void {{
                if (this.{c.EntityName.ToLower()}Form.get('{c.EntityName.ToLower()}Id')?.value) {{
                  this.dataService.update{c.EntityName}(this.{c.EntityName.ToLower()}Form.value).subscribe(() => {{
                    this.router.navigate(['{c.EntityName.ToLower()}']);
                  }});
                }}
                else {{
                  this.dataService.save{c.EntityName}(this.{c.EntityName.ToLower()}Form.value).subscribe(() => {{
                    this.router.navigate(['{c.EntityName.ToLower()}']);
                  }});
                }}
              }}
            }}

            ";

            return r;
        }

        internal static ReponseItem CREATE_GenerateHTML(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"{c.EntityName.ToLower()}/create/{c.EntityName.ToLower()}.component.html";

            r.Text += $@"
            <h2>Agregar {c.EntityName}</h2>
            <form [formGroup]=""{c.EntityName.ToLower()}Form"">
            ";

            foreach (var item in c.Columns)
            {
            r.Text += $@"
            <!-- {item.Name} -->
            <p>
                <mat-form-field appearance=""fill"">
                    <mat-label>{item.Name}</mat-label>
                    <input matInput formControlName=""{item.Name.ToCamelCase()}"" />
                </mat-form-field>
            </p>
                ";

            r.Text += $@"
            <!-- {item.Name} Dropdown-->
            <p>
                <mat-form-field appearance=""fill"">
                    <mat-label>{item.Name.ToSepararConEspacio()}</mat-label>
                    <mat-select formControlName=""{item.Name.ToCamelCase()}"">
                    <mat-option *ngFor=""let i of LIST"" [value]=""i.LIST ID"">
                        {{{{ i.LIST DESCRIPTION }}}}
                    </mat-option>
                    </mat-select>
                </mat-form-field>
            </p>
                ";

            }



            r.Text += $@"
              <p>
                <button
                  mat-raised-button
                  color=""primary""
                  (click)=""guardar()""
                  [disabled]=""!{c.EntityName.ToLower()}Form.valid""
                >
                  Guardar
                </button>
              </p>
            </form>
            ";

            return r;
        }
    }
}