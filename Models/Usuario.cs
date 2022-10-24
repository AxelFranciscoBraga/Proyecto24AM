using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24AMMVC.Models
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string password { get; set; }
        [ForeignKey("Rol")]
        public int? FkRol { get; set; }
        public Rol Rol { get; set; }
    }
}
