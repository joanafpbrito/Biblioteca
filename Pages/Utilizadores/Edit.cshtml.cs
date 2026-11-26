using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Pages_Utilizadores
{
    public class EditModel : PageModel
    {
        private readonly Biblioteca.Data.BibliotecaContext _context;

        public EditModel(Biblioteca.Data.BibliotecaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Utilizador Utilizador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizador =  await _context.Utilizador.FirstOrDefaultAsync(m => m.UserID == id);
            if (utilizador == null)
            {
                return NotFound();
            }
            Utilizador = utilizador;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Utilizador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UtilizadorExists(Utilizador.UserID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UtilizadorExists(int id)
        {
            return _context.Utilizador.Any(e => e.UserID == id);
        }
    }
}
