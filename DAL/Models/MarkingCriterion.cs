using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MarkingCriterion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string Value { get; set; }
    }
}
