using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PickleballAPIv3.Models;
using PickleballAPIv3.Data;
using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeaugeController : ControllerBase
    {

        private DataContext _context;

        public LeaugeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<List<Leauge>>> Get()
        {
            return Ok(await _context.Leauges.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Leauge>> Get(int id)
        {
            var Leauge = await _context.Leauges.FindAsync(id);
            if (Leauge == null)
            {
                return BadRequest("Leauge not found");
            }
            return Ok(Leauge);
        }


        [HttpPost]
        public async Task<ActionResult<List<Leauge>>> AddLeauge(Leauge Leauge)
        {
            _context.Leauges.Add(Leauge);
            await _context.SaveChangesAsync();
            return Ok(Leauge);
        }

        [HttpPut]
        public async Task<ActionResult<Leauge>> UpdateLeauge(Leauge request)
        {
            var Leauge = await _context.Leauges.FindAsync(request.LeaugeId);
            if (Leauge == null)
            {
                return BadRequest("Leauge not found");
            }
            if(request.LeaugeName != null)
            {
                Leauge.LeaugeName = request.LeaugeName;
            }
            if(request.LeaugeStartDate != null)
            {
                Leauge.LeaugeStartDate = request.LeaugeStartDate;
            }

            await _context.SaveChangesAsync();

            return Ok(Leauge);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Leauge>>> Delete(int id)
        {
            var Leauge = await _context.Leauges.FindAsync(id);
            if (Leauge == null)
            {
                return BadRequest("Leauge not found");
            }
            _context.Leauges.Remove(Leauge);
            await _context.SaveChangesAsync();

            return Ok(Leauge);
        }
    }
}
