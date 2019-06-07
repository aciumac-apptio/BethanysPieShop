using BethanysPieShop.Web.EFModels;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Web.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _bethanypiesContext;

        public PieRepository(AppDbContext bethanypiesContext)
        {
            _bethanypiesContext = bethanypiesContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _bethanypiesContext.Pie;
        }

        public Pie GetPieById(int pieId)
        {
            return _bethanypiesContext.Pie.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
