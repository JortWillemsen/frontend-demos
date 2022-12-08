using BlazorMud.API.Domain;
using BlazorMud.API.Ports.Database;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMud.API.Adapters.Http;

[ApiController]
[Route("api/post")]
public class PostController
{
    private readonly IPostRepository _postRepository;

    public PostController(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    [HttpPost]
    public ActionResult<Post> CreatePost(Post post)
    {
        var result = _postRepository.CreatePost(post);

        return result;
    }

    [HttpGet]
    public ICollection<Post> GetAllPosts()
    {
        var result = _postRepository.FindAllPosts();

        return result;
    }
}