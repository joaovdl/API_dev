using gerenciamentoapirest.Data;
using gerenciamentoapirest.Models;
using gerenciamentoapirest.Models.Entities;
using gerenciamentoapirest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentoapirest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController(ApiDbContext context) : ControllerBase
    {
        private readonly ApiDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Projetos.ToListAsync();

            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Projeto model)
        {
            _context.Projetos.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }

        private ActionResult CreatedAction(string v, object value, Projeto model)
        {
            throw new NotImplementedException();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Projetos
            .Include(t => t.Tarefas)
            .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) return NotFound();

            return Ok(model);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Update(int id, Projeto model)
        {
            if (id != model.Id) return BadRequest();

            var modeloDb = await _context.Projetos.AsNoTracking()
                .FirstOrDefaultAsync(c => c.id == id);

            if (modeloDb == null) return NotFound();

            _context.Projetos.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Projetos.FindAsync(id);

            if (model == null) return NotFound();

            _context.Projetos.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}