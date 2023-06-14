﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mvc_scaffold_william.Contexto;

#nullable disable

namespace mvc_scaffold_william.Migrations
{
    [DbContext(typeof(BancoDeDadosContexto))]
    partial class BancoDeDadosContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("mvc_scaffold_william.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("Matricula")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("mvc_scaffold_william.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NivelEnsino")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("mvc_scaffold_william.Models.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlunoId")
                        .HasColumnType("integer");

                    b.Property<int?>("CursoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataFormatura")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("mvc_scaffold_william.Models.Matricula", b =>
                {
                    b.HasOne("mvc_scaffold_william.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("mvc_scaffold_william.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}