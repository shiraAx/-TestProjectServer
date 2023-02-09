using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VisitTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly IParentService _parentService;
        public ParentsController(IParentService parentService)
        {
            _parentService = parentService;
        }

        // GET: api/<ParentsController>
        [HttpGet]
        public async Task< IEnumerable<ParentModel>> Get()
        {
            return await _parentService.GetAll();
        }

        // GET api/<ParentsController>/5
        [HttpGet("{id}")]
        public async Task< ParentModel> Get(string id)
        {
            return await _parentService.GetById(id);
        }

        // POST api/<ParentsController>
        [HttpPost]
        public async Task<ParentModel> Post([FromBody] ParentModel value)
        {
            return await _parentService.Add(value);
        }

        // PUT api/<ParentsController>/5
        [HttpPut("{id}")]
        public async Task<ParentModel> Put(int id, [FromBody] ParentModel value)
        {
            return await _parentService.Update(value);
        }

        // DELETE api/<ParentsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _parentService.Delete(id);
        }
    }
}
