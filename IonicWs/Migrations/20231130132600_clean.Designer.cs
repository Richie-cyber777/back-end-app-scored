﻿// <auto-generated />
using IonicWs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IonicWs.Migrations
{
    [DbContext(typeof(IonicContext))]
    [Migration("20231130132600_clean")]
    partial class clean
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ionic_API.Models.Competition", b =>
                {
                    b.Property<int>("idCompetition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCompetition"));

                    b.Property<string>("nomCompetition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCompetition");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Ionic_API.Models.Equipe", b =>
                {
                    b.Property<int>("idEquipe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEquipe"));

                    b.Property<int>("idCompetition")
                        .HasColumnType("int");

                    b.Property<string>("nomEquipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEquipe");

                    b.HasIndex("idCompetition");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("Ionic_API.Models.General", b =>
                {
                    b.Property<int>("idGeneral")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idGeneral"));

                    b.Property<double>("aeriensGagnes")
                        .HasColumnType("float");

                    b.Property<double>("buts")
                        .HasColumnType("float");

                    b.Property<int>("idEquipe")
                        .HasColumnType("int");

                    b.Property<double>("jaune")
                        .HasColumnType("float");

                    b.Property<double>("note")
                        .HasColumnType("float");

                    b.Property<double>("passesReussies")
                        .HasColumnType("float");

                    b.Property<double>("possession")
                        .HasColumnType("float");

                    b.Property<double>("rouge")
                        .HasColumnType("float");

                    b.Property<int>("sousType")
                        .HasColumnType("int");

                    b.Property<double>("tirePM")
                        .HasColumnType("float");

                    b.HasKey("idGeneral");

                    b.HasIndex("idEquipe");

                    b.ToTable("General");
                });

            modelBuilder.Entity("Ionic_API.Models.Equipe", b =>
                {
                    b.HasOne("Ionic_API.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("idCompetition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("Ionic_API.Models.General", b =>
                {
                    b.HasOne("Ionic_API.Models.Equipe", "Equipe")
                        .WithMany()
                        .HasForeignKey("idEquipe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });
#pragma warning restore 612, 618
        }
    }
}
