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
    
    public partial class tblSchool_Regist_OTPs
    {
        public int RecordId { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate_utc { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDate { get; set; }
        public bool Record_Status { get; set; }
        public string Ph_CountryCode { get; set; }
        public string Ph_No { get; set; }
        public string OTP_Code { get; set; }
        public Nullable<System.DateTime> OTP_ExpiryDateTime { get; set; }
    }
}
