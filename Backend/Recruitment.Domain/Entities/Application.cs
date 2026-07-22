using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public class Application
    {
        public Guid Id { get; set; }

        // Foreign Key to Job
        public Guid JobId { get; set; }
        public virtual Job? Job { get; set; }

        // Foreign Key to Candidate
        public Guid CandidateId { get; set; }
        public virtual Candidate? Candidate { get; set; }

        public DateTime ApplyDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending";

        // Navigation properties
        public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();
    }
}
