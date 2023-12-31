﻿using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class UserBL : ICrud<User>
    {
        public UserBL()
        {
            db = new();
        }

        Team4Context db;
        public bool Add(User entity)
        {
            db.Users.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Users.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public User Find(int entityId)
        {
            return db.Users.Find(entityId);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public List<User> GetAllByUserSituation()
        {
            return db.Users.Where(user => user.ActivePassiveSituation == false).ToList();
        }

        public bool Update(User entity)
        {
            db.Users.Update(entity);
            return db.SaveChanges() > 0;
        }

        public int Login(string userName, string password)
        {
            User user = db.Users.Where(x => x.Email == userName && x.Password == password).SingleOrDefault();
            if (user != null)
            {
                return user.Id;
            }
            else
            {
                return -1;
            }
        }

        public User FindByEmail(string userName)
        {
            User user = db.Users.Where(a => a.Email == userName).FirstOrDefault();
            return user;
        }
    }
}
