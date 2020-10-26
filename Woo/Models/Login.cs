using System;
namespace Woo.Models
{
    public class Login
    {
        public int LoginId { get; set; }

        //Data
        public string UserId { get; set; }
        public string DeviceId { get; set; }
        public int SellerId { get; set; }
        public string ConnectionId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public string DataComment { get; set; }

        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public string CreatedId { get; set; }  //userid
        public DateTime UpdatingDate { get; set; }
        public string UpdatedId { get; set; }  //userid
        public string SysComment { get; set; }
    }
}
