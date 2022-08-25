using System.ComponentModel.DataAnnotations;

namespace BackEndPortafolioTarjeta.Models
{
    public class SolicitudHogwarts
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "Solo Letras")]
        [MaxLength(20)]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "Solo Letras")]
        [MaxLength(20)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(10)]
        public int Identificacion { get; set; }

        [Required]
        [MaxLength(2)]
        public int Edad { get; set; }

        [Required]
        [RegularExpression("Gryffindor|Hufflepuff|Ravenclaw|Slytherin", ErrorMessage = "La casa intrducida no crresponde a las de Hogwarts")]
        [MaxLength(11)]
        public string Casa { get; set; }


    }
}
