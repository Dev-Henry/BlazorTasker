using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models
{
    public class TaskerItem
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Every Task must have a name")]
        public string Name { get; set; } = "";

        public bool IsComplete { get; set; } = false;
    }
}
