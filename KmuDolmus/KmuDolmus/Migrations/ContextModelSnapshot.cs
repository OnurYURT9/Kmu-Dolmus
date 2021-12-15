﻿// <auto-generated />
using KmuDolmus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KmuDolmus.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("KmuDolmus.Models.Gun", b =>
                {
                    b.Property<int>("GunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GunAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GunId");

                    b.ToTable("Guns");
                });

            modelBuilder.Entity("KmuDolmus.Models.Hatlar", b =>
                {
                    b.Property<int>("hat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GunId")
                        .HasColumnType("int");

                    b.Property<int>("hat_Numara")
                        .HasColumnType("int");

                    b.Property<string>("hat_saat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hat_id");

                    b.HasIndex("GunId");

                    b.ToTable("Hatlars");
                });

            modelBuilder.Entity("KmuDolmus.Models.Hatlar", b =>
                {
                    b.HasOne("KmuDolmus.Models.Gun", "Gun")
                        .WithMany("Hatlars")
                        .HasForeignKey("GunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gun");
                });

            modelBuilder.Entity("KmuDolmus.Models.Gun", b =>
                {
                    b.Navigation("Hatlars");
                });
#pragma warning restore 612, 618
        }
    }
}