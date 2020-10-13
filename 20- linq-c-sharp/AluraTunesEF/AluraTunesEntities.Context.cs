
namespace AluraTunesData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AluraTunesEntities : DbContext
    {
        public AluraTunesEntities()
            : base("name=AluraTunesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artista> Artistas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Faixa> Faixas { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<ItemNotaFiscal> ItemsNotaFiscal { get; set; }
        public virtual DbSet<NotaFiscal> NotasFiscais { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<TipoMidia> TipoMidias { get; set; }
    }
}
