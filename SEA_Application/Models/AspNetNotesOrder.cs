//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEA_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetNotesOrder
    {
        public int Id { get; set; }
        public Nullable<int> NotesID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string OrderType { get; set; }
    
        public virtual AspNetNote AspNetNote { get; set; }
        public virtual AspNetOrder AspNetOrder { get; set; }
        public virtual AspNetStudent AspNetStudent { get; set; }
    }
}