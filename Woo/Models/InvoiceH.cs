using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class InvoiceH
    {

        public int ID { get; set; }

        //Data
        public int InvoiceNum { get; set; }
        public int UserId { get; set; }
        public int? DeviceId { get; set; }
        public int CustomerId { get; set; }
        public Customer CustomerObj { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime InvoiceTime { get; set; }

        public float Total { get; set; }
        public float TotalTax { get; set; }
        public float TotalDisc { get; set; }
        public string DataComment { get; set; }


        //Hierarchy
        public int SourceId { get; set; } //system or sellerid
        public int SellerId { get; set; }
        public Seller SellerObj { get; set; }
        public string BranchId { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedId { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedId { get; set; }  //userid
        public string SysComment { get; set; }

    }
}
