using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Seller
    {
        public int SellerId { get; set; }

        //Data
        public int SellerNum { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string DataComment { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }

        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Contact3 { get; set; }
        public string Contact4 { get; set; }
        public string Contact5 { get; set; }

        //Comments
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }

        //Security
        public bool Enabled { get; set; }
        public string GrantBy { get; set; }  //userid
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
