using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EFMonkey
{
    class DocumentMap : EntityTypeConfiguration<Document>
    {
        public DocumentMap()
        {
            
        }
    }

    public class Document : Entity
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
