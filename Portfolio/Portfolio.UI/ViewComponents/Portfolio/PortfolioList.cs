using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        

            PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
            public IViewComponentResult Invoke()
            {
                var values = portfolioManager.TGetList();
                return View(values);
            }
        
    }
}
