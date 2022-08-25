using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces;
using TarjetaCredito.Domain.Interfaces.Repository;

namespace BackEndPortafolioTarjeta.Domain.Interfaces.Repository
{
    public interface IRepositorySolicitudHogwartsInMemory<TEntity, TEntityID> : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntity>, IList<TEntity, TEntityID>, ITransaction
    {
        // Se pueden colocar metodos especificos para realizar operaciones dentro del contexto SolicitudHogwarts, como Expulsar Alumno, etc.
        SolicitudHogwarts ExpulsarAlumno(TEntityID entityID);

    }
}
