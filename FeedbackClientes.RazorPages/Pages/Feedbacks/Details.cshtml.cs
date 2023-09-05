using FeedbackClientes.RazorPages.Data;
using FeedbackClientes.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeedbackClientes.RazorPages.Pages.Feedbacks
{
    public class Details : PageModel
    {
        private readonly AppDbContext _context;
        public FeedbackModel FeedbackModel { get; set;  } = new();
        
        public Details(AppDbContext context)
        {
          _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feedbacks == null) {
                return NotFound();
            }   

            var feedbackModel =
             await _context.Feedbacks.FirstOrDefaultAsync(f => f.IdFeedback == id);

             if (feedbackModel == null) {
                return NotFound();
             }

             FeedbackModel = feedbackModel;
            
            return Page();
        }

    }
}