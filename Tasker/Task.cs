using System.ComponentModel.DataAnnotations;

namespace Tasker
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Priority { get; set; }
    }
}
