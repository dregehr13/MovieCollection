﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCollection.Models;

namespace MovieCollection.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230224024357_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieCollection.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.MovieEntry", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Cristopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "The best movie ever",
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Andy Tennant",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Hitch",
                            Year = 2005
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Lon Chaney",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "UR",
                            Title = "The Phantom of the Opera",
                            Year = 1925
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.MovieEntry", b =>
                {
                    b.HasOne("MovieCollection.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
