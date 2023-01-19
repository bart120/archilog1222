using APIExample.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.Data
{
    public class MockDbContext : ArchiDbContext
    {
        public MockDbContext(DbContextOptions options) : base(options)
        {
        }

        public static MockDbContext GetDbContext(bool withData = true)
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("dbtest").Options;
            var dbContext = new MockDbContext(options);

            if (withData)
            {
                dbContext.Users.Add(new APIExample.Models.User { Active= true, Name = "Leponge", FirstName = "Bob", BirthDate = DateTime.Now });
                dbContext.Users.Add(new APIExample.Models.User { Active = true, Name = "Leponge1", FirstName = "Bob1", BirthDate = DateTime.Now });
                dbContext.Users.Add(new APIExample.Models.User { Active = true, Name = "Leponge2", FirstName = "Bob2", BirthDate = DateTime.Now });
                dbContext.SaveChanges();
            }

            return dbContext;
        }
    }
}
