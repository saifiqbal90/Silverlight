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
    
    public partial class tbl_Person_Licenses
    {
        public int PersonLicenseID { get; set; }
        public int PersonID { get; set; }
        public int LicenseID { get; set; }
        public string LicenseNum { get; set; }
        public Nullable<System.DateTime> DateLicenseExpires { get; set; }
        public int LicenseStateID { get; set; }
    
        public virtual tbl_Licenses tbl_Licenses { get; set; }
        public virtual tbl_Person tbl_Person { get; set; }
    }
}
