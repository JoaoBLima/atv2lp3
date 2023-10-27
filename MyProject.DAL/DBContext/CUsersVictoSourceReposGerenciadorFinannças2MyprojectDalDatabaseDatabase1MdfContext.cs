using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyProject.MODEL;

namespace MyProject.DAL.DBContext;

public partial class CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext : DbContext
{
    public CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext()
    {
    }

    public CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext(DbContextOptions<CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Despesa> Despesas { get; set; }

    public virtual DbSet<Receita> Receitas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\victo\\source\\repos\\Gerenciador-finannças2\\MyProject.DAL\\database\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__3214EC07D7D734DD");

            entity.ToTable("categoria");

            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Despesa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__despesas__3214EC075ECB9F95");

            entity.ToTable("despesas");

            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Idcategoria).HasColumnName("IDcategoria");
            entity.Property(e => e.Idusuario).HasColumnName("IDusuario");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdcategoriaNavigation).WithMany(p => p.Despesas)
                .HasForeignKey(d => d.Idcategoria)
                .HasConstraintName("FK2_despesas_ToTable");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Despesas)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK_despesas_ToTable");
        });

        modelBuilder.Entity<Receita>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receitas__3214EC07E1A78879");

            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Idusuario).HasColumnName("IDusuario");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Receita)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK_receita_ToTable");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3214EC076652FEFF");

            entity.ToTable("usuario");

            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
