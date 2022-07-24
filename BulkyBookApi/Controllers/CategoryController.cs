using BulkyBookApi.Db;
using BulkyBookApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace BulkyBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _db.Catogories.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _db.Catogories.Where(c=>c.Id==id).FirstOrDefault();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Category c)
        {
            _db.Catogories.Add(c);
            _db.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category c)
        {
            _db.Catogories.Update(c);
            _db.SaveChanges();

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = _db.Catogories.Where(c => c.Id == id).FirstOrDefault();
            _db.Catogories.Remove(c);
            _db.SaveChanges();
        }
    }
}
