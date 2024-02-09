using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ICI.ProvaCandidato.Dados
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        public int UsuarioId { get; set; }

        [Column("Name")]
        public string Nome { get; set; }

        [Column("Senha")]
        public string Senha { get; set; }

        [Column("Email")]
        public string Email { get; set; }
    }
}

