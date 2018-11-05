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
    class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            this.HasKey(u => u.Id);
            this.HasRequired(u => u.User);
        }
    }

    public class Login : Entity
    {   
        public string LoginName { get; set; }
        public string Password { get; set; }
        
        public virtual User User { get; set; }
    }
}
