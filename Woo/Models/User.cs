using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class User : GTable
    {
        public int ID { get; set; }
        public int UserNum { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string password{ get; set; }
        public string Comment { get; set; }

        public string RoleId { get; set; }
        
        public int SellerId { get; set; }
        public int DeviceId { get; set; }

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
