using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MicroBlog.Pages
{
    public class CreateModel : PageModel
    {
        public object Title { get; internal set; }
        public object Body { get; internal set; }

        public void OnGet()
        {
        }
    }
    public class Post
    {
        public int ID { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Body { get; set; }
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
