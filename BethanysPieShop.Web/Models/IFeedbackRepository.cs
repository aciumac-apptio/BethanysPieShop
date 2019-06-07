using BethanysPieShop.Web.EFModels;

namespace BethanysPieShop.Web.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
