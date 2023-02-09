using _2_Services.Interfaces;
using _2_Services.Models;
using _2_Services.ServiceClasses;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VisitTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildrenController(IChildService childService)
        {
            _childService = childService;
        }

        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task< IEnumerable<ChildModel>> Get()
        {
            return await _childService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task< ChildModel> Get(string id)
        {
            return await _childService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel value)
        {
            return await _childService.Add(value);

      }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<ChildModel> Put(int id, [FromBody] ChildModel value)
        {
            return await _childService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.Delete(id);
        }
    }
}
