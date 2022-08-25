using BackEndPortafolioTarjeta.Application.Interfaces;
using BackEndPortafolioTarjeta.Domain.Interfaces.Repository;
using System.Text.RegularExpressions;
using TarjetaCredito.Application.Interfaces;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces.Repository;

namespace BackEndPortafolioTarjeta.Application.Services
{

    /// <summary>
    /// Aca se crearian los Casos de uso de nuestro proyecto ya que corresponde a la implementacion
    /// de las interfaces de los servicios usando la capa de Dominio(Repositorios) y Aplicaciones en si.
    /// </summary>
    public class SolicitudHogwartsServices : IServiceSolicitudHogwarts<SolicitudHogwarts, int>
    {
        
        private readonly IRepositorySolicitudHogwarts<SolicitudHogwarts, int> repoSolicitudHogwarts2; //private readonly IRepositoryBase<SolicitudHogwarts, int> repoSolicitudHogwarts;

        /// <summary>
        /// Al momento de instanciar el servicio se pasa por parametros el repositorio el cual se va a utilizar.
        /// </summary>
        public SolicitudHogwartsServices(IRepositorySolicitudHogwarts<SolicitudHogwarts, int> _repoSolicitudHogwarts2)
        {
            repoSolicitudHogwarts2 = _repoSolicitudHogwarts2;
        }


        /// <summary>
        /// Metodo encargado de la validacion de la entidad y de la invocacion del metodo (Add) alojado en el Repositorio (DAO)
        /// </summary>
        public SolicitudHogwarts Add(SolicitudHogwarts _entity)
        {
            if (_entity == null)
            {
                throw new ArgumentNullException("Solicitud requierida!!");
            }
            else if (_entity.Nombre.Length > 20 || _entity.Apellido.Length > 20)
            {
                throw new ArgumentOutOfRangeException("El Nombre o Apellido superan los 20 caracteres!");
            }
            else if (!Regex.IsMatch(_entity.Nombre, @"^[A-Za-z\s]+$") || !Regex.IsMatch(_entity.Apellido, @"^[A-Za-z\s]+$"))
            {
                throw new Exception("El Nombre o Apellido contiene numeros!");
            }
            else if (Math.Floor(Math.Log10(_entity.Identificacion) + 1) > 10 || Math.Floor(Math.Log10(_entity.Edad) + 1) > 2)
            {
                throw new ArgumentOutOfRangeException("La identificacion o la Edad supera los caracteres necesarios!");
            }
            else if ((_entity.Casa.ToLower().Trim() != "gryffindor") && (_entity.Casa.ToLower().Trim() != "hufflepuff") && 
                (_entity.Casa.ToLower().Trim() != "ravenclaw") && (_entity.Casa.ToLower().Trim() != "slytherin"))
            {
                throw new ArgumentException("Casa no existente en Hogwarts!!");
            }


            var _result = repoSolicitudHogwarts2.Add(_entity);
            repoSolicitudHogwarts2.SaveAllChanges();
            return _result;

        }


        /// <summary>
        /// Metodo encargado de la validacion de la entidad y de la invocacion del metodo (Delete) alojado en el Repositorio (DAO)
        /// </summary>
        public void Delete(int _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("Solicitud requierida!!");

            repoSolicitudHogwarts2.Delete(_entity);
            repoSolicitudHogwarts2.SaveAllChanges();
        }


        /// <summary>
        /// Metodo encargado de la validacion de la entidad y de la invocacion del metodo (Edit) alojado en el Repositorio (DAO)
        /// </summary>
        public void Edit(SolicitudHogwarts _entity)
        {
            if (_entity == null)
            {
                throw new ArgumentNullException("Solicitud requierida!!");
            }
            else if (_entity.Nombre.Length > 20 || _entity.Apellido.Length > 20)
            {
                throw new ArgumentOutOfRangeException("El Nombre o Apellido superan los 20 caracteres!");
            }
            else if (!Regex.IsMatch(_entity.Nombre, @"^[A-Za-z\s]+$+$") || !Regex.IsMatch(_entity.Apellido, @"^[A-Za-z\s]+$+$"))
            {
                throw new Exception("El Nombre o Apellido contiene numeros!");
            }
            else if (Math.Floor(Math.Log10(_entity.Identificacion) + 1) > 10 || Math.Floor(Math.Log10(_entity.Edad) + 1) > 2)
            {
                throw new ArgumentOutOfRangeException("La identificacion o la Edad supera los caracteres necesarios!");
            }
            else if ((_entity.Casa.ToLower().Trim() != "gryffindor") && (_entity.Casa.ToLower().Trim() != "hufflepuff") &&
                (_entity.Casa.ToLower().Trim() != "ravenclaw") && (_entity.Casa.ToLower().Trim() != "slytherin"))
            {
                throw new ArgumentException("Casa no existente en Hogwarts!!");
            }

            repoSolicitudHogwarts2.Edit(_entity);
            repoSolicitudHogwarts2.SaveAllChanges();

        }


        /// <summary>
        /// Metodo encargado de la validacion de la entidad y de la invocacion del metodo (GetbyId) alojado en el Repositorio (DAO)
        /// </summary>
        public SolicitudHogwarts GetbyID(int _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("Solicitud requierida!!");

            var _result = repoSolicitudHogwarts2.GetbyID(_entity);
            if (_result == null)
            {
                throw new Exception("Solicitud con Id: " + _entity + " no encontrada!!");
            }
            repoSolicitudHogwarts2.SaveAllChanges();
            return _result;

        }

        /// <summary>
        /// Metodo encargado de la validacion de la entidad y de la invocacion del metodo (List) alojado en el Repositorio (DAO)
        /// </summary>
        public List<SolicitudHogwarts> List()
        {
            var _result = repoSolicitudHogwarts2.List();
            repoSolicitudHogwarts2.SaveAllChanges();
            return _result;
        }

        public SolicitudHogwarts ExpulsarAlumno(int _tEntityID)
        {
            var _result = repoSolicitudHogwarts2.ExpulsarAlumno(_tEntityID);
            repoSolicitudHogwarts2.SaveAllChanges();
            return _result;
        }

    }
}
