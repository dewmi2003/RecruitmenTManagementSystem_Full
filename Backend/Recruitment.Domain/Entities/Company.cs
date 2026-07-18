using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;

        // Navigation properties
        public virtual ICollection<Recruiter> Recruiters { get; set; } = new List<Recruiter>();
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
