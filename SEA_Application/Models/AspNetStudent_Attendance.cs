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
    
    public partial class AspNetStudent_Attendance
    {
        public int Id { get; set; }
        public int AttendanceID { get; set; }
        public string StudentID { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    
        public virtual AspNetAttendance AspNetAttendance { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
