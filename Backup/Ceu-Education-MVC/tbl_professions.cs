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
    
    public partial class tbl_professions
    {
        public tbl_professions()
        {
            this.tbl_Persons_Professions = new HashSet<tbl_Persons_Professions>();
        }
    
        public int Profession_ID { get; set; }
        public string Profession_description { get; set; }
    
        public virtual ICollection<tbl_Persons_Professions> tbl_Persons_Professions { get; set; }
    }
}
