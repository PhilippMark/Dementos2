using System;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace  EFMonkey
{
    public class EFMonkeyInitializer : CreateDatabaseIfNotExists<EFMonkeyContext>
    {
        protected override void Seed(EFMonkeyContext context)
        {
            IList<UserType> defaultUserTypes = new List<UserType>();

            defaultUserTypes.Add(new UserType() { Name = "Patient" });
            defaultUserTypes.Add(new UserType() { Name = "Pflege" });
            defaultUserTypes.Add(new UserType() { Name = "Familie" });

            foreach (UserType tpr in defaultUserTypes)
                context.UserType.Add(tpr);

            base.Seed(context);
        }
    }

    public class EFMonkeyContext : DbContext
    {
        public EFMonkeyContext()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "db757812794.db.1and1.com";   // update me
            builder.UserID = "dbo757812794";              // update me
            builder.Password = "1959ortsac";      // update me
            builder.InitialCatalog = "db757812794";
            this.Database.Connection.ConnectionString = builder.ConnectionString;
            //SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();
            //myBuilder.ConnectionString = "Data Source=DESKTOP-KU3S3Q9;Initial Catalog =db702146810; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //this.Database.Connection.ConnectionString = myBuilder.ConnectionString;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            Database.SetInitializer(new EFMonkeyInitializer());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new QuizMap());
            modelBuilder.Configurations.Add(new ScheduleMap());
            modelBuilder.Configurations.Add(new UserTypeMap());
        }
        public DbSet<User> User { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<UserType> UserType { get; set; }


        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is Entity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((Entity)entity.Entity).UpdateDate = DateTime.UtcNow;
                    ((Entity)entity.Entity).CreateDate = DateTime.UtcNow;
                }
                else
                {
                    ((Entity)entity.Entity).UpdateDate = DateTime.UtcNow;
                }
            }
        }
    }
}
