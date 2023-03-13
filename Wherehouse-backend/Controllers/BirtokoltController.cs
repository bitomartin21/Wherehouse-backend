using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wherehouse_backend.Models;
using Wherehouse_backend.Repository;

namespace Wherehouse_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BirtokoltController : ControllerBase
    {
		private readonly WherehouseRep _context;

        public BirtokoltController(WherehouseRep context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Birtokolt>> Get()
        {
            return await _context.GetBirtokoltak();
        }

        [HttpGet("id")]
        public async Task<Birtokolt> Get(int id)
        {
            return await _context.GetBirtokolt(id);
        }
        [HttpPost]
        public async Task<Birtokolt> Post(int raktarId, int tulajId)
        {
            return await _context.AddBirtokolt(raktarId, tulajId);
        }

        [HttpPut]
        public async Task<Birtokolt> Put(Birtokolt birtokolt)
        {
            return await _context.UpdateBirtokolt(birtokolt);
        }

        [HttpDelete]
        public async Task<Birtokolt> Delete(int id)
        {
            return await _context.DeleteBirtokolt(id);
        }

    }
}
