using ATOS.Resource.Abstraction;
using ATOS.Resource.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOS.Resource.POCOs
{
    public class Colaborador : Person, IEntityBaseAuditable<Guid, Guid>
    {

        public string emailAtos { get; set; } = string.Empty;
        public string? emailClient { get; set; } = string.Empty;
        public string DASid { get; set; } = string.Empty;
        public string TimeSheet { get; set; } = string.Empty;
        public string GCMDetails { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public string? Device { get; set; } = string.Empty;
        public string? DeviceSerialNumber { get; set; } = string.Empty;
        public string? ProfilePhoto { get; set; } = string.Empty;
        public string PID { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ReasonOut { get; set; } = string.Empty;
        public string? CurrentPosition { get; set; } = string.Empty;
        public DateTime ModifyDate { get ; set ; }
        public Guid ModifiedBy { get ; set ; }
    }
}
