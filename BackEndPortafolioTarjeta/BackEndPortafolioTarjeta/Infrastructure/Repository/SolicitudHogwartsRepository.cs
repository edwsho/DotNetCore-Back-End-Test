using BackEndPortafolioTarjeta.Domain.Interfaces.Repository;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces.Repository;

namespace BackEndPortafolioTarjeta.Infrastructure.Repository
{
    /// <summary>
    /// Clase Repositorio la cual implementa el repositorio Base con las operaciones genericas (Crud) y de ser necesario metodos especificos de cada clase.
    /// Clase Dao tradicional donde es la capa de persistencia y se realiza las operaciones en la base de datos.
    /// </summary>
    public class SolicitudHogwartsRepository : IRepositorySolicitudHogwarts<SolicitudHogwarts, int>
    {

        private SolicitudHogwartsDbContext _context;    

        /// <summary>
		/// Se intencia la clase inyectandole el DbContext Correspondiente, en este caso SolicitudHogwartsDbContext
		/// </summary>
        public SolicitudHogwartsRepository(SolicitudHogwartsDbContext context)
        {
            _context = context;
        }


        /// <summary>
		/// Metodo encargado de Agregar la entidad en la Base de datos, implementacion de la clase SolicitudHogwarts
		/// </summary>
        public SolicitudHogwarts Add(SolicitudHogwarts _entity)
        {
            _entity.Casa = _entity.Casa.Trim();                        //Borro los espacios del string
            _context.solicitudHogwarts.Add(_entity);                   //Agrego la Entidad SolicitudHogwarts que es el DbSet en la clase SolicitudHogwartsDbContext
            return _entity;
        }

        /// <summary>
		/// Metodo encargado de Eliminar la Solicitud mediante el Id de la misma, en Base de datos, implementacion de la clase SolicitudHogwarts
		/// </summary>
        public void Delete(int _entity)
        {
            var _solicitud = _context.solicitudHogwarts.Where(c => c.Id == _entity).FirstOrDefault();
            if (_solicitud != null)
            {
                _context.solicitudHogwarts.Remove(_solicitud);
            }
            else
                throw new Exception("No se encontro el Id especificado");
        }

        /// <summary>
		/// Metodo encargado de Modificar la Solicitud en Base de datos, implementacion de la clase SolicitudHogwarts
		/// </summary>
        public void Edit(SolicitudHogwarts _entity)
        {
            var _solicitud = _context.solicitudHogwarts.Where(c => c.Id == _entity.Id).FirstOrDefault();
            if (_solicitud != null)
            {
                _solicitud.Id = _entity.Id;
                _solicitud.Nombre = _entity.Nombre;
                _solicitud.Apellido = _entity.Apellido;
                _solicitud.Identificacion = _entity.Identificacion;
                _solicitud.Edad = _entity.Edad;
                _solicitud.Casa = _entity.Casa.Trim();

                _context.Entry(_solicitud).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            else
                throw new Exception("No se encontro el Id especificado");

        }

        /// <summary>
		/// Metodo encargado de Obtener una Solicitud mediante el id en Base de datos, implementacion de la clase SolicitudHogwarts
		/// </summary>
        public SolicitudHogwarts GetbyID(int _entity)
        {
            var _solicitud = _context.solicitudHogwarts.Where(c => c.Id == _entity).FirstOrDefault();
            return _solicitud;
        }

        /// <summary>
		/// Metodo encargado de Obtener todas las Solicitudes de la base de datos, implementacion de la clase SolicitudHogwarts
		/// </summary>
        public List<SolicitudHogwarts> List()
        {
            return _context.solicitudHogwarts.ToList();
        }

        public void SaveAllChanges()
        {
            _context.SaveChanges();
        }

        public SolicitudHogwarts ExpulsarAlumno(int entityID)
        {
            var _solicitud = _context.solicitudHogwarts.Where(c => c.Id == 1).FirstOrDefault();
            return _solicitud;
        }
    }
}
