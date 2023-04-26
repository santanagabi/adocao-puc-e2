﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app_web_adocao.Models;

namespace app_web_adocao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("app_web_adocao.Models.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("app_web_adocao.Models.Responsavel", b =>
                {
                    b.HasBaseType("app_web_adocao.Models.Usuario");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("app_web_adocao.Models.Responsavel", b =>
                {
                    b.HasOne("app_web_adocao.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("app_web_adocao.Models.Responsavel", "Login")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
