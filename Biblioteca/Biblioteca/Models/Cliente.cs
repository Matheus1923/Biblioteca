using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    [Table("Column")]
    public class Cliente
    {
        [Key]
        [Column("idcliente")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public int IdCliente { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor do campo deve conter entre 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor do campo deve conter entre 10 á 50 caracteres")]
        [Column("email")]

        public string Email{ get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor do campo deve conter entre 10 á 50 caracteres")]
        [Column("telefone")]

        public string Telefone { get; set; }

        [Column("idlivro")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public int IdLivro { get; set; }

        [Column("datadealuguel")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public DateTime DataDeAluguel { get; set; }
    }
}
