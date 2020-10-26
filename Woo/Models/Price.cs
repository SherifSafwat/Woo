using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Price
    {
        public int PriceId { get; set; }

        //ID
        public int ItemId { get; set; }
        public Item ItemObj { get; set; }

        //Data
        [Display(Name = "PriceNum")]
        public int PriceNum { get; set; }
        [Display(Name = "ItemPrice")]
        public int ItemPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [Display(Name = "DataComment")]
        public string DataComment { get; set; }

        //Comments
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }

        //Hierarchy
        public int SourceId { get; set; } //system or sellerid
        public int SellerId { get; set; }
        public Seller SellerObj { get; set; }
        public string BranchId { get; set; }

        //Security
        public bool Enabled { get; set; }
        public string GrantBy { get; set; }  // system or userid
        public DateTime GrantFromDate { get; set; }
        public DateTime GrantToDate { get; set; }
        public string GrantComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedId { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedId { get; set; }  //userid
        public string SysComment { get; set; }

    }
}
