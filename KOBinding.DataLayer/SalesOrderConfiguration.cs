using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KOBinding.model;

namespace KOBinding.DataLayer
{
    public class SalesOrderConfiguration : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfiguration()
        {
            Property(so => so.CustomerName).HasMaxLength(30).IsRequired();
            Property(so => so.PoNumber).HasMaxLength(10).IsOptional();
            Ignore(so => so.ObjectState);
        }

    }
}
