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
    
    public partial class tblSchoolWiseSection
    {
        public int RecordId { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate_utc { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDate { get; set; }
        public Nullable<bool> Record_Status { get; set; }
        public string Assessmentyear { get; set; }
        public string SectionID { get; set; }
        public string Section_Desc { get; set; }
        public Nullable<int> Sch_Id { get; set; }
    
        public virtual tblSchoolDetail tblSchoolDetail { get; set; }
    }
}
