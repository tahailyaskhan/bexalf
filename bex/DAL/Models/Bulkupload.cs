﻿using System;
using System.Collections.Generic;

#nullable disable

namespace bex.DAL.Models
{
    public partial class Bulkupload
    {
        public int Id { get; set; }
        public string Branchcode { get; set; }
        public string Checklistname { get; set; }
        public string Ytd { get; set; }
        public int? UploadedBy { get; set; }
        public DateTime? UploadedOn { get; set; }
        public string Subattribute { get; set; }
    }
}
