using FeedbackClientes.RazorPages.Data;
using FeedbackClientes.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeedbackClientes.RazorPages.Pages.Feedbacks
{
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        public List<FeedbackModel> FeedbackList { get; set;  } = new();
        
        public Index(AppDbContext context)
        {
          _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            FeedbackList = await _context.Feedbacks!.ToListAsync();
            return Page();
        }
    }
}