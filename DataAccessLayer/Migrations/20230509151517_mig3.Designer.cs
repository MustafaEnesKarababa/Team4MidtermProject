﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Team4Context))]
    [Migration("20230509151517_mig3")]
    partial class mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntitiyLayer.Entities.AddedFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("TargetCaloryPerDay")
                        .HasColumnType("float");

                    b.Property<double>("TotalCalory")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("AddedFoods");
                });

            modelBuilder.Entity("EntitiyLayer.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 5, 9, 18, 15, 16, 855, DateTimeKind.Local).AddTicks(76),
                            Email = "admin@admin.com",
                            Password = "Admin1234"
                        });
                });

            modelBuilder.Entity("EntitiyLayer.Entities.LifeStyle", b =>
                {
                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double>("ActivityLevel")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Type");

                    b.ToTable("LifeStyles");
                });

            modelBuilder.Entity("EntitiyLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("ActivePassiveSituation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("LifeStyleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SpecificQuestion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LifeStyleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kahvaltılık"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Süt ve Süt Ürünleri"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Meyve ve Sebze"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ev Yemekleri"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Et Yemekleri"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fast Food"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tatlı"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fırın"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Atıştırmalık"
                        },
                        new
                        {
                            Id = 10,
                            Name = "İçecekler"
                        });
                });

            modelBuilder.Entity("EntityLayer.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("CaloryPerUnit")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Meal", b =>
                {
                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("EntityLayer.Entities.Unit", b =>
                {
                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Name");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("EntitiyLayer.Entities.AddedFood", b =>
                {
                    b.HasOne("EntityLayer.Entities.Food", "Food")
                        .WithMany("AddedFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.Meal", "Meal")
                        .WithMany("AddedFoods")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitiyLayer.Entities.User", "User")
                        .WithMany("AddedFoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntitiyLayer.Entities.User", b =>
                {
                    b.HasOne("EntitiyLayer.Entities.LifeStyle", "LifeStyle")
                        .WithMany()
                        .HasForeignKey("LifeStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LifeStyle");
                });

            modelBuilder.Entity("EntityLayer.Entities.Food", b =>
                {
                    b.HasOne("EntityLayer.Entities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.Unit", "Unit")
                        .WithMany("Foods")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("EntitiyLayer.Entities.User", b =>
                {
                    b.Navigation("AddedFoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Food", b =>
                {
                    b.Navigation("AddedFoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Meal", b =>
                {
                    b.Navigation("AddedFoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Unit", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
