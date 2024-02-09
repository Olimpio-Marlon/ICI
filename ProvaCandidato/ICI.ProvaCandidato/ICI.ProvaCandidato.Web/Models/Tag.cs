using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ICI.ProvaCandidato.Dados
{
    [Table("Tag")]
    public class Tag
	{
		[Column("Id")]
		public int Id { get; set; }
		[Column("Name")]
		public string Name { get; set; }	
	}

	
}
