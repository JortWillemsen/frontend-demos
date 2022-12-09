using BlazorMud.API.Ports.Database;
using BlazorMud.Core;
using DotnetCute.Exceptions.Http.Client;

namespace BlazorMud.API.Adapters.Database.Postgres;

public class PostRepository : IPostRepository
{
    private readonly DatabaseContext _context;
    
    public PostRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    public Post CreatePost(Post post)
    {
        var result = _context.Posts.Add(post);
        _context.SaveChanges();

        return result.Entity;
    }

    public Post FindPostById(Guid id)
    {
        var result = _context.Posts.FirstOrDefault(p => p.Id == id);

        if (result == null)
            throw new NotFoundException("Could not find post with id: " + id);

        return result;
    }

    public ICollection<Post> FindAllPosts()
    {
        return _context.Posts.ToList();
    }
}