﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EmailListing
    {
        public int Id { get; set; }
        public string InputterType { get; set; }
        public string BranchId { get; set; }
        public string EmailListType { get; set; }
        public string EmailAddress { get; set; }
        public string Domain { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string ExtraRecipientEmailAddress { get; set; }
        public bool? IsGroupEmail { get; set; }
    }
}
