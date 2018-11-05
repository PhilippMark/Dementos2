using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EFMonkey
{
    class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            this.HasKey(u => u.Id);
        }
    }
    public class Entity
    {
                
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
