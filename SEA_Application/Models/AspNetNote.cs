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
    
    public partial class AspNetNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetNote()
        {
            this.AspNetNotesOrders = new HashSet<AspNetNotesOrder>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public string CourseType { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string NotesType { get; set; }
        public Nullable<double> OAPrice { get; set; }
        public Nullable<double> BookPrice { get; set; }
        public Nullable<double> BindingPrice { get; set; }
        public Nullable<double> Pages { get; set; }
        public Nullable<double> PerPagePrice { get; set; }
        public Nullable<double> PhotoCopierPrice { get; set; }
        public Nullable<double> OABookPercentage { get; set; }
        public Nullable<double> GrandTotal { get; set; }
    
        public virtual AspNetSubject AspNetSubject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetNotesOrder> AspNetNotesOrders { get; set; }
    }
}
