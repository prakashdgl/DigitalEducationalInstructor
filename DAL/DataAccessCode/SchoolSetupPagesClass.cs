﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace DAL.DataAccessCode
{
    public class SchoolSetupPagesClass
    {
        static IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

        public List<tblBaseSchoolCollegeType> GetBaseSchoolTypeList()
        {
            string sqlquery = "select * from tblBaseSchoolCollegeTypes where Record_Status=1";

            var list = db.Query<tblBaseSchoolCollegeType>(sqlquery).ToList();
            return list;
        }

        public List<tblBaseUniversity> GetBaseUniversityList()
        {
            string sqlquery = "select * from tblBaseUniversities where Record_Status=1";

            var list = db.Query<tblBaseUniversity>(sqlquery).ToList();
            return list;
        }

        public List<tblBaseSchoolStudentRange> GetBaseStudentCapacityList()
        {
            string sqlquery = "select * from tblBaseSchoolStudentRange where Record_Status=1";

            var list = db.Query<tblBaseSchoolStudentRange>(sqlquery).ToList();
            return list;
        }

        public List<tblBaseCountries> GetBaseCountriesList()
        {
            string sqlquery = "select * from tblBaseCountries where Record_Status=1";

            var list = db.Query<tblBaseCountries>(sqlquery).ToList();
            return list;
        }

        public List<tblBaseState> GetBaseStatesByCountryList(string country)
        {
            string sqlquery = "select * from tblBaseStates where Record_Status=1 and CountryCode = @CountryCode";

            var list = db.Query<tblBaseState>(sqlquery, new { CountryCode = country }).ToList();
            return list;
        }

        public List<tblBaseDistrict> GetBaseDistrictsByStateList(string country, string state)
        {
            string sqlquery = "select * from tblbasedistricts where Record_Status=1 and CountryCode = @CountryCode and StateCode = @StateCode";

            var list = db.Query<tblBaseDistrict>(sqlquery, new { CountryCode = country, StateCode = state }).ToList();
            return list;
        }

        public int AddSchoolDetails(tblSchoolDetail tblSchoolDetail)
        {
            string sqlquery = "INSERT INTO [dbo].[tblSchoolDetails] " +
           "([Sch_Name],[Sch_Code],[Sch_Contact_Person],[Sch_Type_Id],[Sch_CountryId],[Sch_StateId],[Sch_DistrictId]" +
           ",[Sch_DistrictName],[Sch_CityName],[Sch_PINCode],[Sch_Address1],[Sch_Address2],[Sch_PhNo1],[Sch_Alt_PhNo],[Sch_MobileNo]" +
           ",[Sch_EmailId],[Sch_Sector],[Sch_University],[Univ_Code],[Sch_Std_Range_Code],[Demo]," +
           "[ContactPreference],Landmark)" +
            "VALUES" +
           "(@Sch_Name,@Sch_Code,@Sch_Contact_Person,@Sch_Type_Id,@Sch_CountryId,@Sch_StateId,@Sch_DistrictId" +
           ",@Sch_DistrictName,@Sch_CityName,@Sch_PINCode,@Sch_Address1,@Sch_Address2,@Sch_PhNo1,@Sch_Alt_PhNo,@Sch_MobileNo" +
           ",@Sch_EmailId,@Sch_Sector,@Sch_University,@Univ_Code,@Sch_Std_Range_Code,@Demo," +
           "@ContactPreference,@Landmark);SELECT CAST(SCOPE_IDENTITY() as int) as RecordId";

            var returnId = db.Query(sqlquery, tblSchoolDetail).SingleOrDefault();
            tblSchoolDetail.RecordId =Convert.ToInt32( returnId.RecordId);
            return tblSchoolDetail.RecordId;
        }
    }
}
