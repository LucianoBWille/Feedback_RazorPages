using FeedbackClientes.RazorPages.Models;

namespace FeedbackClientes.RazorPages.Data {
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Feedbacks!.Any())
            {
                var feedbacks = new FeedbackModel[] {
                    new FeedbackModel{
                        NomeCliente ="Fulano de Tal",
                        EmailCliente = "fulanodetal@gmail.com",
                        Comentário = "Somente um comentário qualquer",
                        DataFeedback = DateTime.Parse("2023-09-01"),
                        Avaliação = 3
                    },
                };
                context.AddRange(feedbacks);
            }
            context.SaveChanges();
        }
    }
}