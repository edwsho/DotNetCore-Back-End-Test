using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    /// <summary>
    /// Interfaz generica para la implementacion de los metodos Edit
    /// </summary>
    public interface IEdit<TEntity>
    {
        /// <summary>
        /// Metodo de la interfaz generica que alojara las diferentes implementaciones dependiendo del tipo de objecto que la invoque
        /// </summary>
        void Edit(TEntity _entity);
    }
}
