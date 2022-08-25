using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    /// <summary>
    /// Interfaz generica para la implementacion de los metodos Add
    /// </summary>
    public interface IAdd<TEntity>
    {
        /// <summary>
        /// Metodo de la interfaz generica que alojara las diferentes implementaciones dependiendo del tipo de objecto que la invoque
        /// </summary>
        TEntity Add(TEntity _entity);
    }
}
