using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Item
    {
        
        public int ItemId { get; set; }

        //Data
        [Display(Name = "ItemNum")]
        public int ItemNum{ get; set; }
        public int GlobalBarCode { get; set; }
        [Display(Name = "BarCode")]
        public int LocalBarCode { get; set; }
        public int TaxId { get; set; }
        [Display(Name = "EName")]
        public string EName { get; set; }
        [Display(Name = "AName")]
        public string AName { get; set; }
        [Display(Name = "DataComment")]
        public string DataComment { get; set; }

        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

        public int SourceID { get; set; } //system or sellerid

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

        //Lists
        public List<Price> ItemPrices { get; set; }
    }
}
