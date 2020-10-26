using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Woo.Models
{
    [Table("OrderHead")]
    public class OrderHead
    {
        public int OrderHeadId { get; set; }

        //Data
        public int OrderNum { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime OrderTime { get; set; }

        public float Total { get; set; }
        public float TotalTax { get; set; }
        public float TotalDisc { get; set; }
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
        public int CustomerId { get; set; }
        public Customer CustomerObj { get; set; }

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
