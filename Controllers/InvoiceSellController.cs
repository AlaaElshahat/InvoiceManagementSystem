using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.DTO;
using MVCGrid;
using GridMvc;
using GridMvc.Columns;

namespace WebApplication1.Controllers
{
    public class InvoiceSellController : Controller
    {
        StoreContext _storeContext=new StoreContext();
        InvoiceSellDTO InvoiceSellDTO=new InvoiceSellDTO();
        public IActionResult Index()
        {
          List<InvoiceSell>invoiceSell=_storeContext.InvoiceSells.ToList();
            // ViewContext viewContext = new ViewContext();

            Grid<InvoiceSell> grid = new Grid<InvoiceSell>(invoiceSell,new HttpContext());
            // .Sortable()
            // .WithPaging(10)
            // .Columns(columns =>
            // {
            //     columns.Add(model => model.InvoiceId).Titled("Invoice ID");
            //     columns.Add(model => model.CustomerName).Titled("Customer Name");
            //     columns.Add(model => model.Amount).Titled("Amount");
            // });
            IGridColumnCollection<InvoiceSell> columns = grid.Columns;
            columns.Add(
                 columns.Add(invoiceSellDTo => invoiceSellDTo.invoiceNo)
            .Titled("invoice No")
            .Sortable(true)

                );
            columns.Add(
               columns.Add(invoiceSellDTo => invoiceSellDTo.eName)
          .Titled("English Name")
          .Sortable(true)

              );



            return View(invoiceSell);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
