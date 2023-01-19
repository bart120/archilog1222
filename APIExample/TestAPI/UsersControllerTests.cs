using APIExample.Controllers;
using APIExample.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Data;

namespace TestAPI
{
    public class UsersControllerTests
    {
        private UsersController _usersController;
        private MockDbContext _dbContext;
         

        [SetUp]
        public void Setup()
        {
            _dbContext = MockDbContext.GetDbContext();
            _usersController = new UsersController(_dbContext);
        }

        [Test]
        public async Task TestGetUsers()
        {
            var actionResult = await _usersController.GetUsers();
           // var result = actionResult.Result as ObjectResult;
            var values = actionResult.Value as IEnumerable<User>;

            //validation des tests
            //Assert.AreEqual((int)HttpStatusCode.OK, result.StatusCode);
            Assert.IsNotNull(values);
            Assert.AreEqual(_dbContext.Users.Count(), values.Count());

        }

        [Test]
        public async Task TestPostUser()
        {
            var user = new User { Active = true, Name = "Prost", FirstName = "Alain", BirthDate= DateTime.Now };
            var actionResult = await _usersController.PostUser(user);

            
            //Assert.Positive(value.ID, "L'utilisateur n'a pas d'ID");

            var userTest  = _dbContext.Users.SingleOrDefault(x => x.Name == "Prost");
            Assert.IsNotNull(userTest);

        }

    }
}
