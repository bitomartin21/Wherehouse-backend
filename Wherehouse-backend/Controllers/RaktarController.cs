using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wherehouse_backend.Models;
using Wherehouse_backend.Repository;

namespace Wherehouse_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RaktarController : ControllerBase
    {
		private readonly WherehouseRep _context;

        public RaktarController(WherehouseRep context)
        {
            _context = context;
        }
		
        [HttpGet]
        public async Task<IEnumerable<Raktar>> Get()
        {
            return await _context.GetRaktarak();
        }

        [HttpGet("id")]
        public async Task<Raktar> Get(int id)
        {
            return await _context.GetRaktar(id);
        }
		[HttpGet("cim")]
        public async Task<IEnumerable<object>> GetAddress(string cim)
        {
            return await _context.GetRaktarAddress(cim);
        }

        [HttpPost]
        public async Task<Raktar> Post(Raktar raktar)
        {
            return await _context.AddRaktar(raktar);
        }

        [HttpPut]
        public async Task<Raktar> Put(Raktar raktar)
        {
            return await _context.UpdateRaktar(raktar);
        }


        [HttpDelete]
        public async Task<Raktar> Delete(int id)
        {
            return await _context.DeleteRaktar(id);
        }

    }
}
