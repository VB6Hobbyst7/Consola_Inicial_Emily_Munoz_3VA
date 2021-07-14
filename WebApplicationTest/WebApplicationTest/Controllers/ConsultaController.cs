using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplicationTest.Data;
using WebApplicationTest.Entities;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<EmpleadoSimple> Empleados()
        {
            IQueryable<Empleado> consulta = _context.Empleados.Include(e => e.Cursos);
            List<Empleado> empleados = consulta.ToList();
            return empleados.Select(e => EmpleadoSimple.Convertir(e));
        }
        public IEnumerable<EmpleadoSimple> EmpleadosPaginados(int pagina, int tamanio)
        {
            var salto = (pagina - 1) * tamanio;
            var empleados = _context.Empleados.Skip(salto).Take(tamanio).ToList();
            return empleados.Select(e => EmpleadoSimple.Convertir(e));
        }
    }
}