using System;
using System.Collections.Generic;

namespace Woo.Models
{
    public class ReportTail
    {
        public int ReportTailId { get; set; }

        //Head
        public int ReportHeadId { get; set; }
        public ReportHead reportHead { get; set; }

        //Headers
        public string Header0 { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Header3 { get; set; }
        public string Header4 { get; set; }
        public string Header5 { get; set; }
        public string Header6 { get; set; }
        public string Header7 { get; set; }
        public string Header8 { get; set; }
        public string Header9 { get; set; }
        public string Header10 { get; set; }
        public string Header11 { get; set; }
        public string Header12 { get; set; }
        public string Header13 { get; set; }
        public string Header14 { get; set; }
        public string Header15 { get; set; }
        public string Header16 { get; set; }
        public string Header17 { get; set; }
        public string Header18 { get; set; }
        public string Header19 { get; set; }


        //Info
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }

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
