using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces;

namespace BackEndPortafolioTarjeta.Application.Interfaces
{
    /// <summary>
    /// Interfaz ServiceSolicitudHogwarts de los servicios donde implementa las operaciones basicas CRUD, y de ser necesario dentro de la interfaz
    /// se crean los metodos propios de cada servicio particular
    /// </summary>
    public interface IServiceSolicitudHogwarts<TEntity, TEntityID> : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntity>, IList<TEntity, TEntityID>
    {
        SolicitudHogwarts ExpulsarAlumno(TEntityID _tEntityID);
    }
}
