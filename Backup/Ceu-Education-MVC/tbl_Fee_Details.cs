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
    
    public partial class tbl_Fee_Details
    {
        public int FeeDetailID { get; set; }
        public int FeeMasterID { get; set; }
        public int FeeTypeID { get; set; }
        public decimal FeeDesc { get; set; }
        public string PromoCode { get; set; }
    
        public virtual tbl_Fee_Master tbl_Fee_Master { get; set; }
        public virtual tbl_Fee_Types tbl_Fee_Types { get; set; }
    }
}