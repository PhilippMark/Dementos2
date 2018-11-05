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
    class ScheduleMap : EntityTypeConfiguration<Schedule>
    {
        public ScheduleMap()
        {
            this.HasKey(u => u.Id);
            this.HasRequired(s => s.User);
        }
    }

    public class Schedule : Entity
    {   
        public string Name { get; set; }        
        public DateTime Date { get; set; }
        public bool isDone { get; set; }

        public virtual User User { get; set; }
    }
}
