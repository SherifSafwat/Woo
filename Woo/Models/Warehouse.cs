using System;

namespace Woo.Models
{
    public class Warehouse
    {
        public int WareHouseId { get; set; }

        //Data
        public int WarehouseNum { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string DataComment { get; set; }

        public int AreaId { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }


        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

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
        public string GrantBy { get; set; }  //userid
        public DateTime GrantFromDate { get; set; }
        public DateTime GrantToDate { get; set; }
        public string GrantComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedID { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedID { get; set; }  //userid
        public string SysComment { get; set; }
    }
}
