using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace MirrorDB
{
    public partial class MirrorDBContext:DbContext
    {
        /*Declare database info here*/
        public DbSet<FakeTable> FakeTable { get; set; }
        public MirrorDBContext()
        {
        }

        public MirrorDBContext(DbContextOptions<MirrorDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder = OptionMsSql(optionsBuilder);
            }
        }

        private string ConnectionString()
        {
            string connstring = string.Format(@"Server=localhost\sqlexpress;Database=GenDB;Trusted_Connection=True;");
            return connstring;
        }

        private DbContextOptionsBuilder OptionMsSql(DbContextOptionsBuilder optionsBuilder)
        {
            return optionsBuilder.UseSqlServer(ConnectionString());
        }

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
        public class IndexAttribute : Attribute
        {
            public bool IsUnique { get; set; }
            public bool IsClustered { get; set; }
        }
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
        public class MultiplePKAttribute : Attribute
        {
            public bool IsMultiplePK { get; set; }
        }
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
        public class DefaultAttribute : Attribute
        {
            public object DefaultValue { get; set; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.SetTableDefaultAttributes(modelBuilder);
            this.SetTableDefaultValues(modelBuilder);
            this.SetTableIndexAttributes(modelBuilder);
        }

        private void SetTableIndexAttributes(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var prop in entity.GetProperties())
                {
                    var attr = prop.PropertyInfo.GetCustomAttribute<IndexAttribute>();
                    if (attr != null)
                    {
                        var index = entity.AddIndex(prop);
                        index.IsUnique = attr.IsUnique;
                    }
                }
            }
        }

        private void SetTableDefaultAttributes(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties())
                {
                    var attr = property.PropertyInfo.GetCustomAttribute<DefaultAttribute>();
                    if (attr != null)
                    {
                        modelBuilder.Entity(entity.Name).Property(property.Name).HasDefaultValue(attr.DefaultValue);
                    }
                }
            }
        }

        private void SetTableDefaultValues(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties())
                {
                    string myfield = property.Name.Trim().ToLower().Replace("_", "").Replace("<", string.Empty).Replace(">k__BackingField", string.Empty);
                    if (myfield == "activebool")
                        modelBuilder.Entity(entity.Name).Property(property.Name).HasDefaultValue(true);
                    if (myfield == "insertdate")
                        modelBuilder.Entity(entity.Name).Property(property.Name).HasDefaultValue(DateTime.Now);
                }
            }
        }
    }

}
