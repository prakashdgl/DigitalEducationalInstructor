//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBaseCalenderYear_HolidayList
    {
        public int RecordId { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate_utc { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDate { get; set; }
        public string Holiday { get; set; }
        public string Holiday_Reason { get; set; }
        public Nullable<System.DateTimeOffset> FromDate { get; set; }
        public Nullable<System.DateTimeOffset> ToDate { get; set; }
        public string CountryCode { get; set; }
        public Nullable<bool> Record_Status { get; set; }
    }
}
