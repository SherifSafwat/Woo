using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class InvoiceT
    {
        public int ID { get; set; }

        //Data
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int PriceListId { get; set; }

        public int LineNum { get; set; }
        public int ItemNum { get; set; }
        public float Price { get; set; }
        public float Qty { get; set; }
        public float LineTax { get; set; }
        public float LineDisc { get; set; }
        public float TotalLine { get; set; }
        public string DataComment { get; set; }

        //Hierarchy
        public int SourceId { get; set; } //system or sellerid
        public int SellerId { get; set; }
        public Seller SellerObj { get; set; }
        public string BranchId { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedID { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedID { get; set; }  //userid
        public string SysComment { get; set; }
    }
}
