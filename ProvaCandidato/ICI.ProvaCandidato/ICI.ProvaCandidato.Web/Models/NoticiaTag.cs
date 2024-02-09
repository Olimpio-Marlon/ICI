using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICI.ProvaCandidato.Negocio
{
    [Table("CandidatoNoticiaTag")]
	public class NoticiaTag
	{
        [Column("Id")]
        public int Id { get; set; }
        [Column("Noticia")]
        public int NoticiaId { get; set; }
        [Column("Tag")]
        public int TagId { get; set; }
    }

   
}

