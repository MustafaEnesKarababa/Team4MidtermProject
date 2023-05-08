﻿using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    public class AddedFood
    {
        public int AddedFoodId { get; set; }
        public decimal CaloryPerUnit { get; set; }
        public decimal TotalCalory { get; set; }
        public DateTime CreationDate { get; set; }
        public double TargetCaloryPerDay { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
