using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InvoiceSellandInvoiceSellUnitController : Controller
    {
        StoreContext StoreContext=new StoreContext();
        public IActionResult Index()
        {

            return View();
        }
    }
}
