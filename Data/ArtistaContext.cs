using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPdos.Models;

namespace TPDos.Data
{
    public class ArtistaContext : DbContext
    {
        public ArtistaContext(DbContextOptions<ArtistaContext> options)
            : base(options)
        {
        }

        public DbSet<TPdos.Models.Artista> Artista { get; set; } = default!;

        public DbSet<TPdos.Models.Banda> Banda { get; set; } = default!;

        public DbSet<TPdos.Models.Album> Album { get; set; } = default!;

        public DbSet<TPdos.Models.AlbumDebut> AlbumDebut { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumDebut>()
                .HasOne(e => e.Banda)
                .WithOne(e => e.AlbumDebut)
                .HasForeignKey<Banda>(e => e.AlbumDebutId);
        }

    }
}
