using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Pages_Utilizadores
{
    public class IndexModel : PageModel
    {
        private readonly BibliotecaContext _context;

        public IndexModel(BibliotecaContext context)
        {
            _context = context;
        }

        public IList<Utilizador> Utilizador { get;set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public string? Ordem { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Utilizador.AsQueryable();
            if (Ordem == "nome_desc")
            {
                Utilizador = await query
                .OrderByDescending(u=> u.Nome)
                .ToListAsync();
            }
            else if (Ordem == "nome_asc")
            {
                Utilizador = await query
                .OrderBy(u=> u.Nome)
                .ToListAsync();
            }
            else
            {
                Utilizador = await query.ToListAsync();
            }            
        }
    }
}
