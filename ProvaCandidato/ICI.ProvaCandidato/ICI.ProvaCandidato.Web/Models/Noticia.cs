using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICI.ProvaCandidato.Negocio
{
    [Table("CandidatoNoticia")]
    public class Noticia
	{
        [Column("Id")]
        public int Id { get; set; }

        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Texto")]
        public string Texto { get; set; }

        [Column("UsuarioId")]
        public int UsuarioId { get; set; }
    }

    
   
}

