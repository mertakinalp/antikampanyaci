//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntiKampanyaci.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLogin
    {
        public long LoginAttemptId { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public Nullable<System.DateTime> LoginDatetime { get; set; }
        public string FacebookId { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public string IP { get; set; }
        public string UserAgent { get; set; }
        public string FacebookName { get; set; }
    }
}