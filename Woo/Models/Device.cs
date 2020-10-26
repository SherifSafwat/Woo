using System;
using System.ComponentModel.DataAnnotations;


namespace Woo.Models
{
    public class Device
    {
        public int ID { get; set; }
        public int DeviceNum { get; set; }
        public string Comment { get; set; }

        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

        public int SellerId { get; set; }
        public int UserId { get; set; }

        //Security
        public bool Enabled { get; set; }
        public int GrantBy { get; set; }  //userid
        public DateTime GrantFromDate { get; set; }
        public DateTime GrantToDate { get; set; }
        public string GrantComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public int CreatedID { get; set; }
        public DateTime UpdatingDate { get; set; }
        public int UpdatedID { get; set; }
        public string SysComment { get; set; }
    }
}
