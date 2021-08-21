using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EF
{
    class LibraryDbInitializer : CreateDatabaseIfNotExists<LibraryDbContext>
    {
        protected override void Seed(LibraryDbContext context)
        {
            base.Seed(context);

            var author1 = context.Authors.Add(new Author()
            {
                Name = "Bob",
                Surname = "Lewicki",
                Parentname = "Bobov"
            });

            context.SaveChanges();
        }
    }
}
