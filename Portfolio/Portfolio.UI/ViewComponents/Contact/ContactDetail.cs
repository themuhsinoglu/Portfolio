using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.ViewComponents.Contact
{
    public class ContactDetail: ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            ContactManager contactManager = new ContactManager(new EFContacDal());
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
