using System;
using System.ComponentModel.DataAnnotations;

namespace Woo.Models
{
    public class Resp
    {
        //Data
        public int ID { get; set; }
        public int RespNum { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string DataComment { get; set; }

        //System
        public DateTime CreationDate { get; set; }
        public int CreatedID { get; set; }
        public DateTime UpdatingDate { get; set; }
        public int UpdatedID { get; set; }
        public string SysComment { get; set; }
    }
}
