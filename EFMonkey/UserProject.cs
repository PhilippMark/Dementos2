using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMonkey
{
    class UserProjectMap : EntityTypeConfiguration<UserProject>
    {
        public UserProjectMap()
        {
            //this.HasRequired(up => up.Project).WithMany(p => p.Users);
            //this.HasRequired(up => up.User).WithMany(p => p.Projects);
        }
    }

    public class UserProject
    {
        [Key]
        public int ID { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
