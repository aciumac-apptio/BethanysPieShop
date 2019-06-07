using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Web.EFModels;

namespace BethanysPieShop.Web.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _bethanypiesContext;

        public FeedbackRepository(AppDbContext bethanypiesContext)
        {
            _bethanypiesContext = bethanypiesContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _bethanypiesContext.Feedback.Add(feedback);
            _bethanypiesContext.SaveChanges();
        }
    }
}
