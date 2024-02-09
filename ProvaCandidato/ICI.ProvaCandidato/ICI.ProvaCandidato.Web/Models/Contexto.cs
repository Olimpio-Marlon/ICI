using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio;
using Microsoft.EntityFrameworkCore;

namespace ICI.ProvaCandidato.Web.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options)
        {
           
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Noticia> Noticia { get; set; }

        public DbSet<NoticiaTag> NoticiaTag { get; set;}

        public DbSet<Tag> Tag { get; set; }
    }
}
