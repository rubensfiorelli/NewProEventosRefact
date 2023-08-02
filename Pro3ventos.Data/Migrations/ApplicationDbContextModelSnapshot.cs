﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pro3ventos.Data.Input.DataContext;

#nullable disable

namespace Pro3ventos.Data.Input.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EventoPalestrante", b =>
                {
                    b.Property<Guid>("EventosId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PalestrantesId")
                        .HasColumnType("char(36)");

                    b.HasKey("EventosId", "PalestrantesId");

                    b.HasIndex("PalestrantesId");

                    b.ToTable("EventoPalestrante");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Ingresso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LoteId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("ValorIngressoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ingressos");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Lote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EventoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("PublicoSuportado")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Palestrante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Palestrantes");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.RedeSocial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EventoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("PalestranteId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("RedesSociais");
                });

            modelBuilder.Entity("EventoPalestrante", b =>
                {
                    b.HasOne("Pro3ventos.Domain.Entities.Evento", null)
                        .WithMany()
                        .HasForeignKey("EventosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pro3ventos.Domain.Entities.Palestrante", null)
                        .WithMany()
                        .HasForeignKey("PalestrantesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Lote", b =>
                {
                    b.HasOne("Pro3ventos.Domain.Entities.Evento", "Evento")
                        .WithMany("Lotes")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.RedeSocial", b =>
                {
                    b.HasOne("Pro3ventos.Domain.Entities.Evento", "Evento")
                        .WithMany("RedesSociais")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pro3ventos.Domain.Entities.Palestrante", "Palestrante")
                        .WithMany("RedesSociais")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Palestrante");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Evento", b =>
                {
                    b.Navigation("Lotes");

                    b.Navigation("RedesSociais");
                });

            modelBuilder.Entity("Pro3ventos.Domain.Entities.Palestrante", b =>
                {
                    b.Navigation("RedesSociais");
                });
#pragma warning restore 612, 618
        }
    }
}
