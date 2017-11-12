﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SMSAppDBEntities : DbContext
    {
        public SMSAppDBEntities()
            : base("name=SMSAppDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblBaseAssessmentYear> tblBaseAssessmentYears { get; set; }
        public DbSet<tblBaseAttendanceType> tblBaseAttendanceTypes { get; set; }
        public DbSet<tblBaseBloodGroup> tblBaseBloodGroups { get; set; }
        public DbSet<tblBaseCalenderYear_HolidayList> tblBaseCalenderYear_HolidayList { get; set; }
        public DbSet<tblBaseCity> tblBaseCities { get; set; }
        public DbSet<tblBaseClassesBasedonSchoolType> tblBaseClassesBasedonSchoolTypes { get; set; }
        public DbSet<tblBaseComplaintMesg> tblBaseComplaintMesgs { get; set; }
        public DbSet<tblBaseConstant> tblBaseConstants { get; set; }
        public DbSet<tblBaseCountry> tblBaseCountries { get; set; }
        public DbSet<tblBaseDeptsInSchool> tblBaseDeptsInSchools { get; set; }
        public DbSet<tblBaseDistrict> tblBaseDistricts { get; set; }
        public DbSet<tblBaseErrorMessage> tblBaseErrorMessages { get; set; }
        public DbSet<tblBaseExamType> tblBaseExamTypes { get; set; }
        public DbSet<tblBaseFeedbackMesg> tblBaseFeedbackMesgs { get; set; }
        public DbSet<tblBaseGrade> tblBaseGrades { get; set; }
        public DbSet<tblBaseKnownLanguage> tblBaseKnownLanguages { get; set; }
        public DbSet<tblBaseMedium> tblBaseMediums { get; set; }
        public DbSet<tblBaseMeetingType> tblBaseMeetingTypes { get; set; }
        public DbSet<tblBaseMonth> tblBaseMonths { get; set; }
        public DbSet<tblBaseNotificationType> tblBaseNotificationTypes { get; set; }
        public DbSet<tblBasePhoneCountryCode> tblBasePhoneCountryCodes { get; set; }
        public DbSet<tblBaseRole> tblBaseRoles { get; set; }
        public DbSet<tblBaseSchoolCollegeType> tblBaseSchoolCollegeTypes { get; set; }
        public DbSet<tblBaseSection> tblBaseSections { get; set; }
        public DbSet<tblBaseState> tblBaseStates { get; set; }
        public DbSet<tblBaseStudentDeptsInSchool> tblBaseStudentDeptsInSchools { get; set; }
        public DbSet<tblBaseUndeclaredHolidayMessage> tblBaseUndeclaredHolidayMessages { get; set; }
        public DbSet<tblBaseWeekDay> tblBaseWeekDays { get; set; }
        public DbSet<tblBaseWishingMesg> tblBaseWishingMesgs { get; set; }
        public DbSet<tblBaseYear> tblBaseYears { get; set; }
        public DbSet<tblClassSectionTimeTable> tblClassSectionTimeTables { get; set; }
        public DbSet<tblClassSectionTimeTable_Records> tblClassSectionTimeTable_Records { get; set; }
        public DbSet<tblClassWiseSection> tblClassWiseSections { get; set; }
        public DbSet<tblClassWiseSections_History> tblClassWiseSections_History { get; set; }
        public DbSet<tblClasswiseSubjects_History> tblClasswiseSubjects_History { get; set; }
        public DbSet<tblClasswiseSyllabu> tblClasswiseSyllabus { get; set; }
        public DbSet<tblClasswiseSyllabus_Records> tblClasswiseSyllabus_Records { get; set; }
        public DbSet<tblParentDetail> tblParentDetails { get; set; }
        public DbSet<tblSchool_Regist_OTPs> tblSchool_Regist_OTPs { get; set; }
        public DbSet<tblSchoolDetail> tblSchoolDetails { get; set; }
        public DbSet<tblSchoolGradeDefinition> tblSchoolGradeDefinitions { get; set; }
        public DbSet<tblSchoolHolidayList> tblSchoolHolidayLists { get; set; }
        public DbSet<tblSchoolHolidayList_History> tblSchoolHolidayList_History { get; set; }
        public DbSet<tblSchoolInandOutTime> tblSchoolInandOutTimes { get; set; }
        public DbSet<tblSchoolStaffDept> tblSchoolStaffDepts { get; set; }
        public DbSet<tblSchoolStudentDept> tblSchoolStudentDepts { get; set; }
        public DbSet<tblSchoolWeekOff> tblSchoolWeekOffs { get; set; }
        public DbSet<tblSchoolWiseClass> tblSchoolWiseClasses { get; set; }
        public DbSet<tblSchoolWiseClasses_History> tblSchoolWiseClasses_History { get; set; }
        public DbSet<tblSchoolWiseMedium> tblSchoolWiseMediums { get; set; }
        public DbSet<tblSchoolWiseSection> tblSchoolWiseSections { get; set; }
        public DbSet<tblSchoolwiseSubject> tblSchoolwiseSubjects { get; set; }
        public DbSet<tblStaffDetail> tblStaffDetails { get; set; }
        public DbSet<tblStudentDetail> tblStudentDetails { get; set; }
        public DbSet<tblBaseSchoolStudentRange> tblBaseSchoolStudentRanges { get; set; }
        public DbSet<tblBaseUniversity> tblBaseUniversities { get; set; }
    }
}