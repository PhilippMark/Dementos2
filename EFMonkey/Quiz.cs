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
    class QuizMap : EntityTypeConfiguration<Quiz>
    {
        public QuizMap()
        {
            this.HasKey(u => u.Id);
            this.HasRequired(s => s.User);
            this.HasOptional(s => s.Document);
        }
    }

    public class Quiz : Entity
    {   
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        
        public virtual User User { get; set; }
        public virtual Document Document { get; set; }
    }
}
