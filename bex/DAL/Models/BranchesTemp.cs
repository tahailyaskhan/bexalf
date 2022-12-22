﻿using System;
using System.Collections.Generic;

#nullable disable

namespace bex.DAL.Models
{
    public partial class BranchesTemp
    {
        public int Id { get; set; }
        public string Atmid { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string BusinessRegion { get; set; }
        public string Area { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Modifiedby { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
