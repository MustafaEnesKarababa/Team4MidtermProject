﻿using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }


        //Relations
        public ICollection<Food> Foods { get; set; }

    }
}
