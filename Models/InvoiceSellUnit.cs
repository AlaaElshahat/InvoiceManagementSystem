﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("InvoiceSellUnit")]
    [Index("invoiceNo", "buildingNo", Name = "FK_R_150")]
    [Index("aName", Name = "IX_InvoiceSellUnit_aName")]
    [Index("accountNo", Name = "IX_InvoiceSellUnit_accountNo")]
    [Index("barCode", Name = "IX_InvoiceSellUnit_barCode")]
    [Index("buildingNo", Name = "IX_InvoiceSellUnit_buildingNo")]
    [Index("deliveryDate", Name = "IX_InvoiceSellUnit_deliveryDate")]
    [Index("deliveryDateH", Name = "IX_InvoiceSellUnit_deliveryDateH")]
    [Index("eName", Name = "IX_InvoiceSellUnit_eName")]
    [Index("serialNo", Name = "IX_InvoiceSellUnit_serialNo")]
    [Index("storeNo", Name = "IX_InvoiceSellUnit_storeNo")]
    public partial class InvoiceSellUnit
    {
        [Key]
        public long invoiceNo { get; set; }
        [Key]
        [Column(TypeName = "decimal(28, 0)")]
        public decimal buildingNo { get; set; }
        [Key]
        public int orderNo { get; set; }
        [Column(TypeName = "decimal(28, 0)")]
        public decimal itemNo { get; set; }
        public short? unitNo { get; set; }
        [Required]
        [StringLength(250)]
        public string aName { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string eName { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal quantity { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal price { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? quantityFinished { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? discount { get; set; }
        [Column(TypeName = "decimal(12, 7)")]
        public decimal? discountPercent { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? discountTotal { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? total { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? totalPlusTax { get; set; }
        public bool? isPosted { get; set; }
        public bool? isGLPosted { get; set; }
        public bool? isPrint { get; set; }
        public long? lineTypeNo { get; set; }
        [Column(TypeName = "decimal(27, 0)")]
        public decimal? projectNo { get; set; }
        [Column(TypeName = "decimal(21, 0)")]
        public decimal? accountNo { get; set; }
        [StringLength(24)]
        [Unicode(false)]
        public string barCode { get; set; }
        [Column(TypeName = "decimal(21, 0)")]
        public decimal? costAccountNo { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? cost { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? expirationDateG { get; set; }
        public long? storeTransactionNo { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? buyPrice_costPrice { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? buyPrice_costPrice2 { get; set; }
        public bool? isServiceCompleted { get; set; }
        public short? taxCodeNo { get; set; }
        [Column(TypeName = "decimal(12, 7)")]
        public decimal? taxRate1_Percentage { get; set; }
        [Column(TypeName = "decimal(12, 7)")]
        public decimal? taxRate2_Percentage { get; set; }
        public short? taxRateNo2 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? taxRate1_Total { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? taxRate2_Total { get; set; }
        public bool? isOneInvoiceUploaded { get; set; }
        public short? taxRateNo { get; set; }
        [Column(TypeName = "decimal(28, 0)")]
        public decimal? storeNo { get; set; }
        [Column(TypeName = "decimal(27, 0)")]
        public decimal? itemCategoryNo { get; set; }
        [Column(TypeName = "decimal(27, 0)")]
        public decimal? itemClassificationTreeNo { get; set; }
        [Column(TypeName = "decimal(27, 0)")]
        public decimal? itemLocationNo { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? profitMarginTotal { get; set; }
        [Column(TypeName = "decimal(27, 0)")]
        public decimal? itemDepartmentNo { get; set; }
        public int? print_numOfCopies { get; set; }
        [StringLength(60)]
        public string itemModel { get; set; }
        public int? primaryUnit_SelectedUnitOrder { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? primaryUnit_Quantity { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? primaryUnit_ConvertionMultiple { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? primaryUnit_ConvertionAddition { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal itemUnitLeastPriceAtThisTime { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? store_QuantityBeforePost { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? addsQuantity { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? addsWeight { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? quantityReturned { get; set; }
        public bool? isReturnedFully { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? quantityRemaining { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? itemSize { get; set; }
        [StringLength(27)]
        public string insuranceTime { get; set; }
        [StringLength(50)]
        public string insuranceNote { get; set; }
        [StringLength(24)]
        [Unicode(false)]
        public string serialNo { get; set; }
        [StringLength(24)]
        [Unicode(false)]
        public string serialNo2 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? buyPrice2 { get; set; }
        public int? importOrderNo { get; set; }
        public bool? isPauseExpiry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? pauseExpiryDateG { get; set; }
        public int? pauseDays { get; set; }
        public int? pauseNumberOfTimesTillNow { get; set; }
        public int? totalPausedDaysTillNow { get; set; }
        public int? price_selectedNo { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? price_differenceFromFirstPrice { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? price_differenceFromFirstPriceTotal { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? runningCostAvg { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? runningCostAvg_perCurrentUnit { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? runningCostAvg_diffrenceWhithPrice { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? runningCostAvg_diffrenceWhithPriceTotal { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? profitMarginTotal_fromAvgCost { get; set; }
        public long? discountMultiplicationTypeNo { get; set; }
        [StringLength(150)]
        public string note { get; set; }
        [Column(TypeName = "decimal(22, 6)")]
        public decimal? runningCostAvgTotal { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? buyPrice_costPriceTotal { get; set; }
        public bool? isSourceOfContent { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? weight { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? weightTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? deliveryDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string deliveryDateH { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? rentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? rentReturnDate { get; set; }
        public bool? isFixed { get; set; }
        public bool? isSpot { get; set; }
        public long? starchNo { get; set; }
        public long? blueWeightNo { get; set; }
        public bool? isHangerOrFold { get; set; }
        public long? merzamTypeNo { get; set; }
        public bool? isLost { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? dateDifferenceInDays { get; set; }
        public byte[] row_timestamp { get; set; }

        [ForeignKey("invoiceNo,buildingNo")]
        [InverseProperty("InvoiceSellUnits")]
        public virtual InvoiceSell InvoiceSell { get; set; }
    }
}