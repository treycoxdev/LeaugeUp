﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PickleballAPIv3.Models;
using PickleballAPIv3.Data;
using Microsoft.EntityFrameworkCore;

namespace PickleballAPIv3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private DataContext _context;

        public TeamController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<List<Team>>> Get()
        {
            return Ok(await _context.Teams.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> Get(int id)
        {
            var Team = await _context.Teams.FindAsync(id);
            if (Team == null)
            {
                return BadRequest("Team not found");
            }
            return Ok(Team);
        }


        [HttpPost]
        public async Task<ActionResult<List<Team>>> AddTeam(Team Team)
        {
            _context.Teams.Add(Team);
            await _context.SaveChangesAsync();
            return Ok(Team);
        }

        [HttpPut]
        public async Task<ActionResult<Team>> UpdateTeam(Team request)
        {
            var Team = await _context.Teams.FindAsync(request.TeamId);
            if (Team == null)
            {
                return BadRequest("Team not found");
            }
            if (request.TeamName != null)
            {
                Team.TeamName = request.TeamName;
            }

            await _context.SaveChangesAsync();

            return Ok(Team);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Team>>> Delete(int id)
        {
            var Team = await _context.Teams.FindAsync(id);
            if (Team == null)
            {
                return BadRequest("Team not found");
            }
            _context.Teams.Remove(Team);
            await _context.SaveChangesAsync();

            return Ok(Team);
        }
    }
}
