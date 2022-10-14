using System.ComponentModel.DataAnnotations;

namespace Tracingwebapi.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Priority { get; set; }

        public string IssueType { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Completed { get; set; }
    }

    


}
