using EmpleadosAPI.Data;
using EmpleadosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpleadosAPI.Controllers
{
[Route("api/[controller]")]
[ApiController]

public class EmpleadoController : ControllerBase
{
    private readonly EmpleadoContext _context;

    public EmpleadoController (EmpleadoContext context)
    {
        _context = context;
    }

    [HttpPost] 
    public async Task<IActionResult> AddEmpleado([FromBody] Empleado empleado)
    {
          if(!ModelState.IsValid)
              return BadRequest(ModelState);

         _context.Empleados.Add(empleado);
         await _context.SaveChangesAsync();
         return Ok(empleado);

    }

    [HttpGet("{nombre}")]
        public async Task <IActionResult> GetEmpleadosByNombre(string nombre){
            var empleados = await _context.Empleados
            .Where( e => e.Nombre.Contains(nombre)).ToListAsync();

            if(empleados == null || !empleados.Any())
                return NotFound();

            return Ok(empleados);
            
        }
}
}
