﻿using EntitiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class AddedFoodCfg : IEntityTypeConfiguration<AddedFood>
    {
        public void Configure(EntityTypeBuilder<AddedFood> builder)
        {
            builder.Property(b => b.CreationDate).HasDefaultValue(DateTime.Now);
        }
    }
}
