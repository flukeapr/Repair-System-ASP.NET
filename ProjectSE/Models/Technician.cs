//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Technician
    {
        
       [Key] public int technician_Id { get; set; }
        public string technicianName { get; set; }
        public string typeRepair { get; set; }
        public string phone { get; set; }
        public string image { get; set; }
    }
}
