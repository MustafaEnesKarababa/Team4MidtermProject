﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configuration
{
    internal class UnitCfg : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.Property(b => b.Description).HasMaxLength(20);
        }
    }
}
