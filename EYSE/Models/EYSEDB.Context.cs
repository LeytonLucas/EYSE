//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EYSE.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EYSEEntities : DbContext
    {
        public EYSEEntities()
            : base("name=EYSEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Causas> Causas { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<TipoEquipo> TipoEquipo { get; set; }
    
        public virtual ObjectResult<Nullable<int>> SP_EditarTipoEquipo(Nullable<int> idTipoEquipo, string equipo, string descripcion)
        {
            var idTipoEquipoParameter = idTipoEquipo.HasValue ?
                new ObjectParameter("idTipoEquipo", idTipoEquipo) :
                new ObjectParameter("idTipoEquipo", typeof(int));
    
            var equipoParameter = equipo != null ?
                new ObjectParameter("equipo", equipo) :
                new ObjectParameter("equipo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_EditarTipoEquipo", idTipoEquipoParameter, equipoParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Eliminar_Tecnico(Nullable<int> dni)
        {
            var dniParameter = dni.HasValue ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Eliminar_Tecnico", dniParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Eliminar_TipoEquipo(Nullable<int> idTipoEquipo)
        {
            var idTipoEquipoParameter = idTipoEquipo.HasValue ?
                new ObjectParameter("IdTipoEquipo", idTipoEquipo) :
                new ObjectParameter("IdTipoEquipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Eliminar_TipoEquipo", idTipoEquipoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_EliminarDivision(Nullable<int> idDivision)
        {
            var idDivisionParameter = idDivision.HasValue ?
                new ObjectParameter("idDivision", idDivision) :
                new ObjectParameter("idDivision", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_EliminarDivision", idDivisionParameter);
        }
    
        public virtual int SP_InsertarDepartamento(string departamento)
        {
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarDepartamento", departamentoParameter);
        }
    
        public virtual int SP_InsertarDivision(string division, string local, string observacion, Nullable<int> idDepartamento)
        {
            var divisionParameter = division != null ?
                new ObjectParameter("Division", division) :
                new ObjectParameter("Division", typeof(string));
    
            var localParameter = local != null ?
                new ObjectParameter("Local", local) :
                new ObjectParameter("Local", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("Observacion", observacion) :
                new ObjectParameter("Observacion", typeof(string));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarDivision", divisionParameter, localParameter, observacionParameter, idDepartamentoParameter);
        }
    
        public virtual int SP_InsertarMotivoIngreso(string fallaMotivo)
        {
            var fallaMotivoParameter = fallaMotivo != null ?
                new ObjectParameter("FallaMotivo", fallaMotivo) :
                new ObjectParameter("FallaMotivo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarMotivoIngreso", fallaMotivoParameter);
        }
    
        public virtual int SP_InsertarTecnico(Nullable<int> dNI, string nombre, string apellido)
        {
            var dNIParameter = dNI.HasValue ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarTecnico", dNIParameter, nombreParameter, apellidoParameter);
        }
    
        public virtual int SP_InsertarTipoEquipo(string equipo, string descripcion)
        {
            var equipoParameter = equipo != null ?
                new ObjectParameter("Equipo", equipo) :
                new ObjectParameter("Equipo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarTipoEquipo", equipoParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<SP_Obtener_Departamentos_Result> SP_Obtener_Departamentos(Nullable<int> idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Obtener_Departamentos_Result>("SP_Obtener_Departamentos", idDepartamentoParameter);
        }
    
        public virtual ObjectResult<SP_Obtener_Tecnicos_Result> SP_Obtener_Tecnicos(Nullable<int> idTecnico)
        {
            var idTecnicoParameter = idTecnico.HasValue ?
                new ObjectParameter("IdTecnico", idTecnico) :
                new ObjectParameter("IdTecnico", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Obtener_Tecnicos_Result>("SP_Obtener_Tecnicos", idTecnicoParameter);
        }
    
        public virtual ObjectResult<SP_Obtener_TipoEquipo_Result> SP_Obtener_TipoEquipo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Obtener_TipoEquipo_Result>("SP_Obtener_TipoEquipo");
        }
    
        public virtual ObjectResult<SP_Obtener_Causas_Result> SP_Obtener_Causas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Obtener_Causas_Result>("SP_Obtener_Causas");
        }
    
        public virtual ObjectResult<SP_Obtener_Divisiones_Result> SP_Obtener_Divisiones(Nullable<int> idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Obtener_Divisiones_Result>("SP_Obtener_Divisiones", idDepartamentoParameter);
        }
    }
}
