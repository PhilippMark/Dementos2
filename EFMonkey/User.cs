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
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(u => u.Id);
            this.HasRequired(u => u.UserType).WithMany(p => p.Users);            
            this.HasOptional(s => s.Login).WithRequired(ad => ad.User);
            this.HasMany(u => u.Schedules).WithRequired(s => s.User);
            this.HasMany(u => u.Quizes).WithRequired(q => q.User);
            this.HasMany(u => u.Contacts).WithRequired(c => c.User);
            //this.HasMany(a => a.Projects)
            //    .WithMany(p => p.Users)
            //    .Map(x =>
            //    {
            //        x.MapLeftKey("User_Id");
            //        x.MapRightKey("Project_Id");
            //        x.ToTable("UserProject");
            //    });
        }
    }



    public class User : Entity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string ContactText { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual Login Login { get; set; }
        public IList<Schedule> Schedules { get; set; }
        public IList<Quiz> Quizes { get; set; }
        public IList<Contact> Contacts { get; set; }

    }
}
