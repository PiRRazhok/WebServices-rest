using DoughnutShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoughnutShop.Controllers
{
    public class DoughnutController : ApiController
    {

        private DoughnutShopDbContext db = new DoughnutShopDbContext();

        // [...] - anotations
        [HttpGet]
        [Route("doughnuts")]
        public IEnumerable<Doughnut> GetAll()
        {

            List<Doughnut> doughnuts = db.Doughnut.ToList();

            return doughnuts;
        }

        [HttpGet]
        [Route("doughnuts/{id}")]
        public IHttpActionResult Get(int id)
        {

            Doughnut doughnut = db.Doughnut.Find(id);

            return Ok(doughnut);
        }

        [HttpPost]
        [Route("doughnuts")]
        public IHttpActionResult Create([FromBody]Doughnut doughnut)
        {
            db.Doughnut.Add(doughnut);
            db.SaveChanges();

            return Ok(doughnut);
        }

        [HttpPut]
        [Route("doughnuts")]
        public IHttpActionResult Update([FromBody]Doughnut newDoughnut)
        {
            Doughnut doughnut = db.Doughnut.Find(newDoughnut.Id);
            doughnut.Update(newDoughnut);
            db.SaveChanges();

            return Ok(doughnut);
        }

        [HttpDelete]
        [Route("doughnuts/{id}")]
        public IHttpActionResult Delete(int id)
        {
            Doughnut doughnut = db.Doughnut.Find(id);
            db.Doughnut.Remove(doughnut);
            db.SaveChanges();

            return Ok();
        }
    }
}
