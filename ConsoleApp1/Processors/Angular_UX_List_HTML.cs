using ConsoleApp1.Extensions;
using System;

namespace ConsoleApp1
{
    internal class Angular_UX_List_HTML
    {
        public static ReponseItem LIST_GenerateHTML(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = c.EntityName.ToLower() + "/" + c.EntityName.ToLower() + ".component.html";

            r.Text += "<h2>" + c.EntityName + "</h2>" + Environment.NewLine;

            r.Text += @"
                
                <div>
                  <h3>Filtros</h3>
                  <form [formGroup]=""filterForm"">";

            foreach (var item in c.Columns)
            {
                r.Text += $@"
                    <mat-form-field appearance=""fill"">
                      <mat-label>{item.Name}</mat-label>
                      <input matInput formControlName=""{item.Name.ToCamelCase()}"" />
                    </mat-form-field>
                ";
            }

            r.Text += @"
                        < button mat-raised-button color=""regular"" (click)=""filtrar()"">
                      <mat-icon>filter_list</mat-icon>Filtrar
                    </button>
                  </form>
                </div>
            ";


            r.Text += "<div>" + Environment.NewLine;
            r.Text += $"    <button mat-raised-button color=\"primary\" (click)=\"navegarAgregar{c.EntityName}()\" >" + Environment.NewLine;
            r.Text += "     <mat-icon>add</ mat-icon>Agregar" + Environment.NewLine;
            r.Text += "     </ button>" + Environment.NewLine;
            r.Text += "<br />" + Environment.NewLine;

            r.Text += "<table mat-table [dataSource]=\"dataSource\" class=\"mat-elevation-z8\">" + Environment.NewLine;

            foreach (var item in c.Columns)
            {
                r.Text += $"<ng-container matColumnDef = \"{item.Name}\" >" + Environment.NewLine;
                r.Text += $"     <th mat-header-cell *matHeaderCellDef>{item.Name}</th>" + Environment.NewLine;
                r.Text += $"    <td mat-cell *matCellDef = \"let element\" >{{{{ element.{ item.Name.ToCamelCase()} }}}}</ td >" + Environment.NewLine;
                r.Text += "</ ng-container>" + Environment.NewLine;
            }

            r.Text += $@"
            <ng-container matColumnDef = ""acciones"">
                <th mat-header-cell *matHeaderCellDef>Acciones</ th>
                <td mat-cell *matCellDef=""let element"">
                    <button mat-raised-button color=""regular"" (click)=""editar(element)"">
                        <mat-icon>edit</ mat-icon>Editar 
                    </ button> &nbsp;
                    <button
                        mat-raised-button
                        color = ""regular""
                        (click) = ""eliminar(element.{c.Columns[0].Name})""
                    >
                        <mat-icon>delete</ mat-icon>Eliminar
                    </ button>
                </ td>  
            </ ng-container>

              <tr mat-header-row *matHeaderRowDef= ""displayedColumns""></ tr>
                <tr mat-row *matRowDef = ""let row; columns: displayedColumns"" ></ tr>
              </ table>
              ";

            return r;
        }
    }
}