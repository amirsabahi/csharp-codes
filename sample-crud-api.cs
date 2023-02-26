using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YourController : ControllerBase
    {
        private readonly YourDbContext _dbContext;

        public YourController(YourDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<YourModel> GetAll()
        {
            return _dbContext.YourModels;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var yourModel = _dbContext.YourModels.Find(id);
            if (yourModel == null)
            {
                return NotFound();
            }
            return Ok(yourModel);
        }

        [HttpPost]
        public IActionResult Create(YourModel yourModel)
        {
            _dbContext.YourModels.Add(yourModel);
            _dbContext.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = yourModel.Id }, yourModel);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, YourModel yourModel)
        {
            if (id != yourModel.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(yourModel).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var yourModel = _dbContext.YourModels.Find(id);
            if (yourModel == null)
            {
                return NotFound();
            }

            _dbContext.YourModels.Remove(yourModel);
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
