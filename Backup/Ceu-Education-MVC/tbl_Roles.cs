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
    
    public partial class tbl_Roles
    {
        public tbl_Roles()
        {
            this.tbl_Person_Organization_Roles = new HashSet<tbl_Person_Organization_Roles>();
        }
    
        public int RoleID { get; set; }
        public int RoleTypeID { get; set; }
        public string RoleDesc { get; set; }
        public Nullable<short> SecurityAccessLevel { get; set; }
    
        public virtual ICollection<tbl_Person_Organization_Roles> tbl_Person_Organization_Roles { get; set; }
        public virtual tbl_Role_Types tbl_Role_Types { get; set; }
    }
}
