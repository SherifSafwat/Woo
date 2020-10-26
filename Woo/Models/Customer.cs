using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Customer
    {
        
        public int CustomerId { get; set; }

        //Data
        [Display(Name = "CustomerNum")]
        public int CustomerNum { get; set; }
        [Display(Name = "EName")]
        public string EName { get; set; }
        [Display(Name = "AName")]
        public string AName { get; set; }

        [Display(Name = "DataComment")]
        public string DataComment { get; set; }

        [Display(Name = "Address")]
        public string Address1 { get; set; }
        [Display(Name = "Address")]
        public string Address2 { get; set; }
        [Display(Name = "Address")]
        public string Address3 { get; set; }
        [Display(Name = "Address")]
        public string Address4 { get; set; }
        [Display(Name = "Address")]
        public string Address5 { get; set; }

        [Display(Name = "Contact")]
        public string Contact1 { get; set; }
        [Display(Name = "Contact")]
        public string Contact2 { get; set; }
        [Display(Name = "Contact")]
        public string Contact3 { get; set; }
        [Display(Name = "Contact")]
        public string Contact4 { get; set; }
        [Display(Name = "Contact")]
        public string Contact5 { get; set; }

        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }

        public int SourceID { get; set; } //system or sellerid

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedID { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedID { get; set; }  //userid
        public string SysComment { get; set; }
    }
}
