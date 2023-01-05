using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIExample.Models
{
//    [Table("User", Schema = "archi")]
    public class User
    {
        //[Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(150)]
        [Column("Nom")]
        public string Name { get; set; } = "";

        [StringLength(150, ErrorMessage = "max {0} caractères")]
        public string? FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }
    }
}
