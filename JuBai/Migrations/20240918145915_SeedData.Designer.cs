﻿// <auto-generated />
using System;
using JuBai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuBai.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240918145915_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JuBai.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Music"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Entertainment"
                        });
                });

            modelBuilder.Entity("JuBai.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7555),
                            PostId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("JuBai.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Media");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7537),
                            PostId = 1,
                            Type = 0,
                            Url = "http://example.com/image.jpg"
                        });
                });

            modelBuilder.Entity("JuBai.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "admin",
                            Category = "Music",
                            Content = "This is the content of the first post.",
                            CreatedAt = new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7440),
                            IsPublished = true,
                            Likes = 0,
                            Title = "First Post"
                        });
                });

            modelBuilder.Entity("JuBai.Models.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 1
                        });
                });

            modelBuilder.Entity("JuBai.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trending"
                        },
                        new
                        {
                            Id = 2,
                            Name = "New Release"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Event"
                        });
                });

            modelBuilder.Entity("JuBai.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7291),
                            Email = "admin@jubai.com",
                            PasswordHash = "hashedpassword",
                            Role = "Admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("JuBai.Models.Like", b =>
                {
                    b.HasOne("JuBai.Models.Post", "Post")
                        .WithMany("LikesList")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JuBai.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JuBai.Models.Media", b =>
                {
                    b.HasOne("JuBai.Models.Post", "Post")
                        .WithMany("Media")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("JuBai.Models.Post", b =>
                {
                    b.HasOne("JuBai.Models.Category", null)
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("JuBai.Models.PostTag", b =>
                {
                    b.HasOne("JuBai.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JuBai.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("JuBai.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("JuBai.Models.Post", b =>
                {
                    b.Navigation("LikesList");

                    b.Navigation("Media");

                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("JuBai.Models.Tag", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("JuBai.Models.User", b =>
                {
                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
