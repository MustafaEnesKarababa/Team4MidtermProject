﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Team4Context))]
    partial class Team4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(7969));

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
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
                            CreationDate = new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(8941),
                            Email = "admin@admin.com",
                            Password = "Admin1234"
                        });
                });

            modelBuilder.Entity("EntitiyLayer.Entities.Goal", b =>
                {
                    b.Property<int>("GoalType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GoalType");

                    b.ToTable("Goals");

                    b.HasData(
                        new
                        {
                            GoalType = 1,
                            Description = "Kilo vermek istiyorum."
                        },
                        new
                        {
                            GoalType = 2,
                            Description = "Dengeli bir şekilde kilo almak istiyorum."
                        },
                        new
                        {
                            GoalType = 3,
                            Description = "Hızlı ve sağlıklı bir şekilde kilo almalıyım."
                        },
                        new
                        {
                            GoalType = 4,
                            Description = "Mevcut kilomu korumak istiyorum"
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

                    b.HasData(
                        new
                        {
                            Type = 1,
                            ActivityLevel = 0.0,
                            Description = "Haraket etmiyorum veya çok az hareket ediyorum"
                        },
                        new
                        {
                            Type = 2,
                            ActivityLevel = 0.0,
                            Description = "Haftada 1-3 gün egzersiz yapıyorum"
                        },
                        new
                        {
                            Type = 3,
                            ActivityLevel = 0.0,
                            Description = "Haftada 3-5 gün egzersiz yapıyorum"
                        },
                        new
                        {
                            Type = 4,
                            ActivityLevel = 0.0,
                            Description = "Haftada 6-7 gün egzersiz yapıyorum"
                        },
                        new
                        {
                            Type = 5,
                            ActivityLevel = 0.0,
                            Description = "Profesyonel sporcu, atlet seviyesi"
                        });
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2063));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("GoalTypeId")
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

                    b.HasIndex("GoalTypeId");

                    b.HasIndex("LifeStyleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActivePassiveSituation = false,
                            BirthDate = new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreationDate = new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2182),
                            Email = "ahmetyilmaz@yilmaz.com",
                            Gender = 2,
                            GoalTypeId = 1,
                            Height = 182.0,
                            LifeStyleId = 2,
                            Name = "Ahmet",
                            Password = "AaBb12.,",
                            QuestionAnswer = "C#",
                            SpecificQuestion = "En Sevdiğin Programlama Dili?",
                            Surname = "Yılmaz",
                            Weight = 113.0
                        },
                        new
                        {
                            Id = 2,
                            ActivePassiveSituation = false,
                            BirthDate = new DateTime(1997, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreationDate = new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2252),
                            Email = "ayşesevgi@sevgi.com",
                            Gender = 1,
                            GoalTypeId = 3,
                            Height = 185.0,
                            LifeStyleId = 3,
                            Name = "Ayşe",
                            Password = "AaBb12.,",
                            QuestionAnswer = "Java",
                            SpecificQuestion = "En Sevdiğin Programlama Dili?",
                            Surname = "Sevgi",
                            Weight = 55.0
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaloryPerUnit = 75.0,
                            CategoryId = 1,
                            Name = "Haşlanmış Yumurta",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 2,
                            CaloryPerUnit = 4.2000000000000002,
                            CategoryId = 1,
                            Name = "Siyah Zeytin",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 3,
                            CaloryPerUnit = 6.0,
                            CategoryId = 1,
                            Name = "Yeşil Zeytin",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 4,
                            CaloryPerUnit = 2.2999999999999998,
                            CategoryId = 1,
                            Name = "Çilek Reçeli",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 5,
                            CaloryPerUnit = 2.7000000000000002,
                            CategoryId = 1,
                            Name = "Vişne Reçeli",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 6,
                            CaloryPerUnit = 3.5,
                            CategoryId = 1,
                            Name = "Pekmez",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 7,
                            CaloryPerUnit = 6.4000000000000004,
                            CategoryId = 1,
                            Name = "Tahin",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 8,
                            CaloryPerUnit = 2.7000000000000002,
                            CategoryId = 2,
                            Name = "Beyaz Peynir",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 9,
                            CaloryPerUnit = 3.5,
                            CategoryId = 2,
                            Name = "Kaşar Peyniri",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 10,
                            CaloryPerUnit = 500.0,
                            CategoryId = 2,
                            Name = "Süt",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 11,
                            CaloryPerUnit = 0.72999999999999998,
                            CategoryId = 2,
                            Name = "Yoğurt",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 12,
                            CaloryPerUnit = 23.0,
                            CategoryId = 3,
                            Name = "Domates",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 13,
                            CaloryPerUnit = 14.0,
                            CategoryId = 3,
                            Name = "Salatalık",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 14,
                            CaloryPerUnit = 20.0,
                            CategoryId = 3,
                            Name = "Carliston Biber",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 15,
                            CaloryPerUnit = 30.0,
                            CategoryId = 3,
                            Name = "Köy Biberi",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 16,
                            CaloryPerUnit = 25.0,
                            CategoryId = 3,
                            Name = "Kapya Biberi",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 17,
                            CaloryPerUnit = 45.0,
                            CategoryId = 3,
                            Name = "Kırmızı Elma",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 18,
                            CaloryPerUnit = 50.0,
                            CategoryId = 3,
                            Name = "Yeşil Elma",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 19,
                            CaloryPerUnit = 47.0,
                            CategoryId = 3,
                            Name = "Portakal",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 20,
                            CaloryPerUnit = 40.0,
                            CategoryId = 3,
                            Name = "Mandalina",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 21,
                            CaloryPerUnit = 1.3999999999999999,
                            CategoryId = 3,
                            Name = "Kiraz",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 22,
                            CaloryPerUnit = 45.0,
                            CategoryId = 3,
                            Name = "Karpuz",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 23,
                            CaloryPerUnit = 150.0,
                            CategoryId = 4,
                            Name = "Tarhana Çorbası",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 24,
                            CaloryPerUnit = 140.0,
                            CategoryId = 4,
                            Name = "Mercimek Çorbası",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 25,
                            CaloryPerUnit = 95.0,
                            CategoryId = 4,
                            Name = "Ezogelin Çorbası",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 26,
                            CaloryPerUnit = 132.0,
                            CategoryId = 4,
                            Name = "Tavuk Çorbası",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 27,
                            CaloryPerUnit = 200.0,
                            CategoryId = 4,
                            Name = "Pirinç Pilavı",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 28,
                            CaloryPerUnit = 240.0,
                            CategoryId = 4,
                            Name = "Bulgur Pilavı",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 29,
                            CaloryPerUnit = 265.0,
                            CategoryId = 4,
                            Name = "Kuru Fasülye",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 30,
                            CaloryPerUnit = 160.0,
                            CategoryId = 4,
                            Name = "Nohut",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 31,
                            CaloryPerUnit = 80.0,
                            CategoryId = 4,
                            Name = "Pırasa",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 32,
                            CaloryPerUnit = 40.0,
                            CategoryId = 4,
                            Name = "Brokoli",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 33,
                            CaloryPerUnit = 250.0,
                            CategoryId = 5,
                            Name = "Cağ Kebap",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 34,
                            CaloryPerUnit = 400.0,
                            CategoryId = 5,
                            Name = "Adana Kebap",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 35,
                            CaloryPerUnit = 380.0,
                            CategoryId = 5,
                            Name = "Urfa Kebap",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 36,
                            CaloryPerUnit = 500.0,
                            CategoryId = 5,
                            Name = "Şiş Köfte",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 37,
                            CaloryPerUnit = 280.0,
                            CategoryId = 5,
                            Name = "Antrikot",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 38,
                            CaloryPerUnit = 300.0,
                            CategoryId = 5,
                            Name = "Biftek",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 39,
                            CaloryPerUnit = 450.0,
                            CategoryId = 5,
                            Name = "Pirzola",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 40,
                            CaloryPerUnit = 351.0,
                            CategoryId = 6,
                            Name = "Hamburger",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 41,
                            CaloryPerUnit = 265.0,
                            CategoryId = 6,
                            Name = "Orta Boy Pizza",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 42,
                            CaloryPerUnit = 355.0,
                            CategoryId = 6,
                            Name = "Patates Kızartması",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 43,
                            CaloryPerUnit = 272.0,
                            CategoryId = 6,
                            Name = "Tavuk Döner",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 44,
                            CaloryPerUnit = 391.0,
                            CategoryId = 6,
                            Name = "Et Döner",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 45,
                            CaloryPerUnit = 15.0,
                            CategoryId = 6,
                            Name = "Midye",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 46,
                            CaloryPerUnit = 202.0,
                            CategoryId = 7,
                            Name = "Kazan Dibi",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 47,
                            CaloryPerUnit = 293.0,
                            CategoryId = 7,
                            Name = "Sütlaç",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 48,
                            CaloryPerUnit = 288.0,
                            CategoryId = 7,
                            Name = "Baklava",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 49,
                            CaloryPerUnit = 76.0,
                            CategoryId = 8,
                            Name = "Beyaz Ekmek",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 50,
                            CaloryPerUnit = 220.0,
                            CategoryId = 8,
                            Name = "Simit",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 51,
                            CaloryPerUnit = 288.0,
                            CategoryId = 8,
                            Name = "Poğaça",
                            UnitId = 4
                        },
                        new
                        {
                            Id = 52,
                            CaloryPerUnit = 6.2999999999999998,
                            CategoryId = 9,
                            Name = "Kuru Meyve",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 53,
                            CaloryPerUnit = 3.6000000000000001,
                            CategoryId = 9,
                            Name = "Leblebi",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 54,
                            CaloryPerUnit = 5.7999999999999998,
                            CategoryId = 9,
                            Name = "Karışık Kureyemiş",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 55,
                            CaloryPerUnit = 484.0,
                            CategoryId = 10,
                            Name = "Cola",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 56,
                            CaloryPerUnit = 360.0,
                            CategoryId = 10,
                            Name = "Ayran",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 57,
                            CaloryPerUnit = 133.0,
                            CategoryId = 10,
                            Name = "Enerji İçeceği",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 58,
                            CaloryPerUnit = 185.0,
                            CategoryId = 10,
                            Name = "Bira",
                            UnitId = 3
                        });
                });

            modelBuilder.Entity("EntityLayer.Entities.Meal", b =>
                {
                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Name = 1
                        },
                        new
                        {
                            Name = 2
                        },
                        new
                        {
                            Name = 3
                        },
                        new
                        {
                            Name = 4
                        });
                });

            modelBuilder.Entity("EntityLayer.Entities.Unit", b =>
                {
                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Name");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Name = 1,
                            Description = "1 gram"
                        },
                        new
                        {
                            Name = 4,
                            Description = "1 tabak / 1 dilim / Tam"
                        },
                        new
                        {
                            Name = 3,
                            Description = "1 tane"
                        },
                        new
                        {
                            Name = 2,
                            Description = "1000 mililitre"
                        });
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
                    b.HasOne("EntitiyLayer.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitiyLayer.Entities.LifeStyle", "LifeStyle")
                        .WithMany()
                        .HasForeignKey("LifeStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

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
