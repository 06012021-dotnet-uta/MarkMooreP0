﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(RpsGameDb))]
    [Migration("20210618011859_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelsLibrary.GameModel", b =>
                {
                    b.Property<int>("GameModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Player1PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("Player2PersonId")
                        .HasColumnType("int");

                    b.HasKey("GameModelId");

                    b.HasIndex("Player1PersonId");

                    b.HasIndex("Player2PersonId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("ModelsLibrary.PlayerDerivedClass", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("MyAge")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PersonId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ModelsLibrary.RoundClass", b =>
                {
                    b.Property<int>("RoundClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComputerChoicePersonId")
                        .HasColumnType("int");

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("Player1ChoicePersonId")
                        .HasColumnType("int");

                    b.Property<int>("Player1Id")
                        .HasColumnType("int");

                    b.HasKey("RoundClassId");

                    b.HasIndex("ComputerChoicePersonId");

                    b.HasIndex("GameId");

                    b.HasIndex("Player1ChoicePersonId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("ModelsLibrary.GameModel", b =>
                {
                    b.HasOne("ModelsLibrary.PlayerDerivedClass", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1PersonId");

                    b.HasOne("ModelsLibrary.PlayerDerivedClass", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2PersonId");

                    b.Navigation("Player1");

                    b.Navigation("Player2");
                });

            modelBuilder.Entity("ModelsLibrary.RoundClass", b =>
                {
                    b.HasOne("ModelsLibrary.PlayerDerivedClass", "ComputerChoice")
                        .WithMany()
                        .HasForeignKey("ComputerChoicePersonId");

                    b.HasOne("ModelsLibrary.GameModel", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelsLibrary.PlayerDerivedClass", "Player1Choice")
                        .WithMany()
                        .HasForeignKey("Player1ChoicePersonId");

                    b.Navigation("ComputerChoice");

                    b.Navigation("Game");

                    b.Navigation("Player1Choice");
                });
#pragma warning restore 612, 618
        }
    }
}
