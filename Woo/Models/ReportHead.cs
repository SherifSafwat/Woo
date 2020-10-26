using System;
using System.Collections.Generic;

namespace Woo.Models
{
    public class ReportHead
    {
        public int ReportHeadId { get; set; }

        //Data
        public string ReportEName { get; set; }
        public string ReportAName { get; set; }
        public string ReportSQL { get; set; }
        public string ReportEDesc { get; set; }
        public string ReportADesc { get; set; }

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

        //Params
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string Param0 { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public string Param6 { get; set; }
        public string Param7 { get; set; }
        public string Param8 { get; set; }
        public string Param9 { get; set; }
        public string Param10 { get; set; }
        public string Param11 { get; set; }
        public string Param12 { get; set; }
        public string Param13 { get; set; }
        public string Param14 { get; set; }
        public string Param15 { get; set; }
        public string Param16 { get; set; }
        public string Param17 { get; set; }
        public string Param18 { get; set; }
        public string Param19 { get; set; }

        public string HeaderParam0 { get; set; }
        public string HeaderParam1 { get; set; }
        public string HeaderParam2 { get; set; }
        public string HeaderParam3 { get; set; }
        public string HeaderParam4 { get; set; }
        public string HeaderParam5 { get; set; }
        public string HeaderParam6 { get; set; }
        public string HeaderParam7 { get; set; }
        public string HeaderParam8 { get; set; }
        public string HeaderParam9 { get; set; }
        public string HeaderParam10 { get; set; }
        public string HeaderParam11 { get; set; }
        public string HeaderParam12 { get; set; }
        public string HeaderParam13 { get; set; }
        public string HeaderParam14 { get; set; }
        public string HeaderParam15 { get; set; }
        public string HeaderParam16 { get; set; }
        public string HeaderParam17 { get; set; }
        public string HeaderParam18 { get; set; }
        public string HeaderParam19 { get; set; }

        //Lists
        public List<ReportTail> ReportTails { get; set; }

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
