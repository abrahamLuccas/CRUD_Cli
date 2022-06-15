using System.ComponentModel.DataAnnotations;

namespace CRUD_Cli.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public byte[]? Foto { get; set; }

        [Required(ErrorMessage = "Insira o Email")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [MaxLength(1)]
        public string Departamento { get; set; }

        [Required]
        [MaxLength(1)]
        public string Status { get; set; }
    }
}
