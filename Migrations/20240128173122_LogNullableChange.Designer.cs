﻿// <auto-generated />
using System;
using FormManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormManager.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20240128173122_LogNullableChange")]
    partial class LogNullableChange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FormManager.Data.Models.Forms.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Forms", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("FormManager.Data.Models.Log.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("FormManager.Data.Models.Log.LogParameter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LogId");

                    b.ToTable("LogParameters");
                });

            modelBuilder.Entity("FormManager.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.Developer", b =>
                {
                    b.HasBaseType("FormManager.Data.Models.Forms.Form");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.Publisher", b =>
                {
                    b.HasBaseType("FormManager.Data.Models.Forms.Form");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.VideoGame", b =>
                {
                    b.HasBaseType("FormManager.Data.Models.Forms.Form");

                    b.Property<Guid?>("DeveloperId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("PublisherId");

                    b.ToTable("VideoGames", (string)null);
                });

            modelBuilder.Entity("FormManager.Data.Models.Log.LogParameter", b =>
                {
                    b.HasOne("FormManager.Data.Models.Log.Log", "Log")
                        .WithMany("Parameters")
                        .HasForeignKey("LogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Log");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.VideoGame", b =>
                {
                    b.HasOne("FormManager.Data.Models.Forms.Developer", "Developer")
                        .WithMany("VideoGames")
                        .HasForeignKey("DeveloperId");

                    b.HasOne("FormManager.Data.Models.Forms.Form", null)
                        .WithOne()
                        .HasForeignKey("FormManager.Data.Models.Forms.VideoGame", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormManager.Data.Models.Forms.Publisher", "Publisher")
                        .WithMany("VideoGames")
                        .HasForeignKey("PublisherId");

                    b.Navigation("Developer");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("FormManager.Data.Models.Log.Log", b =>
                {
                    b.Navigation("Parameters");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.Developer", b =>
                {
                    b.Navigation("VideoGames");
                });

            modelBuilder.Entity("FormManager.Data.Models.Forms.Publisher", b =>
                {
                    b.Navigation("VideoGames");
                });
#pragma warning restore 612, 618
        }
    }
}
