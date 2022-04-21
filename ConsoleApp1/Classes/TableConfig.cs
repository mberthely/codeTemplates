using System.Collections.Generic;

namespace ConsoleApp1
{
    public class TableConfig
    {
        public List<TableConfigItem> items = new List<TableConfigItem>();

        public TableConfig()
        {
            var tci3 = new TableConfigItem();
            tci3.ProjectName = "TodoProject";
            tci3.EntityName = "Todo";
            tci3.Columns = new List<Column>();
            tci3.Columns.Add(new Column() { Name = "ToDoId", IsID = true });
            tci3.Columns.Add(new Column() { Name = "Titulo" });
            tci3.Columns.Add(new Column() { Name = "Activo" });
            items.Add(tci3);

            var tci2 = new TableConfigItem();
            tci2.ProjectName = "PlanDeAlimentos";
            tci2.EntityName = "PlanSemanalDetalles";
            tci2.Columns = new List<Column>();
            tci2.Columns.Add(new Column() { Name = "PlanSemanalDetalleId", IsID = true });
            tci2.Columns.Add(new Column() { Name = "PlanSemanalId" });
            tci2.Columns.Add(new Column() { Name = "AlimentoId" });
            tci2.Columns.Add(new Column() { Name = "Dia" });
            tci2.Columns.Add(new Column() { Name = "Tipo" });
            items.Add(tci2);

            //Columns.Add(new Column() { Name = "TiempoMinutos" });
            //ProjectName = "PlanDeAlimentos";
            //EntityName = "PreparacionAlimentos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "PreparacionAlimentoId", IsID = true });
            //Columns.Add(new Column() { Name = "AlimentoId" });
            //Columns.Add(new Column() { Name = "Orden" });
            //Columns.Add(new Column() { Name = "Titulo" });
            //Columns.Add(new Column() { Name = "Detalles" });
            //Columns.Add(new Column() { Name = "TiempoMinutos" });

            //EntityName = "AlimentosIngredientes";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "AlimientoIngredienteId", IsID = true });
            //Columns.Add(new Column() { Name = "AlimentoId" });
            //Columns.Add(new Column() { Name = "IngredienteId" });

            //EntityName = "TarjetasQueExpiran";
            //Columns = new List<Column>();
            //Columns.Add(new Column() {Name= "TarjetaQueExpiraId", IsID = true });
            //Columns.Add(new Column() {Name= "Proveedor" });
            //Columns.Add(new Column() {Name= "Ultimos4Digitos" });
            //Columns.Add(new Column() {Name= "Descripcion" });
            //Columns.Add(new Column() {Name= "FechaExpiracion" });
            //Columns.Add(new Column() {Name= "Activo" });

            //EntityName = "ElectronicaYComputo";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "ElectronicaId", IsID = true });
            //Columns.Add(new Column() { Name = "Producto" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "PrecioCompra" });
            //Columns.Add(new Column() { Name = "PrecioVenta" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Activos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "ActivoId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "Categoria" });
            //Columns.Add(new Column() { Name = "Importe" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Pasivos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "PasivoId", IsID = true });
            //Columns.Add(new Column() { Name = "MensualidadTotal" });
            //Columns.Add(new Column() { Name = "MensualidadCapital" });
            //Columns.Add(new Column() { Name = "MensualidadInteresesYCargos" });

            //EntityName = "MascotaVisitasVeterinario";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "MascotaVisitaVeterinarioId", IsID = true });
            //Columns.Add(new Column() { Name = "MascotaId" });
            //Columns.Add(new Column() { Name = "Motivo" });
            //Columns.Add(new Column() { Name = "Fecha" });
            //Columns.Add(new Column() { Name = "Categoria" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "ArticulosGamer";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "ArticuloGamerId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "Categoria" });
            //Columns.Add(new Column() { Name = "PrecioCompra" });
            //Columns.Add(new Column() { Name = "PrecioVentaEstimado" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Coleccionables";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "ColeccionableId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "Franquicia" });
            //Columns.Add(new Column() { Name = "Categoria" });
            //Columns.Add(new Column() { Name = "PrecioCompra" });
            //Columns.Add(new Column() { Name = "PrecioVentaEstimado" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "PaseosViajesEventos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "PaseoViajeEventoId", IsID = true });
            //Columns.Add(new Column() { Name = "Titulo" });
            //Columns.Add(new Column() { Name = "FechaInicio" });
            //Columns.Add(new Column() { Name = "FechaFin" });
            //Columns.Add(new Column() { Name = "DistanciaKMAuto" });
            //Columns.Add(new Column() { Name = "DetallesTransporteResolucion" });
            //Columns.Add(new Column() { Name = "DetallesHospedajeResolucion" });
            //Columns.Add(new Column() { Name = "DetalleTicketsResolucion" });
            //Columns.Add(new Column() { Name = "DetalleAlimentosResolucion" });
            //Columns.Add(new Column() { Name = "ItinerarioPorDia" });
            //Columns.Add(new Column() { Name = "EsWishList" });
            //Columns.Add(new Column() { Name = "Confirmado" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Dashboard";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "titulo", IsID = true });
            //Columns.Add(new Column() { Name = "value" });
            //Columns.Add(new Column() { Name = "icono" });
            //Columns.Add(new Column() { Name = "linkTo" });
            //Columns.Add(new Column() { Name = "status" });

            //EntityName = "LineaBlancaProductos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "LineaBlancaId", IsID = true });
            //Columns.Add(new Column() { Name = "Artefacto" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "FechaCompra" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Comentarios" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Muebles";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "MuebleId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "FechaCompra" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Comentarios" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Decoraciones";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "DecoracionId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "Marca" });
            //Columns.Add(new Column() { Name = "FechaCompra" });
            //Columns.Add(new Column() { Name = "Foto" });
            //Columns.Add(new Column() { Name = "Comentarios" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "ProyectosMejoras";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "ProyectoMejoraId", IsID = true });
            //Columns.Add(new Column() { Name = "Descripcion" });
            //Columns.Add(new Column() { Name = "PresupuestoEstimado" });
            //Columns.Add(new Column() { Name = "PresupuestoReal" });
            //Columns.Add(new Column() { Name = "Comentarios" });
            //Columns.Add(new Column() { Name = "Activo" });

            //EntityName = "Alimentos";
            //Columns = new List<Column>();
            //Columns.Add(new Column() { Name = "AlimentoId", IsID = true });
            //Columns.Add(new Column() { Name = "Titulo" });
            //Columns.Add(new Column() { Name = "Descripccion" });
            //Columns.Add(new Column() { Name = "TipoAlimento" });
            //Columns.Add(new Column() { Name = "Calorias" });
            //Columns.Add(new Column() { Name = "Foto" });
        }


    }
}
