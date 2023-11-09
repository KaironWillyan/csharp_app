using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace library.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<ReferenceBook> ReferenceBooks { get; set; }
        public DbSet<GeneralBook> GeneralBooks { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}