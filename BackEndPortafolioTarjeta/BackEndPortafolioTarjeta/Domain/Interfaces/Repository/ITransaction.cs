using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interfaz que se encarga de poder aplicar multiples operaciones sobre la DB en forma de transaccion, como si fuera un Patron de Diseno Comando.
    /// </summary>
    public interface ITransaction
    {
        void SaveAllChanges();

    }
}
