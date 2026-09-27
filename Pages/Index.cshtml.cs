using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MicroBlog.Pages;

public class IndexModel : PageModel
{
    public IEnumerable<Post> Posts { get; internal set; }

    public void OnGet()
    {
        string path = System.IO.Directory.GetCurrentDirectory() + @"\data\posts.json";

        string json = System.IO.File.ReadAllText(path);
        List<Post> posts = System.Text.Json.JsonSerializer.Deserialize<List<Post>>(json);

        Posts = posts;
    }
}
