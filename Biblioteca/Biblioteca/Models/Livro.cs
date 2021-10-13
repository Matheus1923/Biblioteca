using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Key]
        [Column("idlivro")]
        [Required(ErrorMessage = "O campo deve ser Obrigatório")]

        public Int32 IdLivro { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 á 50 caracteres")]
        [Column("editora")]

        public string Editora { get; set; }

        [Column("aluguel")]
        [Required(ErrorMessage = "O campo dev ser Obrigatório")]

        public decimal Aluguel { get; set; }

    }
}
