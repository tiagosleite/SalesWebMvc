using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc1.Services
{
    public class DepartmentService
    {
        // Injeção de dependencia
        private readonly SalesWebMvc1Context _context;
        public DepartmentService(SalesWebMvc1Context context)
        {
            _context = context;
        }

        /// <summary>
        /// FindAllAsync
        /// </summary>
        /// <returns>Lista assincrona</returns>
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
