using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.ViewModel
{
    public class InvoicesellAndInvoicesellunitViewModel
    {
        public string eName { get; set; }
        public string aName { get; set; }
        [Column(TypeName = "decimal(21, 0)")]
        public decimal? clientVendorNo { get; set; }
        [StringLength(50)]
        public string mainContact1 { get; set; }
        public long? Inv_invoiceNo { get; set; }
    }
}
