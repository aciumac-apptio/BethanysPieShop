using BethanysPieShop.Web.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Web.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly bethanypiesContext _bethanypiesContext;

        public PieRepository(bethanypiesContext bethanypiesContext)
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
