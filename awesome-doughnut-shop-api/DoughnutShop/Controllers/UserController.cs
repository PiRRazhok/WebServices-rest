using DoughnutShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoughnutShop.Controllers
{
    public class UserController : ApiController
    {
        private DoughnutShopDbContext db = new DoughnutShopDbContext();

        [HttpGet]
        [Route("users")]
        public IHttpActionResult GetAll()
        {

            List<User> users = db.User.ToList();

            return Ok(users);
        }

        [HttpGet]
        [Route("users/{id}")]
        public IHttpActionResult Get(int id)
        {

            User user = db.User.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            user.Password = null;

            return Ok(user);
        }

        [HttpPost]
        [Route("users")]
        public IHttpActionResult Create([FromBody]User user)
        {
            User newUser = new User(user);
            db.User.Add(newUser);
            db.SaveChanges();

            return Ok(user);
        }

        [HttpPut]
        [Route("users")]
        public IHttpActionResult Update([FromBody]User newUser)
        {
            User user = db.User.Find(newUser.Id);
            user.Update(newUser);
            db.SaveChanges();

            return Ok(user);
        }

        [HttpDelete]
        [Route("users/{id}")]
        public IHttpActionResult Delete(int id)
        {
            User user = db.User.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            db.User.Remove(user);
            db.SaveChanges();

            return Ok();
        }

        [HttpPost]
        [Route("users/checkauth")]
        public IHttpActionResult Authenticate([FromBody]UserCredentials user)
        {
            try
            {
                User curUser = db.User.First((u) => u.Email == user.Email);
            }
            catch (InvalidOperationException exception)
            {
                return Unauthorized();
            }

            return Ok();
        }
    }
}
