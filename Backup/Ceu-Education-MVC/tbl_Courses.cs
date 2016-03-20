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
    
    public partial class tbl_Courses
    {
        public tbl_Courses()
        {
            this.tbl_CEU_Certificate_Download = new HashSet<tbl_CEU_Certificate_Download>();
            this.tbl_Conference_Courses = new HashSet<tbl_Conference_Courses>();
            this.tbl_Course_Credit_Issuers = new HashSet<tbl_Course_Credit_Issuers>();
            this.tbl_Course_Enrollment = new HashSet<tbl_Course_Enrollment>();
            this.tbl_Course_Facilities = new HashSet<tbl_Course_Facilities>();
            this.tbl_Course_Presenters = new HashSet<tbl_Course_Presenters>();
            this.tbl_Course_Sponsors = new HashSet<tbl_Course_Sponsors>();
            this.tbl_Course_Venue_Options = new HashSet<tbl_Course_Venue_Options>();
        }
    
        public int CourseID { get; set; }
        public int ProviderID { get; set; }
        public string CourseCode { get; set; }
        public string CourseSection { get; set; }
        public bool CourseIsOnline { get; set; }
        public bool CourseIsAssignedToConference { get; set; }
        public Nullable<int> FacilityID { get; set; }
        public string RoomNbr { get; set; }
        public short AttendeeCapacity { get; set; }
        public int CourseTopicID { get; set; }
        public int CourseFocusID { get; set; }
        public int CourseLearningOutcomeID { get; set; }
        public int CourseEffectID { get; set; }
        public int CourseEvaluationMethodID { get; set; }
        public string CourseDescription { get; set; }
        public System.DateTime CourseDate { get; set; }
        public Nullable<System.TimeSpan> CourseStartTime { get; set; }
        public Nullable<System.TimeSpan> CourseEndTime { get; set; }
        public Nullable<int> SurveyID { get; set; }
        public Nullable<System.DateTime> CourseEnrollmentDeadline { get; set; }
        public Nullable<System.DateTime> CredentialIssuanceDate { get; set; }
        public Nullable<System.TimeSpan> CourseOffTaskTime { get; set; }
        public string Promotionalurl { get; set; }
        public Nullable<int> PreSurveyID { get; set; }
        public Nullable<System.DateTime> CourseEnddate { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public Nullable<int> SetASideCapacity { get; set; }
    
        public virtual ICollection<tbl_CEU_Certificate_Download> tbl_CEU_Certificate_Download { get; set; }
        public virtual ICollection<tbl_Conference_Courses> tbl_Conference_Courses { get; set; }
        public virtual ICollection<tbl_Course_Credit_Issuers> tbl_Course_Credit_Issuers { get; set; }
        public virtual ICollection<tbl_Course_Enrollment> tbl_Course_Enrollment { get; set; }
        public virtual ICollection<tbl_Course_Facilities> tbl_Course_Facilities { get; set; }
        public virtual ICollection<tbl_Course_Presenters> tbl_Course_Presenters { get; set; }
        public virtual ICollection<tbl_Course_Sponsors> tbl_Course_Sponsors { get; set; }
        public virtual ICollection<tbl_Course_Venue_Options> tbl_Course_Venue_Options { get; set; }
    }
}
