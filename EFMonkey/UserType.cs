using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EFMonkey
{
    class UserTypeMap : EntityTypeConfiguration<UserType>
    {
        public UserTypeMap()
        {
            this.HasKey(u => u.Id);
            this.HasMany(p => p.Users).WithRequired(t => t.UserType);
        }
    }

    public class UserType : Entity
    {   
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}
