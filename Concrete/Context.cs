using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Document> Documents { get; set; }
        //public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAuthority> RoleAuthorities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAuthority> UserAuthorities { get; set; }
    }
}
