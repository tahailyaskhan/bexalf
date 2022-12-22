using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TblNotificationRolewise
    {
        public long Id { get; set; }
        public long NotificationId { get; set; }
        public long RoleId { get; set; }
    }
}
