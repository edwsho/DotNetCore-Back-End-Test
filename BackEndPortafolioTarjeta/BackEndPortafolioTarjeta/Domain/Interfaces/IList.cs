using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    public interface IList<TEntity, TEntityID>
    {
        /// <summary>
        /// Interfaz generica para la implementacion de los metodos List (Get)
        /// </summary>
        List<TEntity> List();

        /// <summary>
        /// Metodo de la interfaz generica que alojara las diferentes implementaciones dependiendo del tipo de objecto que la invoque
        /// </summary>
        TEntity GetbyID(TEntityID _entity);
    }
}
