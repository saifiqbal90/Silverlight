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
    
    public partial class tbl_Regulators
    {
        public tbl_Regulators()
        {
            this.tbl_org_regulation = new HashSet<tbl_org_regulation>();
        }
    
        public int Regulator_ID { get; set; }
        public int Organization_ID { get; set; }
    
        public virtual ICollection<tbl_org_regulation> tbl_org_regulation { get; set; }
    }
}