using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class UserResp
    {
        //Data
        public int ID { get; set; }
        public int UserRespNum { get; set; }
        public int UserId { get; set; }
        public int RespId { get; set; }
        public string DataComment { get; set; }

        //Security
        public bool Enabled { get; set; }
        public int GrantBy { get; set; }  //userid
        public DateTime GrantFromDate { get; set; }
        public DateTime GrantToDate { get; set; }
        public string GrantComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public int CreatedID { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public int UpdatedID { get; set; }  //userid
        public string SysComment { get; set; }
    }
}
