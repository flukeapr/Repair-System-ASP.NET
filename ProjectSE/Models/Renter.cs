﻿//------------------------------------------------------------------------------
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

    public partial class Renter
    {

        public int renter_Id { get; set; }
        [Display(Name = "ชื่อ :")]
        public string name { get; set; }
        [Display(Name = "เบอร์โทรศํพท์ :")]
        public string phone { get; set; }
        [Display(Name = "ที่อยู่ :")]
        public string address { get; set; }
        [Display(Name = "เลขห้อง :")]
        public int room_Id { get; set; }
        public Nullable<int> acc_id { get; set; }
    }
}
