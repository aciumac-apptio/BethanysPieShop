using BethanysPieShop.Web.EFModels;
using System.Collections.Generic;

namespace BethanysPieShop.Web.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
