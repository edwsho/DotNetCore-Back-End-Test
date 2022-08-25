using BackEndPortafolioTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndPortafolioTarjeta.Infrastructure.Configs
{
    public class SolicitudHogwartsConfig : IEntityTypeConfiguration<SolicitudHogwarts>
    {
        public void Configure(EntityTypeBuilder<SolicitudHogwarts> builder)
        {
            builder.ToTable("SolicitudHogwarts");
            builder.HasKey(x => x.Id);

            //En caso de querer configurar llaves Primarias y Foraneas asi como sus relaciones se hace de la siguiente manera.

            /*builder.HasKey(x => new { x.Id, x.Id2 });

            builder.HasOne(detalle => detalle.Producto)      //Ejemplo un VentaDetalle tiene un Producto     
                .WithMany(Entidad => Entidad.VentaDetalles); //Un producto tiene muchas VentasDetalles

            builder.HasOne(detalle => detalle.Venta)         //Ejemplo un VentaDetalle tiene una Venta 
                 .WithMany(Entidad => Entidad.VentaDetalles);     //Un producto tiene muchas VentaDetalles    */

        }
    }
}
