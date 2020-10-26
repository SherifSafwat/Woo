using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Woo.Models
{
    [Table("OrderTail")]
    public class OrderTail
    {
        public int OrderTailId { get; set; }

        //Data
        public int OrderHeadId { get; set; }
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
        public string ClientId { get; set; }
        public string BranchId { get; set; }

        //Security
        public bool Enabled { get; set; }
        public string GrantBy { get; set; }
        public DateTime GrantFromDate { get; set; }
        public DateTime GrantToDate { get; set; }
        public string GrantComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedID { get; set; }
        public DateTime UpdatingDate { get; set; }
        public string UpdatedID { get; set; }
        public string SysComment { get; set; }
    }
}
