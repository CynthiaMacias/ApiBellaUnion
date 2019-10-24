﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIIBU.Data;
using APIIBU.Models;
using Microsoft.EntityFrameworkCore;

namespace APIIBU.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly DepPuestoContexto _context;
        public HorarioController(DepPuestoContexto contexto)
        {
            _context = contexto;
        }
        public async Task<ActionResult<IEnumerable<Horario>>> GetHorario2()
        {
            return await _context.Horario.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Horario>> GetIdHorario2(int id)
        {
            var item = await _context.Horario.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpPost]
        public async  Task<IActionResult> AddHorario([FromBody] Horario horario2)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();

            }
            this._context.Horario.Add(horario2);
            this._context.SaveChanges();
            await _context.SaveChangesAsync();
            return NoContent();

        }
        [HttpPut("{Id}")]
        public IActionResult Update([FromBody] Horario hor2, int id)
        {
            if (hor2.Id != id)
            {
                return BadRequest();
            }

            _context.Entry(hor2).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
    }
}