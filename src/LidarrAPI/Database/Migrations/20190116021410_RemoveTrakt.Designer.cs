﻿// <auto-generated />
using System;
using LidarrAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LidarrAPI.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190116021410_RemoveTrakt")]
    partial class RemoveTrakt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateEntity", b =>
                {
                    b.Property<int>("UpdateEntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Branch");

                    b.Property<string>("FixedStr")
                        .HasColumnName("Fixed");

                    b.Property<string>("NewStr")
                        .HasColumnName("New");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Status");

                    b.Property<string>("Version")
                        .IsRequired();

                    b.HasKey("UpdateEntityId");

                    b.HasIndex("Branch", "Version")
                        .IsUnique();

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.Property<int>("UpdateEntityId");

                    b.Property<int>("OperatingSystem");

                    b.Property<string>("Filename");

                    b.Property<string>("Hash");

                    b.Property<string>("Url");

                    b.HasKey("UpdateEntityId", "OperatingSystem");

                    b.ToTable("UpdateFiles");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.HasOne("LidarrAPI.Database.Models.UpdateEntity", "Update")
                        .WithMany("UpdateFiles")
                        .HasForeignKey("UpdateEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}