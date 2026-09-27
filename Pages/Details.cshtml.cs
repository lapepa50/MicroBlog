using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MicroBlog.Pages
{
    public class DetailsModel : PageModel
    {
        public Post Post { get; set; }
        public void OnGet(int id)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\data\posts.json";

            string json = System.IO.File.ReadAllText(path);
            List<Post> posts = System.Text.Json.JsonSerializer.Deserialize<List<Post>>(json) ?? new List<Post>();

            Post = posts.FirstOrDefault(post => post.ID == id);
        }
    }
}