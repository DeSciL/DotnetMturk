using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.WebServices.MechanicalTurk.Domain
{
    /// <summary>
    /// Convenience Type for PowerShell Access
    /// </summary>
    public class HITType
    {
        /// <remarks />
        public int AutoApprovalDelayInSeconds { get; set; }
        /// <remarks />
        public int AssignmentDurationInSeconds { get; set; }
        /// <remarks />
        public Price Reward { get; set; }
        /// <remarks />
        public string Title { get; set; }
        /// <remarks />
        public string Keywords { get; set; }
        /// <remarks />
        public string Description { get; set; }
        /// <remarks />
        public QualificationRequirement[] QualificationRequirement { get; set; }
        /// <remarks />
        public string[] ResponseGroup { get; set; }
    }
}
