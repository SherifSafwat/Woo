using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        //Data
        public int ClientNum { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string DataComment { get; set; }

        public int AreaId { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public string DeviceId { get; set; }

        //Address
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

        //Contact
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