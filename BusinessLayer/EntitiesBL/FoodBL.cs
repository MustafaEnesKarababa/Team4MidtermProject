﻿using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class FoodBL : ICrud<Food>
    {
        public FoodBL()
        {
            db = new();
        }

        Team4Context db;
        public bool Add(Food entity)
        {
            db.Foods.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Foods.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public Food Find(int entityId)
        {
            return db.Foods.Find(entityId);
        }

        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

        public List<Food> GetByCategory(int id)
        {
            return db.Foods.Where(a => a.CategoryId == id).ToList();
        }

        public bool Update(Food entity)
        {
            db.Foods.Update(entity);
            return db.SaveChanges() > 0;
        }
        public List<Food> GetByText(string name)
        {
            return db.Foods.Where(a => a.Name.Contains(name)).ToList();
        }
    }
}
