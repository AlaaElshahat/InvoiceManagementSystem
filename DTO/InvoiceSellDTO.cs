using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DTO
{
    public class InvoiceSellDTO
    {
        public string eName { get; set; }
        public string aName { get; set; }
        [Column(TypeName = "decimal(21, 0)")]
        public decimal? clientVendorNo { get; set; }
        [StringLength(50)]
        public string mainContact1 { get; set; }
        public long? Inv_invoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dateG { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string dateH { get; set; }
    }
}
