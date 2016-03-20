//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ceu_Education_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Person
    {
        public tbl_Person()
        {
            this.tbl_CEU_Certificate_Download = new HashSet<tbl_CEU_Certificate_Download>();
            this.tbl_ConferenceEnrollment = new HashSet<tbl_ConferenceEnrollment>();
            this.tbl_Licensing = new HashSet<tbl_Licensing>();
            this.tbl_Person_Degrees = new HashSet<tbl_Person_Degrees>();
            this.tbl_Person_Licenses = new HashSet<tbl_Person_Licenses>();
            this.tbl_Person_Organization_Roles = new HashSet<tbl_Person_Organization_Roles>();
            this.tbl_Persons_Professions = new HashSet<tbl_Persons_Professions>();
        }
    
        public int PersonID { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public Nullable<int> SuffixID { get; set; }
        public Nullable<int> SexID { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<long> NasnIdentifier { get; set; }
        public string UserName { get; set; }
        public Nullable<int> SecretQuestionID { get; set; }
        public string SecretQuestionAnswer { get; set; }
        public string PhonePersonal { get; set; }
        public string MobilePerson { get; set; }
        public string SSN { get; set; }
        public string EMailPersonal { get; set; }
        public Nullable<int> Residence_StateID { get; set; }
        public Nullable<int> Residence_MunicipalityID { get; set; }
        public string Residence_StreetName { get; set; }
        public Nullable<int> Residence_BuildingNumber { get; set; }
        public string Residence_Unit { get; set; }
        public string Residence_Zipcode { get; set; }
        public string Residence_Zipcode4 { get; set; }
        public Nullable<int> MailingStateID { get; set; }
        public Nullable<int> Mailing_MunicipalityID { get; set; }
        public string Mailing_StreetName { get; set; }
        public Nullable<int> Mailing_BuildingNumber { get; set; }
        public string Mailing_Unit { get; set; }
        public string Mailing_Zipcode { get; set; }
        public string Mailing_Zipcode4 { get; set; }
        public Nullable<int> DistrictSiteID { get; set; }
        public string PhoneWork { get; set; }
        public string EMailWork { get; set; }
        public string EINNbr { get; set; }
        public Nullable<int> LicenseStateID { get; set; }
        public Nullable<int> LicenseLevelID { get; set; }
        public string LicenseNbr { get; set; }
        public Nullable<System.DateTime> LicenseExpirationDate { get; set; }
        public Nullable<bool> Deceased { get; set; }
        public Nullable<int> MailingAddressTypeID { get; set; }
        public Nullable<int> DistrictID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<bool> Retired { get; set; }
    
        public virtual ICollection<tbl_CEU_Certificate_Download> tbl_CEU_Certificate_Download { get; set; }
        public virtual ICollection<tbl_ConferenceEnrollment> tbl_ConferenceEnrollment { get; set; }
        public virtual ICollection<tbl_Licensing> tbl_Licensing { get; set; }
        public virtual ICollection<tbl_Person_Degrees> tbl_Person_Degrees { get; set; }
        public virtual ICollection<tbl_Person_Licenses> tbl_Person_Licenses { get; set; }
        public virtual ICollection<tbl_Person_Organization_Roles> tbl_Person_Organization_Roles { get; set; }
        public virtual ICollection<tbl_Persons_Professions> tbl_Persons_Professions { get; set; }
    }
}