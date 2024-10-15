using Company.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Data.Configurations
{
    public class DependentConfigrations : IEntityTypeConfiguration<Dependent>
    {
        public void Configure(EntityTypeBuilder<Dependent> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(1, 1);
        }
    }
}
