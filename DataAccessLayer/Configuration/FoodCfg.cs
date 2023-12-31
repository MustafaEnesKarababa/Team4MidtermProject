﻿using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Enums;

namespace DataAccessLayer.Configuration
{
    internal class FoodCfg : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(30);

            builder.HasData
                (
                //Category name => Kahvaltılık
                new Food() { Id = 1, Name = "Haşlanmış Yumurta", CaloryPerUnit = 75, CategoryId = 1, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\1.png" },
                new Food() { Id = 2, Name = "Siyah Zeytin", CaloryPerUnit = 4.2, CategoryId = 1, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\2.png" },
                new Food() { Id = 3, Name = "Yeşil Zeytin", CaloryPerUnit = 6, CategoryId = 1, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\3.jpg" },
                new Food() { Id = 4, Name = "Çilek Reçeli", CaloryPerUnit = 2.3, CategoryId = 1, UnitId = UnitType.gr , Image = "..\\..\\..\\Pictures\\4.jpg" },
                new Food() { Id = 5, Name = "Vişne Reçeli", CaloryPerUnit = 2.7, CategoryId = 1, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\5.png" },
                new Food() { Id = 6, Name = "Pekmez", CaloryPerUnit = 3.5, CategoryId = 1, UnitId = UnitType.gr,Image = "..\\..\\..\\Pictures\\6.jpg" },
                new Food() { Id = 7, Name = "Tahin", CaloryPerUnit = 6.4, CategoryId = 1, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\7.png" },
                //Category name => Süt ve Süt Ürünleri
                new Food() { Id = 8, Name = "Beyaz Peynir", CaloryPerUnit = 2.7, CategoryId = 2, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\8.png" },
                new Food() { Id = 9, Name = "Kaşar Peyniri", CaloryPerUnit = 3.5, CategoryId = 2, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\9.png" },
                new Food() { Id = 10, Name = "Süt", CaloryPerUnit = 500, CategoryId = 2, UnitId = UnitType.lt, Image = "..\\..\\..\\Pictures\\10.jpg" },
                new Food() { Id = 11, Name = "Yoğurt", CaloryPerUnit = 0.73, CategoryId = 2, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\11.png" },
                //Category name => Meyve ve Sebze
                new Food() { Id = 12, Name = "Domates", CaloryPerUnit = 23, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\12.jpeg" },
                new Food() { Id = 13, Name = "Salatalık", CaloryPerUnit = 14, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\13.jpg" },
                new Food() { Id = 14, Name = "Carliston Biber", CaloryPerUnit = 20, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\14.jpg" },
                new Food() { Id = 15, Name = "Köy Biberi", CaloryPerUnit = 30, CategoryId = 3, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\15.png" },
                new Food() { Id = 16, Name = "Kapya Biberi", CaloryPerUnit = 25, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\16.png" },
                new Food() { Id = 17, Name = "Kırmızı Elma", CaloryPerUnit = 45, CategoryId = 3, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\17.jpg" },
                new Food() { Id = 18, Name = "Yeşil Elma", CaloryPerUnit = 50, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\18.jpg" },
                new Food() { Id = 19, Name = "Portakal", CaloryPerUnit = 47, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\19.jpg" },
                new Food() { Id = 20, Name = "Mandalina", CaloryPerUnit = 40, CategoryId = 3, UnitId = UnitType.Adet , Image = "..\\..\\..\\Pictures\\20.jpg" },
                new Food() { Id = 21, Name = "Kiraz", CaloryPerUnit = 1.4, CategoryId = 3, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\21.jpg" },
                new Food() { Id = 22, Name = "Karpuz", CaloryPerUnit = 45, CategoryId = 3, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\22.jpg" },

                //Category name => Ev Yemekleri
                new Food() { Id = 23, Name = "Tarhana Çorbası", CaloryPerUnit = 150, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\23.png" },
                new Food() { Id = 24, Name = "Mercimek Çorbası", CaloryPerUnit = 140, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\24.png" },
                new Food() { Id = 25, Name = "Ezogelin Çorbası", CaloryPerUnit = 95, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\25.png" },
                new Food() { Id = 26, Name = "Tavuk Çorbası", CaloryPerUnit = 132, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\26.png" },
                new Food() { Id = 27, Name = "Pirinç Pilavı", CaloryPerUnit = 200, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\27.png" },
                new Food() { Id = 28, Name = "Bulgur Pilavı", CaloryPerUnit = 240, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\28.png" },
                new Food() { Id = 29, Name = "Kuru Fasülye", CaloryPerUnit = 265, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\29.png" },
                new Food() { Id = 30, Name = "Nohut", CaloryPerUnit = 160, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\30.png" },
                new Food() { Id = 31, Name = "Pırasa", CaloryPerUnit = 80, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\31.png" },
                new Food() { Id = 32, Name = "Brokoli", CaloryPerUnit = 40, CategoryId = 4, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\32.png" },

                //Category name => Et Yemekleri
                new Food() { Id = 33, Name = "Cağ Kebap", CaloryPerUnit = 250, CategoryId = 5, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\33.png" },
                new Food() { Id = 34, Name = "Adana Kebap", CaloryPerUnit = 400, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\34.png" },
                new Food() { Id = 35, Name = "Urfa Kebap", CaloryPerUnit = 380, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\35.png" },
                new Food() { Id = 36, Name = "Şiş Köfte", CaloryPerUnit = 500, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\36.png" },
                new Food() { Id = 37, Name = "Antrikot", CaloryPerUnit = 280, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\37.jpg" },
                new Food() { Id = 38, Name = "Biftek", CaloryPerUnit = 300, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\38.jpeg" },
                new Food() { Id = 39, Name = "Pirzola", CaloryPerUnit = 450, CategoryId = 5, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\39.png" },

                //Category name => Fast Food
                new Food() { Id = 40, Name = "Hamburger", CaloryPerUnit = 351, CategoryId = 6, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\40.png" },
                new Food() { Id = 41, Name = "Orta Boy Pizza", CaloryPerUnit = 265, CategoryId = 6, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\41.png" },
                new Food() { Id = 42, Name = "Patates Kızartması", CaloryPerUnit = 355, CategoryId = 6, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\42.png" },
                new Food() { Id = 43, Name = "Tavuk Döner", CaloryPerUnit = 272, CategoryId = 6, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\43.png" },
                new Food() { Id = 44, Name = "Et Döner", CaloryPerUnit = 391, CategoryId = 6, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\44.png" },
                new Food() { Id = 45, Name = "Midye", CaloryPerUnit = 15, CategoryId = 6, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\45.png" },

                 //Category name => Tatlı
                 new Food() { Id = 46, Name = "Kazan Dibi", CaloryPerUnit = 202, CategoryId = 7, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\46.png" },
                 new Food() { Id = 47, Name = "Sütlaç", CaloryPerUnit = 293, CategoryId = 7, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\47.png" },
                 new Food() { Id = 48, Name = "Baklava", CaloryPerUnit = 288, CategoryId = 7, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\48.png" },

                 //Category name => Fırın
                 new Food() { Id = 49, Name = "Beyaz Ekmek", CaloryPerUnit = 76, CategoryId = 8, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\49.png" },
                 new Food() { Id = 50, Name = "Simit", CaloryPerUnit = 220, CategoryId = 8, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\50.png" },
                 new Food() { Id = 51, Name = "Poğaça", CaloryPerUnit = 288, CategoryId = 8, UnitId = UnitType.Porsiyon, Image = "..\\..\\..\\Pictures\\51.jpg" },

                 //Category name => Atıştırmalık
                 new Food() { Id = 52, Name = "Kuru Meyve", CaloryPerUnit = 6.3, CategoryId = 9, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\52.png" },
                 new Food() { Id = 53, Name = "Leblebi", CaloryPerUnit = 3.6, CategoryId = 9, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\53.png" },
                 new Food() { Id = 54, Name = "Karışık Kureyemiş", CaloryPerUnit = 5.8, CategoryId = 9, UnitId = UnitType.gr, Image = "..\\..\\..\\Pictures\\54.png" },

                 //Category name => İçecekler
                 new Food() { Id = 55, Name = "Cola", CaloryPerUnit = 484, CategoryId = 10, UnitId = UnitType.lt, Image = "..\\..\\..\\Pictures\\55.png" },
                 new Food() { Id = 56, Name = "Ayran", CaloryPerUnit = 360, CategoryId = 10, UnitId = UnitType.lt, Image = "..\\..\\..\\Pictures\\56.png" },
                 new Food() { Id = 57, Name = "Enerji İçeceği", CaloryPerUnit = 133, CategoryId = 10, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\57.png" },
                 new Food() { Id = 58, Name = "Bira", CaloryPerUnit = 185, CategoryId = 10, UnitId = UnitType.Adet, Image = "..\\..\\..\\Pictures\\58.png" }
                );
        }
    }
}
