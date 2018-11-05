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
    class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            this.HasKey(u => u.Id);
            this.HasRequired(s => s.User);
            this.HasOptional(s => s.Document);
        }
    }

    public class Contact : Entity
    {   
        public string Name { get; set; }
        public string Mailadress { get; set; }
        
        public virtual User User { get; set; }
        public virtual Document Document { get; set; }
    }
}
