﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblRegion
    {
        public decimal Id { get; set; }
        public decimal? CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal? ModifiedBy { get; set; }
    }
}
