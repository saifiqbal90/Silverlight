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
    
    public partial class sp_GetConferenceDescriptionForConfereneRoster_Get_Result
    {
        public int ConferenceID { get; set; }
        public Nullable<bool> IsCredentialIssued { get; set; }
        public Nullable<int> EnrollmentMasterID { get; set; }
        public string Description { get; set; }
        public string EnrollmentDeadline { get; set; }
        public Nullable<System.DateTime> CredentialIssuanceDate { get; set; }
        public string Provider { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public Nullable<int> Enrolled { get; set; }
        public string Location { get; set; }
        public string PromotionalURL { get; set; }
    }
}