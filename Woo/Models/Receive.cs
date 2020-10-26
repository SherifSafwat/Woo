using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Receive
    {        
        public int ReceiveId { get; set; }

        //ID
        //public int ReceiptId { get; set; }
        //public Receipt ReceiptObj { get; set; }
        public string UserId { get; set; }
        public ApplicationUser UserObj { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse WarehouseObj { get; set; }
        public int ItemId { get; set; }
        public Item ItemObj { get; set; }

        //Data
        [Display(Name = "Qty")]
        public int Qty { get; set; }
        [Display(Name = "EnteringDate")]
        public DateTime EnteringDate { get; set; }
        [Display(Name = "ReceiptNum")]
        public string ReceiptNum { get; set; }
        [Display(Name = "DataComment")]
        public string DataComment { get; set; }
      
        //Info
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

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
