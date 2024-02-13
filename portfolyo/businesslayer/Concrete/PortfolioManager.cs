using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businesslayer.Abstract;
using dataaccesslayer.Abstract;
using entitylayer.Concrete;

namespace businesslayer.Concrete
{
    public class PortfolioManager : IPortfolio
    {
        IPortfolio _portfolio;

        public PortfolioManager(IPortfolio portfolio)
        {
            _portfolio = portfolio;
        }

        public void Delete(portfolio t)
        {
            _portfolio.Delete(t);
        }

        public portfolio GetByID(int id)
        {
            return _portfolio.GetByID(id);
        }

        public List<portfolio> GetList()
        {
            return _portfolio.GetList();
        }

        public void Insert(portfolio t)
        {
            _portfolio.Insert(t);
        }

        public void Update(portfolio t)
        {
            _portfolio.Update(t);
        }
    }
}
